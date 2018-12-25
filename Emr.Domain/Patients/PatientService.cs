using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Patients.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Patients
{
    public class PatientService : IPatientService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PatientService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(PatientInfo patient)
        {
            var client = _mapper.Map<Client>(patient.Client);
            client.RoleId = (int)RolesEnum.Patient;
            _context.Clients.Add(client);
            var result = _mapper.Map<Patient>(patient);
            result.ClientGuid = client.ClientGuid;
            result.AdminGuid = patient.AdminGuid;
            _context.Patients.Add(result);
            await _context.SaveChangesAsync();
            return result.PatientGuid;
        }

        /// <inheritdoc />
        public async Task Edit(PatientInfo patient, Guid patientGuid)
        {
            var result = await _context.Patients.SingleAsync(x => x.PatientGuid == patientGuid);
            _mapper.Map(patient, result);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<List<PatientModel>> Get(string search = "")
        {
            var res = _context.Patients
                .Include(x => x.Client)
                .Include(x => x.Admin)
                .AsNoTracking();
            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                res = res.Where(x => x.HealthInsurancePolicy.ToLower().Contains(search));
            }
            return await res
                .ProjectTo<PatientModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid patientGuid)
        {
            var result = await _context.Patients.SingleAsync(x => x.PatientGuid == patientGuid);
            _context.Patients.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Medics.Models;
using Emr.Domain.Patients.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Medics
{
    public class MedicService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public MedicService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(MedicInfo patient)
        {
            var client = _mapper.Map<Client>(patient.Client);
            client.RoleId = (int)RolesEnum.Patient;
            _context.Clients.Add(client);
            var result = _mapper.Map<Medic>(patient);
            result.ClientGuid = client.ClientGuid;
            result.AdminGuid = patient.AdminGuid;
            _context.Medics.Add(result);
            await _context.SaveChangesAsync();
            return result.MedicGuid;
        }

        public async Task<List<MedicModel>> Get()
        {
            return await _context.Medics
                .Include(x => x.Client)
                .Include(x => x.Admin)
                .AsNoTracking()
                .ProjectTo<MedicModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid medicGuid)
        {
            var result = await _context.Medics.SingleAsync(x => x.MedicGuid == medicGuid);
            _context.Medics.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

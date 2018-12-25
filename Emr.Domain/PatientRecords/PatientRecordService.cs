using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.PatientRecords.Models;
using Emr.Domain.Patients.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.PatientRecords
{
    public class PatientRecordService
    {
        private readonly DatabaseContext _context;

        public PatientRecordService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Guid> Create(PatientRecordInfo infoModel)
        {
            var res = Mapper.Map<PatientRecord>(infoModel);
            _context.PatientRecords.Add(res);
            await _context.SaveChangesAsync();
            return res.PatientRecordGuid;
        }

        public async Task<Guid> Delete(Guid patientRecordGuid)
        {
            var res = await _context.PatientRecords
                .FirstAsync(x => x.PatientRecordGuid == patientRecordGuid);
            _context.PatientRecords.Remove(res);
            await _context.SaveChangesAsync();
            return res.PatientRecordGuid;
        }

        public async Task<List<PatientRecordModel>> Get(string search = "")
        {
            return await _context.PatientRecords
                .ProjectTo<PatientRecordModel>()
                .ToListAsync();
        }
    }
}

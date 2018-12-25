using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.BloodTypes.Models;
using Emr.Domain.Epmrs.Models;
using Microsoft.EntityFrameworkCore;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

namespace Emr.Domain.Epmrs
{
    public class EpmrService : IEpmrService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public EpmrService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(EpmrInfo model)
        {
            var result = _mapper.Map<ElectronicPersonalMedicalRecord>(model);
            _context.ElectronicPersonalMedicalRecords.Add(result);
            await _context.SaveChangesAsync();
            return result.EpmrGuid;
        }

        /// <inheritdoc />
        public async Task<List<EpmrModel>> Get()
        {
            return await _context.ElectronicPersonalMedicalRecords
                .ProjectTo<EpmrModel>()
                .ToListAsync();
        }

    }
}

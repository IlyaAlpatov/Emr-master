using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.BloodTypes.Models;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Epmrs.Models;
using Microsoft.EntityFrameworkCore;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

namespace Emr.Domain.Diagnos
{
    public class DiagnosService : IDiagnosService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public DiagnosService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(DiagnosInfo model)
        {
            var result = _mapper.Map<Database.Models.Diagnos>(model);
            _context.Diagnoses.Add(result);
            await _context.SaveChangesAsync();
            return result.DiagnosGuid;
        }

        /// <inheritdoc />
        public async Task<List<DiagnosModel>> Get()
        {
            return await _context.Diagnoses
                .ProjectTo<DiagnosModel>()
                .ToListAsync();
        }

    }
}

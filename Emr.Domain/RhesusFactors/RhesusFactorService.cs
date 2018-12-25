using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.RhesusFactors.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.RhesusFactors
{
    public class RhesusFactorService : IRhesusFactorService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public RhesusFactorService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(RhesusFactorInfo model)
        {
            var result = _mapper.Map<RhesusFactor>(model);
            _context.RhesusFactors.Add(result);
            await _context.SaveChangesAsync();
            return result.RhesusFactorGuid;
        }

        /// <inheritdoc />
        public async Task<List<RhesusFactorModel>> Get()
        {
            return await _context.RhesusFactors
                .ProjectTo<RhesusFactorModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid rhesusfactorGuid)
        {
            var result = await _context.RhesusFactors.SingleAsync(x => x.RhesusFactorGuid == rhesusfactorGuid);
            _context.RhesusFactors.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

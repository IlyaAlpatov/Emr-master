using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Drags.Models;
using Emr.Domain.HealGroups.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.HealGroups
{
    //Наследуем от IDragService
    public class HealthService : IHealthService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public HealthService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(HealthInfo model)
        {
            var result = _mapper.Map<HealthGroup>(model);
            _context.HealthGroups.Add(result);
            await _context.SaveChangesAsync();
            return result.HealthGroupGuid;
        }

        /// <inheritdoc />
        public async Task<List<HealthModel>> Get()
        {
            return await _context.HealthGroups
                .ProjectTo<HealthModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid healthGuid)
        {
            var result = await _context.HealthGroups.SingleAsync(x => x.HealthGroupGuid == healthGuid);
            _context.HealthGroups.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

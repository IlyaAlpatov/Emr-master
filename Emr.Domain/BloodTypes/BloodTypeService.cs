using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.BloodTypes.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.BloodTypes
{
    public class BloodTypeService : IBloodTypeService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BloodTypeService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(BloodTypeInfo model)
        {
            var result = _mapper.Map<BloodType>(model);
            _context.BloodTypes.Add(result);
            await _context.SaveChangesAsync();
            return result.BloodTypeGuid;
        }

        /// <inheritdoc />
        public async Task<List<BloodTypeModel>> Get()
        {
            return await _context.BloodTypes
                .ProjectTo<BloodTypeModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid bloodtypeGuid)
        {
            var result = await _context.BloodTypes.SingleAsync(x => x.BloodTypeGuid == bloodtypeGuid);
            _context.BloodTypes.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

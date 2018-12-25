using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.TypeOfDisability.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.TypeOfDisability
{
    //Наследуем от IDragService
    public class TypeDisabilityService : ITypeDisabilityService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public TypeDisabilityService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(TypeDisabilityInfo model)
        {
            var result = _mapper.Map<Database.Models.TypeOfDisability>(model);
            _context.TypeOfDisabilities.Add(result);
            await _context.SaveChangesAsync();
            return result.TypeOfDisabilityGuid;
        }

        /// <inheritdoc />
        public async Task<List<TypeDisabilityModel>> Get()
        {
            return await _context.TypeOfDisabilities
                .ProjectTo<TypeDisabilityModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task Delete(Guid TypeDisabilityGuid)
        {
            var result = await _context.TypeOfDisabilities.SingleAsync(x => x.TypeOfDisabilityGuid == TypeDisabilityGuid);
            _context.TypeOfDisabilities.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

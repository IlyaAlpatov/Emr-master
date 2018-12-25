using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Researchs.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Researchs
{
    public class ResearchService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ResearchService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> CreateResearch(ResearchInfo research)
        {
            var result = _mapper.Map<Research>(research);
            _context.Researches.Add(result);
            await _context.SaveChangesAsync();
            return result.ResearchGuid;
        }

        public async Task<List<ResearchModel>> GetResearch(string search="")
        {
            return await _context.Researches
                .AsNoTracking()
                .ProjectTo<ResearchModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task DeleteResearch(Guid researchGuid)
        {
            var result = await _context.Researches.SingleAsync(x => x.ResearchGuid == researchGuid);
            _context.Researches.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Guid> CreateResearchResult(ResearchResultInfo info)
        {
            var result = _mapper.Map<ResearchResult>(info);
            _context.ResearchResults.Add(result);
            await _context.SaveChangesAsync();
            return result.ResearchResultGuid;
        }

        public async Task<List<ResearchResultModel>> GetResearchResult(string search = "")
        {
            return await _context.ResearchResults
                .Include(x => x.Patient)
                .AsNoTracking()
                .ProjectTo<ResearchResultModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task DeleteResearchResult(Guid deletedGuid)
        {
            var result = await _context.ResearchResults.SingleAsync(x => x.ResearchResultGuid == deletedGuid);
            _context.ResearchResults.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

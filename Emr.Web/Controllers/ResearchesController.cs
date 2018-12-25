using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.Researchs;
using Emr.Domain.Researchs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Authorize]
    [Route("api/researches")]
    [ApiController]
    public class ResearchesController : Controller
    {
        private readonly ResearchService _researchService;

        public ResearchesController(ResearchService researchService)
        {
            _researchService = researchService;
        }

        [HttpPost("researches")]
        public async Task<Guid> CreateResearch(ResearchInfo info)
        {
            return await _researchService.CreateResearch(info);
        }

        [HttpGet("researches")]
        public async Task<List<ResearchModel>> GetResearch()
        {
            return await _researchService.GetResearch();
        }

        [HttpPost("researchResult")]
        public async Task<Guid> CreateResearchResult(ResearchResultInfo info)
        {
            return await _researchService.CreateResearchResult(info);
        }

        [HttpGet("researchResult")]
        public async Task<List<ResearchResultModel>> GetResearchResult()
        {
            return await _researchService.GetResearchResult();
        }
    }
}

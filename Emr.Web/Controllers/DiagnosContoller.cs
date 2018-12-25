using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.Diagnos;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Drags;
using Emr.Domain.Drags.Models;
using Emr.Domain.Epmrs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Route("api/diagnos")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class DiagnosContoller : Controller
    {
        private readonly IDiagnosService _diagnosService;

        public DiagnosContoller(IDiagnosService dragService)
        {
            _diagnosService = dragService;
        }

        [HttpPost]
        public async Task<Guid> Create(DiagnosInfo info)
        {
            return await _diagnosService.Create(info);
        }

        [HttpGet]
        public async Task<List<DiagnosModel>> Get()
        {
            return await _diagnosService.Get();
        }
    }
}

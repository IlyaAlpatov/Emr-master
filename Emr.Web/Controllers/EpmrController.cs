using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.Diagnos;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Drags;
using Emr.Domain.Drags.Models;
using Emr.Domain.Epmrs;
using Emr.Domain.Epmrs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Route("api/eprm")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class EpmrController : Controller
    {
        private readonly IEpmrService _epmrService;

        public EpmrController(IEpmrService epmrService)
        {
            _epmrService = epmrService;
        }

        [HttpPost]
        public async Task<Guid> Create(EpmrInfo info)
        {
            return await _epmrService.Create(info);
        }

        [HttpGet]
        public async Task<List<EpmrModel>> Get()
        {
            return await _epmrService.Get();
        }
    }
}

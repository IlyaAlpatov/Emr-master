using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.PatientRecords;
using Emr.Domain.PatientRecords.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Route("api/records")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class PatientRecordController : Controller
    {
        private readonly PatientRecordService _patientRecordService;

        public PatientRecordController(PatientRecordService patientRecordService)
        {
            _patientRecordService = patientRecordService;
        }

        [HttpPost]
        public async Task<Guid> Create(PatientRecordInfo info)
        {
            return await _patientRecordService.Create(info);
        }

        [HttpGet]
        public async Task<List<PatientRecordModel>> Get(string search)
        {
            return await _patientRecordService.Get(search);
        }
    }
}

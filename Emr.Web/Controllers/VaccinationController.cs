using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.Vaccinations;
using Emr.Domain.Vaccinations.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Authorize]
    [Route("api/Vaccinationes")]
    [ApiController]
    public class VaccinationController : Controller
    {
        private readonly VaccinationService _vaccinationService;

        public VaccinationController(VaccinationService VaccinationService)
        {
            _vaccinationService = VaccinationService;
        }

        [HttpPost("Vaccinationes")]
        public async Task<Guid> CreateVaccination(VaccinationInfo info)
        {
            return await _vaccinationService.CreateVaccination(info);
        }

        [HttpGet("Vaccinationes")]
        public async Task<List<VaccinationModel>> GetVaccination()
        {
            return await _vaccinationService.GetVaccination();
        }

        [HttpPost("VaccinationResult")]
        public async Task<Guid> CreateVaccinationResult(VaccinationResultInfo info)
        {
            return await _vaccinationService.CreateVaccinationResult(info);
        }

        [HttpGet("VaccinationResult")]
        public async Task<List<VaccinationResultModel>> GetVaccinationResult()
        {
            return await _vaccinationService.GetVaccinationResult();
        }
    }
}

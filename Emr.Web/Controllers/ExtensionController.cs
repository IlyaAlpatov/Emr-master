using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.BloodTypes;
using Emr.Domain.BloodTypes.Models;
using Emr.Domain.Drags;
using Emr.Domain.Drags.Models;
using Emr.Domain.HealGroups;
using Emr.Domain.HealGroups.Models;
using Emr.Domain.RhesusFactors;
using Emr.Domain.RhesusFactors.Models;
using Emr.Domain.TypeOfDisability;
using Emr.Domain.TypeOfDisability.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Route("api")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class ExtensionController : Controller
    {
        private readonly IDragService _dragService;
        private readonly IBloodTypeService _bloodTypeService;
        private readonly IRhesusFactorService _factorService;
        private readonly IHealthService _healthService;
        private readonly ITypeDisabilityService _disabilityService;

        public ExtensionController(IDragService dragService, IRhesusFactorService factorService, IHealthService healthService, IBloodTypeService bloodTypeService, ITypeDisabilityService disabilityService)
        {
            _dragService = dragService;
            _factorService = factorService;
            _healthService = healthService;
            _bloodTypeService = bloodTypeService;
            _disabilityService = disabilityService;
        }

        [HttpPost("drag")]
        public async Task<Guid> CreateDrag(DragInfo info)
        {
            return await _dragService.Create(info);
        }

        [HttpGet("drag")]
        public async Task<List<DragModel>> GetDrags()
        {
            return await _dragService.Get();
        }

        [HttpDelete("drag/{dragGuid}")]
        public async Task DeleteDrag(Guid dragGuid)
        {
            await _dragService.Delete(dragGuid);
        }

        [HttpPost("bloodType")]
        public async Task<Guid> CreatebloodType(BloodTypeInfo info)
        {
            return await _bloodTypeService.Create(info);
        }

        [HttpGet("bloodType")]
        public async Task<List<BloodTypeModel>> GetbloodType()
        {
            return await _bloodTypeService.Get();
        }

        [HttpDelete("bloodType/{bloodTypeGuid}")]
        public async Task DeletebloodType(Guid bloodTypeGuid)
        {
            await _bloodTypeService.Delete(bloodTypeGuid);
        }

        [HttpPost("factor")]
        public async Task<Guid> CreateFactor(RhesusFactorInfo info)
        {
            return await _factorService.Create(info);
        }

        [HttpGet("factor")]
        public async Task<List<RhesusFactorModel>> GetFactor()
        {
            return await _factorService.Get();
        }

        [HttpDelete("factor/{factorGuid}")]
        public async Task DeleteFactor(Guid factorGuid)
        {
            await _factorService.Delete(factorGuid);
        }

        [HttpPost("healthGroup")]
        public async Task<Guid> CreatehealthGroup(HealthInfo info)
        {
            return await _healthService.Create(info);
        }

        [HttpGet("healthGroup")]
        public async Task<List<HealthModel>> GethealthGroup()
        {
            return await _healthService.Get();
        }

        [HttpDelete("healthGroup/{healthGroupGuid}")]
        public async Task DeletehealthGroup(Guid healthGroupGuid)
        {
            await _healthService.Delete(healthGroupGuid);
        }

        [HttpPost("typeDisability")]
        public async Task<Guid> CreatetypeDisability(TypeDisabilityInfo info)
        {
            return await _disabilityService.Create(info);
        }

        [HttpGet("typeDisability")]
        public async Task<List<TypeDisabilityModel>> GettypeDisability()
        {
            return await _disabilityService.Get();
        }

        [HttpDelete("typeDisability/{typeDisabilityGuid}")]
        public async Task DeletetypeDisability(Guid typeDisabilityGuid)
        {
            await _disabilityService.Delete(typeDisabilityGuid);
        }

    }
}

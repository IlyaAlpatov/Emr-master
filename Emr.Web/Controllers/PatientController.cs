using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.Medics;
using Emr.Domain.Medics.Models;
using Microsoft.AspNetCore.Mvc;


namespace Emr.Web.Controllers
{
    [Route("api/medics")]
    [ApiController]
    public class MedicController : Controller
    {
        private readonly MedicService _medicService;

        public MedicController(MedicService medicService)
        {
            _medicService = medicService;
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(MedicInfo infoModel)
        {
            return await _medicService.Create(infoModel);
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="medicGuid"></param>
        /// <returns></returns>
        [HttpDelete("{medicGuid}")]
        public async Task Delete(Guid medicGuid)
        {
            await _medicService.Delete(medicGuid);
        }

        /// <summary>
        /// Создание пациента
        /// </summary>
        /// <param name="infoModel"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<MedicModel>> Get(string search)
        {
            return await _medicService.Get();
        }

    }
}

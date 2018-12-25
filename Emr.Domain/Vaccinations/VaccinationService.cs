using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Vaccinations.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Domain.Vaccinations
{
    public class VaccinationService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public VaccinationService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<Guid> CreateVaccination(VaccinationInfo Vaccination)
        {
            var result = _mapper.Map<Vaccination>(Vaccination);
            _context.Vaccinations.Add(result);
            await _context.SaveChangesAsync();
            return result.VaccinationGuid;
        }

        public async Task<List<VaccinationModel>> GetVaccination(string search="")
        {
            return await _context.Vaccinations
                .AsNoTracking()
                .ProjectTo<VaccinationModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task DeleteVaccination(Guid VaccinationGuid)
        {
            var result = await _context.Vaccinations.SingleAsync(x => x.VaccinationGuid == VaccinationGuid);
            _context.Vaccinations.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<Guid> CreateVaccinationResult(VaccinationResultInfo info)
        {
            var result = _mapper.Map<VaccinationResult>(info);
            _context.VaccinationResults.Add(result);
            await _context.SaveChangesAsync();
            return result.VaccinationResultGuid;
        }

        public async Task<List<VaccinationResultModel>> GetVaccinationResult(string search = "")
        {
            return await _context.VaccinationResults
                .Include(x => x.Patient)
                .AsNoTracking()
                .ProjectTo<VaccinationResultModel>()
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task DeleteVaccinationResult(Guid deletedGuid)
        {
            var result = await _context.VaccinationResults.SingleAsync(x => x.VaccinationResultGuid == deletedGuid);
            _context.VaccinationResults.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}

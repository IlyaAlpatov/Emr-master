using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.RhesusFactors.Models;

namespace Emr.Domain.RhesusFactors
{
    public interface IRhesusFactorService
    {
        Task<Guid> Create(RhesusFactorInfo model);

        Task<List<RhesusFactorModel>> Get();

        Task Delete(Guid rhesusfactorGuid);
    }
}

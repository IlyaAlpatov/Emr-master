using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.HealGroups.Models;

namespace Emr.Domain.HealGroups
{
    //Потом добавить в Sturtup (services.AddScoped<>)
    public interface IHealthService
    {
        Task<Guid> Create(HealthInfo model);

        Task<List<HealthModel>> Get();

        Task Delete(Guid dragGuid);
    }
}

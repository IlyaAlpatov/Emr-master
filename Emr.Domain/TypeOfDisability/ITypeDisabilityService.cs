using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.TypeOfDisability.Models;

namespace Emr.Domain.TypeOfDisability
{
    //Потом добавить в Sturtup (services.AddScoped<>)
    public interface ITypeDisabilityService
    {
        Task<Guid> Create(TypeDisabilityInfo model);

        Task<List<TypeDisabilityModel>> Get();

        Task Delete(Guid dragGuid);
    }
}

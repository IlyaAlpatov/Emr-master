using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.BloodTypes.Models;

namespace Emr.Domain.BloodTypes
{
    public interface IBloodTypeService
    {
        Task<Guid> Create(BloodTypeInfo model);

        Task<List<BloodTypeModel>> Get();

        Task Delete(Guid bloodtypeGuid);
    }
}

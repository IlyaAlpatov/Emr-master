using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.Epmrs.Models;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

namespace Emr.Domain.Epmrs
{
    public interface IEpmrService
    {
        Task<Guid> Create(EpmrInfo model);

        Task<List<EpmrModel>> Get();
    }
}

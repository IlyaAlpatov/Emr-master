using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Epmrs.Models;
using DiagnosInfo = Emr.Domain.Diagnos.Models.DiagnosInfo;

namespace Emr.Domain.Diagnos
{
    public interface IDiagnosService
    {
        Task<Guid> Create(DiagnosInfo model);

        Task<List<DiagnosModel>> Get();
    }
}

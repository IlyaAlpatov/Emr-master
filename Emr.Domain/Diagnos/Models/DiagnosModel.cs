using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.Diagnos.Models
{
    public class DiagnosModel
    {
        public Guid DiagnosGuid { get; set; }

        public string NameDiagnos { get; set; }

        public string Description { get; set; }


        public DiagnosModel()
        {
        }
    }
}

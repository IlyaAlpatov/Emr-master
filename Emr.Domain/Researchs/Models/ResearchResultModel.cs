using System;
using Emr.Domain.Common;
using Emr.Domain.Medics.Models;
using Emr.Domain.Patients.Models;

namespace Emr.Domain.Researchs.Models
{
    public class ResearchResultModel
    {
        public Guid ResearchResultGuid { get; set; }

        
        public PatientModel Patient { get; set; }

        
        public MedicModel Medic { get; set; }

        
        public ResearchModel Research { get; set; }

        
        public DateTime Date { get; set; }
        
        public string Result { get; set; }

        
        public string Comment { get; set; }

        
        public string Description { get; set; }

        public ResearchResultModel()
        {
            
        }
    }
}

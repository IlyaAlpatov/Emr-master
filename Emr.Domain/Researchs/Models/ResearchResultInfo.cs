using System;
using Emr.Domain.Common;

namespace Emr.Domain.Researchs.Models
{
    public class ResearchResultInfo
    {

        public Guid PatientGuid { get; set; }

        public Guid MedicGuid { get; set; }

        public Guid ResearchGuid { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Result { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }

        public ResearchResultInfo()
        {
            
        }
    }
}

using System;
using Emr.Domain.Common;

namespace Emr.Domain.Vaccinations.Models
{
    public class VaccinationResultInfo
    {

        public Guid PatientGuid { get; set; }

        
        public Guid MedicGuid { get; set; }

        
        public Guid VaccinationGuid { get; set; }

        
        public DateTime Date { get; set; }

        
        public string Series { get; set; }

        
        public int Number { get; set; }

        
        public string Dose { get; set; }

        public VaccinationResultInfo()
        {
            
        }
    }
}

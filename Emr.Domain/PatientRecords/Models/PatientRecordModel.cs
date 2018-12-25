using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.PatientRecords.Models
{
    public class PatientRecordModel
    {
        public Guid PatientRecordGuid { get; set; }

        
        public Guid PatientGuid { get; set; }

        
        public Guid MedicGuid { get; set; }

        
        public Guid BloodTypeGuid { get; set; }

        
        public Guid RhesusFactorGuid { get; set; }

        
        public Guid HealthGroupGuid { get; set; }

        
        public string Conclusion { get; set; }

        
        public Guid DisabilityGuid { get; set; }

        //Дата осмотра
        
        public DateTime PatientRecordDate { get; set; }

        
        public string SocialStatus { get; set; }

        public bool Smoking { get; set; }

        public bool Alcoholism { get; set; }

        public bool Addiction { get; set; }

        
        public string AllergicHistory { get; set; }

        
        public string Characteristics { get; set; }

        
        public string ChildrenDiseases { get; set; }

        
        public string FamilyHistory { get; set; }

        public PatientRecordModel()
        {
            
        }
    }
}

using System;
using Emr.Domain.Common;

namespace Emr.Domain.Patients.Models
{
    public class PatientInfo
    {
        public Guid AdminGuid { get; set; }
        public virtual ClientInfo Client { get; set; }

        public string HealthInsurancePolicy { get; set; }

        public int MaritalStatus { get; set; }

        public int LevelOfEducation { get; set; }

        public int PlaceOfWork { get; set; }

        public PatientInfo()
        {
            
        }
    }
}

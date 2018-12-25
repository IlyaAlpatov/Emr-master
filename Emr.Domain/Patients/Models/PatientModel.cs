using System;
using Emr.Domain.Common;

namespace Emr.Domain.Patients.Models
{
    public class PatientModel
    {
        public Guid PatientGuid { get; set; }

        public ClientModel Client { get; set; }

        public Guid AdminGuid { get; set; }

        public string HealthInsurancePolicy { get; set; }

        public int MaritalStatus { get; set; }
        
        public int LevelOfEducation { get; set; }

        public int PlaceOfWork { get; set; }

        public PatientModel()
        {

        }
    }
}

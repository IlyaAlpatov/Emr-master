using System;
using Emr.Domain.Medics.Models;
using Emr.Domain.Patients.Models;

namespace Emr.Domain.Vaccinations.Models
{
    public class VaccinationResultModel
    {
        public Guid VaccinationResultGuid { get; set; }


        public PatientModel Patient { get; set; }


        public MedicModel Medic { get; set; }


        public VaccinationModel Vaccination { get; set; }


        public DateTime Date { get; set; }


        public string Series { get; set; }


        public int Number { get; set; }


        public string Dose { get; set; }

        public VaccinationResultModel()
        {
            
        }
    }
}

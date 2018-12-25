using System;

namespace Emr.Domain.Vaccinations.Models
{
    public class VaccinationModel
    {
        public Guid VaccinationGuid { get; set; }

        public string NameVaccination { get; set; }

        public string Description { get; set; }

        public VaccinationModel()
        {
            
        }
    }
}

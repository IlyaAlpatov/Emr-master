using System;
using Emr.Database.Models;
using Emr.Domain.Diagnos.Models;
using Emr.Domain.Medics.Models;
using Emr.Domain.Patients.Models;
using Emr.Domain.Researchs.Models;
using Emr.Domain.Vaccinations.Models;

namespace Emr.Domain.Epmrs.Models
{
    public class EpmrModel
    {
        public Guid EpmrGuid { get; set; }

        
        public PatientModel Patient { get; set; }

        
        public MedicModel Medic { get; set; }

        
        public DiagnosModel Diagnos { get; set; }

        
        public ResearchResultModel ResearchResult { get; set; }

        
        public VaccinationResultModel VaccinationResult { get; set; }

        //Дата открытия
        
        public DateTime Date { get; set; }

        //Дата подписания
        
        public DateTime Signing { get; set; }

        
        
        public string Symptons { get; set; }

        
        public string ReceptionResults { get; set; }

        
        public string Comment { get; set; }


        public EpmrModel()
        {
        }
    }
}

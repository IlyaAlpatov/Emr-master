using System;

namespace Emr.Domain.Epmrs.Models
{
    public class EpmrInfo
    {
        public Guid PatientGuid { get; set; }


        public Guid MedicGuid { get; set; }


        public Guid DiagnosGuid { get; set; }


        public Guid ResearchResultGuid { get; set; }


        public Guid VaccinationResultGuid { get; set; }

        //Дата открытия

        public DateTime Date { get; set; }

        //Дата подписания

        public DateTime Signing { get; set; }

        public string Symptons { get; set; }


        public string ReceptionResults { get; set; }


        public string Comment { get; set; }


        public EpmrInfo()
        {

        }
    }
}

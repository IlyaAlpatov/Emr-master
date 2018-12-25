using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Электронная персональная медицинская запись
    /// </summary>
    public class ElectronicPersonalMedicalRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid EpmrGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }

		[ForeignKey(nameof(Diagnos))]
        public Guid DiagnosGuid { get; set; }
		
		[ForeignKey(nameof(ResearchResult))]
        public Guid ResearchResultGuid { get; set; }
		
		[ForeignKey(nameof(VaccinationResult))]
        public Guid VaccinationResultGuid { get; set; }
		
        //Дата открытия
        [Required]
        public DateTime Date { get; set; }

        //Дата подписания
        [Required]
        public DateTime Signing { get; set; }

        [Required]
        [MaxLength(100)]
        public string Symptons { get; set; }
		
		[Required]
        public string ReceptionResults { get; set; }
		
		[Required]
        public string Comment { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
		
		public virtual Diagnos Diagnos { get; set; }
		
		public virtual ResearchResult ResearchResult { get; set; }
		
		public virtual VaccinationResult VaccinationResult { get; set; }
		
		public ElectronicPersonalMedicalRecord()
        {
            EpmrGuid = Guid.NewGuid();
        }
    }
}

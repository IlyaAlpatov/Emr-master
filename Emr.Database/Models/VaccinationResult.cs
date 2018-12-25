using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Результат прививки
    /// </summary>
    public class VaccinationResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid VaccinationResultGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }
		
		[ForeignKey(nameof(Vaccination))]
        public Guid VaccinationGuid { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Series { get; set; }
		
		[Required]
        public int Number{ get; set; }
		
		[Required]
        public string Dose { get; set; }


		public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
		
		public virtual Vaccination Vaccination { get; set; }
		
        public VaccinationResult()
        {
            VaccinationResultGuid = Guid.NewGuid();
        }
    }
}

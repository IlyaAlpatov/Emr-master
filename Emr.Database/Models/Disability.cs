using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Инвалидность
    /// </summary>
    public class Disability
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DisabilityGuid { get; set; }
		
		[ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }
		
		[ForeignKey(nameof(TypeOfDisability))]
        public Guid TypeOfDisabilityGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string Reasons { get; set; }

        [Required]
        public DateTime EstablishmentDate { get; set; }
		
        public DateTime LastSurveyDate { get; set; }
		
        public DateTime DateOfWithdrawal { get; set; }
		
		
		public virtual Medic Medic { get; set; }
		
		public virtual Patient Patient { get; set; }
		
		public virtual TypeOfDisability TypeOfDisability { get; set; }


        public Disability()
        {
            DisabilityGuid = Guid.NewGuid();
        }
    }
}

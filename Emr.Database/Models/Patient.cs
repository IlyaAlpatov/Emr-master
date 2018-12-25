using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emr.Database.Models
{
    /// <summary>
    /// Пациент
    /// </summary>
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PatientGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid ClientGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid AdminGuid { get; set; }
		
		[Required]
        [MaxLength(100)]
        public string HealthInsurancePolicy { get; set; }
		
		[MaxLength(100)]
        public int MaritalStatus { get; set; }
		
		[MaxLength(100)]
        public int LevelOfEducation { get; set; }
		
		[MaxLength(100)]
        public int PlaceOfWork { get; set; }
		
		public virtual Client Client { get; set; }

        public virtual Admin Admin { get; set; }
		

        public Patient()
        {
            PatientGuid = Guid.NewGuid();
        }
    }
}

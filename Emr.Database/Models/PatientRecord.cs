using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Карта пациента
    /// </summary>
    public class PatientRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PatientRecordGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }

        [ForeignKey(nameof(BloodType))]
        public Guid BloodTypeGuid { get; set; }

        [ForeignKey(nameof(RhesusFactor))]
        public Guid RhesusFactorGuid { get; set; }
		
		[ForeignKey(nameof(HealthGroup))]
        public Guid HealthGroupGuid { get; set; }
		
		[MaxLength(100)]
        public string Conclusion { get; set; }
		
		[ForeignKey(nameof(Disability))]
        public Guid DisabilityGuid { get; set; }

        //Дата осмотра
        [Required]
        public DateTime PatientRecordDate { get; set; }

        [MaxLength(100)]
        public string SocialStatus { get; set; }

        public bool Smoking { get; set; }

        public bool Alcoholism{ get; set; }
		
        public bool Addiction { get; set; }
		
		[MaxLength(100)]
        public string AllergicHistory { get; set; }
		
		[MaxLength(100)]
        public string Characteristics { get; set; }
		
		[MaxLength(100)]
        public string ChildrenDiseases { get; set; }
		
		[MaxLength(100)]
        public string FamilyHistory { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Medic  Medic { get; set; }

        public virtual BloodType BloodType { get; set; }

        public virtual RhesusFactor RhesusFactor { get; set; }
		
		public virtual HealthGroup HealthGroup { get; set; }
		
		public virtual Disability Disability { get; set; }
		
		public virtual ICollection<MedicalDrags> MedicalDrags { get; set; }
		
		public PatientRecord()
        {
            PatientRecordGuid = Guid.NewGuid();
        }
    }
}

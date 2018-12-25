using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Исследование
    /// </summary>
    public class ResearchResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ResearchResultGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }
		
		[ForeignKey(nameof(Research))]
        public Guid ResearchGuid { get; set; }
		
		[Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(100)]
        public string Result { get; set; }
		
		[Required]
        public string Comment { get; set; }

        [Required]
        public string Description { get; set; }
		
		public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
		
		public virtual Research Research { get; set; }
		
		public ResearchResult()
        {
            ResearchResultGuid = Guid.NewGuid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Emr.Database.Models
{
    /// <summary>
    /// Врач
    /// </summary>
    public class Medic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid MedicGuid { get; set; }
		
		[ForeignKey(nameof(Client))]
        public Guid ClientGuid { get; set; }
		
		[ForeignKey(nameof(Admin))]
        public Guid AdminGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialty { get; set; }

		[Required]
        [MaxLength(100)]
        public string Position { get; set; }

		[Required]
        [MaxLength(100)]
        public string Subdivision { get; set; }

		[Required]
        [MaxLength(100)]
        public string Qualification { get; set; }

		[Required]
        [MaxLength(100)]
        public string EducationalInstitution { get; set; }

		
		public virtual Client Client { get; set; }

        public virtual Admin Admin { get; set; }
		
		public Medic()
        {
            MedicGuid = Guid.NewGuid();
        }
    }
}

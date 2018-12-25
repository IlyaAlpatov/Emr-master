using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Рецепт
    /// </summary>
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RecipeGuid { get; set; }
		
		[ForeignKey(nameof(ElectronicPersonalMedicalRecord))]
        public Guid ElectronicPersonalMedicalRecordGuid { get; set; }
		
		[ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }
		
		[ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }
		
		[Required]
        public DateTime RecipeDate { get; set; }
		
		[Required]
        public string Series { get; set; }
		
		[Required]
        public string Room { get; set; }
		
		[Required]
        public string ShelfLife { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<RecieptDrags> RecieptDragses { get; set; }
		
		public virtual Patient Patient { get; set; }
		
		public virtual Medic Medic { get; set; }
		
		public virtual ElectronicPersonalMedicalRecord ElectronicPersonalMedicalRecord { get; set; }

        public Recipe()
        {
            RecipeGuid = Guid.NewGuid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Группа Крови
    /// </summary>
    public class BloodType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid BloodTypeGuid { get; set; }

        [Required]
        public int BloodTypeNumber { get; set; }

        [Required]
        public string RedCellType { get; set; }


        public BloodType()
        {
            BloodTypeGuid = Guid.NewGuid();
        }
    }
}

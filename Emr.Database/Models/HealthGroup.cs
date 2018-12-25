using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Группа здоровья
    /// </summary>
    public class HealthGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid HealthGroupGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameHealthGroup { get; set; }

        [Required]
        public string Description { get; set; }


        public HealthGroup()
        {
            HealthGroupGuid = Guid.NewGuid();
        }
    }
}

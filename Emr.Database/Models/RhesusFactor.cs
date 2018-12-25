using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Резус-фактор
    /// </summary>
    public class RhesusFactor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RhesusFactorGuid { get; set; }

        [Required]
        public string RhesusFactorView { get; set; }


        public RhesusFactor()
        {
            RhesusFactorGuid = Guid.NewGuid();
        }
    }
}

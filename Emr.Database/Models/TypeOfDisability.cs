using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Вид инвалидности
    /// </summary>
    public class TypeOfDisability
 

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid TypeOfDisabilityGuid { get; set; }

        [Required]
        public string View { get; set; }

        [Required]
        public string DisabilityGroup { get; set; }
		
		[Required]
        public string TypeOfViolation { get; set; }


        public TypeOfDisability()
        {
            TypeOfDisabilityGuid = Guid.NewGuid();
        }
    }
}

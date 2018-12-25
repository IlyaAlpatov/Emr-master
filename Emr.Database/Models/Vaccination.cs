using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Прививка
    /// </summary>
    public class Vaccination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid VaccinationGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameVaccination { get; set; }

        [Required]
        public string Description { get; set; }


        public Vaccination()
        {
            VaccinationGuid = Guid.NewGuid();
        }
    }
}

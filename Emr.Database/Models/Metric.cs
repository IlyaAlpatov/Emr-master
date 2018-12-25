using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Метрики пациента
    /// </summary>
    public class Metric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid MetricGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }
		
		[Required]
        public DateTime MetricDate { get; set; }

        public int WaistCircumference { get; set; }

        public int BodyTemperature { get; set; }

        public int RespiratoryRate { get; set; }

        public int Growth { get; set; }

        public int Mass { get; set; }

        public int SystolicPressure { get; set; }

        public int DiastolicPressure { get; set; }

        public int Pulse { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
		
		public Metric()
		
        {
            MetricGuid = Guid.NewGuid();
        }
    }
}

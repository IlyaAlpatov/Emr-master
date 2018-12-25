using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Препораты для карты
    /// </summary>
    public class MedicalDrags
    {
        [ForeignKey(nameof(Drag))]
        public Guid DragGuid { get; set; }

        [ForeignKey(nameof(PatientRecord))]
        public Guid PatientRecordGuid { get; set; }

        public virtual Drag Drag { get; set; }
        public virtual PatientRecord PatientRecord { get; set; }

        public MedicalDrags()
        {
            
        }
    }
}

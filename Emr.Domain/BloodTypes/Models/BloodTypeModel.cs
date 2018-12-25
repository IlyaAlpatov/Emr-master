using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.BloodTypes.Models
{
    public class BloodTypeModel
    {
        public Guid BloodTypeGuid { get; set; }

        public int BloodTypeNumber { get; set; }

        public string RedCellType { get; set; }


        public BloodTypeModel()
        {
        }
    }
}

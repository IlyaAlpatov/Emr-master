﻿using System;
using System.Collections.Generic;
using System.Text;
using Emr.Domain.Common;

namespace Emr.Domain.Medics.Models
{
    public class MedicInfo
    {
        
        public ClientInfo Client { get; set; }
        
        public Guid AdminGuid { get; set; }
        
        public string Specialty { get; set; }
        
        public string Position { get; set; }
        
        public string Subdivision { get; set; }

        public string Qualification { get; set; }
        
        public string EducationalInstitution { get; set; }

        public MedicInfo()
        {
            
        }
    }
}

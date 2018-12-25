using System;
using Emr.Domain.Common;

namespace Emr.Domain.Researchs.Models
{
    public class ResearchModel
    {
        public Guid ResearchGuid { get; set; }

        public string NameResearch { get; set; }

        public string Description { get; set; }

        public ResearchModel()
        {
            
        }
    }
}

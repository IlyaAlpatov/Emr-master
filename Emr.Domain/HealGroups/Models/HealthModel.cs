using System;

namespace Emr.Domain.HealGroups.Models
{
    //Копипастим все поля из Drug и так же добавляет в Mapper
    public class HealthModel
    {
        public Guid HealthGroupGuid { get; set; }

        public string NameHealthGroup { get; set; }

        public string Description { get; set; }

        public HealthModel()
        {
            
        }
    }
}

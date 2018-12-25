using System;

namespace Emr.Domain.TypeOfDisability.Models
{
    //Копипастим все поля из Drug и так же добавляет в Mapper
    public class TypeDisabilityModel
    {
        public Guid TypeOfDisabilityGuid { get; set; }

        public string View { get; set; }

        public string DisabilityGroup { get; set; }

        public string TypeOfViolation { get; set; }

        public TypeDisabilityModel()
        {
            
        }
    }
}

namespace Emr.Domain.TypeOfDisability.Models
{
    //Надо добавить в MapperProfile
    public class TypeDisabilityInfo
    {
        public string View { get; set; }

        public string DisabilityGroup { get; set; }

        public string TypeOfViolation { get; set; }

        /// <summary>
        /// Обязатель пустой конструктор
        /// </summary>
        public TypeDisabilityInfo()
        {
            
        }
    }
}

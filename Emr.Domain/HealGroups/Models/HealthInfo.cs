namespace Emr.Domain.HealGroups.Models
{
    //Надо добавить в MapperProfile
    public class HealthInfo
    {
        //Поля должны совпадать с полями из бд
        public string NameHealthGroup { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Обязатель пустой конструктор
        /// </summary>
        public HealthInfo()
        {
            
        }
    }
}

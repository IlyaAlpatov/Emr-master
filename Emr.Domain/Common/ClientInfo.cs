using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.Common
{
    public class ClientInfo
    {
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string Patronymic { get; set; }
        
        public int Snils { get; set; }

        public string Password { get; set; }

        //Дата рождения
        public DateTime Dob { get; set; }

        //Место рождения
        public string Pob { get; set; }
        
        public string Age { get; set; }
        
        public string Gender { get; set; }
        
        public string Passport { get; set; }
        
        public string Address { get; set; }
        
        public int Number { get; set; }

        public string Mail { get; set; }

        public ClientInfo()
        {
            
        }
    }
}

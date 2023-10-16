using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonUygulaması
{
    public class Kisi
    {
        //Encapsulation
        private string name, surName, phoneNumber;
        
        //Constructor
        public Kisi(string name, string surName, string phoneNumber)
        {
            this.name = name;
            this.surName = surName;
            this.phoneNumber = phoneNumber;
        }
        //props
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }


    }
}

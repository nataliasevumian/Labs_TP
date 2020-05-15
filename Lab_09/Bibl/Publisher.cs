﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Publisher
    {
        struct LicenseNumber
        {
            public int licenseNumber;  // номер лицензии            
            public DateTime data;      // дата выдачи 
            public override string ToString() 
            { 
                string s = String.Format("Лицензия N-{0} от {1} г.", licenseNumber, data.Year); 
                return s; 
            }
        }

        public string Name { get; set; }
        public string EmailAdress { get; set; }
        
        private LicenseNumber LinNumber;

        public Publisher(string name, string emailAdress, int lnumber, DateTime data) 
        { 
            Name = name; 
            EmailAdress = emailAdress; 
            LinNumber.licenseNumber = lnumber; 
            LinNumber.data = data; 
        }  
        public override string ToString() 
        { 
            string s = String.Format(": {0}, электронный адрес: {1}, {2}", Name, EmailAdress, LinNumber); 
            return s; 
        }
    }
}

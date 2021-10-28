using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectAttendence.DAL
{
    public class Admin
    {
        
        private string mail;

        public Admin()
        {
        }

        public Admin( string mail)
        {
            
            this.mail = mail;
        }

        
        public string Mail { get => mail; set => mail = value; }
    }
}

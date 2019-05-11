using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Entities
{
    public class Email
    {
        private string mail;

        public Email(String mail)
        {
            this.mail = mail;
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }
    }
}

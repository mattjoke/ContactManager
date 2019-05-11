using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Entities
{
    public class PhoneNumber
    {
        private string number;

        public PhoneNumber(String number)
        {
            this.number = number;
        }

        public string PhoneNum {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Entities
{
    public class Contact
    {
        private int id; //Id in table
        private string FirstName;
        private string LastName;

        private List<Email> mails = new List<Email>();
        private string Email = ";";
        private List<PhoneNumber> numbers = new List<PhoneNumber>();
        private string PhoneNumber = ";";

        public string MailStr { get { return Email; } set { Email = value; } }
        public string PhoneStr { get { return PhoneNumber; } set { PhoneNumber = value; } }

        public Contact()
        {
        }

        public Contact(string FName, string LName)
        {
            this.FirstName = FName;
            this.LastName = LName;
        }

        public List<Email> GetMails { get { return this.mails; } set { this.mails = value; generateMailStr(); } }
        public List<PhoneNumber> GetNums { get { return this.numbers; } set { this.numbers = value; generatePhoneStr(); } }

        public Email AddEmail{ set { GetMails.Add(value); generateMailStr(); } }
        public PhoneNumber AddPhonrNum { set { GetNums.Add(value); generatePhoneStr(); } }
        
        //Returns strings for drawing
        public string FullName { get { return $"{ FirstName } { LastName }"; } }
        public string FName{ get { return this.FirstName; } set { this.FirstName = value; } }
        public string LName{ get { return this.LastName; } set { this.LastName = value; } }
        public int ID { get { return id; } set { this.id = value; } }

        //Redrawing mail strings
        public void generateMailStr() {
            string mailout = "";
            foreach (Email e in GetMails)
            {
                if(e.Mail != "")
                {
                    mailout += e.Mail.Trim() + ";";
                }
            }
            MailStr = mailout;
        }
        public void generatePhoneStr()
        {
            string phoneout = "";
            foreach (PhoneNumber p in GetNums)
            {
                if(p.PhoneNum != "")
                {
                    phoneout += p.PhoneNum.Trim() + ";";
                }
            }
            PhoneStr = phoneout;
        }
    }
}

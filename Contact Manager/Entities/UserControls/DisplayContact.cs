using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Entities;

namespace Contact_Manager
{
    public partial class DisplayContact : UserControl
    {
        public DisplayContact()
        {
            InitializeComponent();
        }

        public void LoadContact(Contact c)
        {
            //Draws First and Last name
            MenoLabel.Text = c.FName;
            PriezviskoLabel.Text = c.LName;

            //Draws all Emails
            emails.Text = "";
            c.MailStr = c.MailStr.Replace(";", Environment.NewLine);
            emails.Text = c.MailStr;

            //Draws all Phone numbers
            phonenums.Text = "";
            c.PhoneStr = c.PhoneStr.Replace(";", Environment.NewLine);
            phonenums.Text = c.PhoneStr;
        }
    }
}

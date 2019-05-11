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
using static Contact_Manager.Form1;

namespace Contact_Manager
{
    public delegate void ClickMe (string message);
    public partial class AddContact : UserControl
    {
        public event ClickMe CustomControlClickMe;
        public AddContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MenoTxtBox.Text != "" && PriezviskoTextBox.Text != "" && TelTextBox.Text != "" && MailTextBox.Text != "")
            {
                //Saving data to database
                Contact con = new Contact(MenoTxtBox.Text, PriezviskoTextBox.Text);
                con.AddEmail = new Email(MailTextBox.Text);
                con.AddPhonrNum = new PhoneNumber(TelTextBox.Text);
                DataAcess.Save(con);
                //Clears textboxes
                MenoTxtBox.Text = "";
                PriezviskoTextBox.Text = "";
                MailTextBox.Text = "";
                TelTextBox.Text = "";
                //Event handeler
                if (CustomControlClickMe != null)
                    CustomControlClickMe("Reload");
            }
            else
            {
                //Displays Error
                MessageBox.Show("Chyba! Všetky polia musia byť zaplnené.");
            }
        }
    }
}

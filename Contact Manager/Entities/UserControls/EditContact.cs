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
using MaterialSkin.Controls;

namespace Contact_Manager
{
    public delegate void ClickEdit(string msg);
    public partial class EditContact : UserControl
    {
        //Event handeler
        public event ClickEdit CustomControlClickEdit;
        //Class to be drawn
        private Contact con;
        //Stores and converts mails and phone numbers
        private string[] MailArray;
        private string[] NumberArray;
        List<MaterialSingleLineTextField> mailTextBox = new List<MaterialSingleLineTextField>();
        List<MaterialSingleLineTextField> numberTextBox = new List<MaterialSingleLineTextField>();

        public EditContact()
        {
            InitializeComponent();
        }

        public void LoadContact(Contact c)
        {
            //Sets reference for class
            this.con = c;

            //Clears mails and numbers array + splits strings to string arrays
            MailArray = null;
            MailArray = c.MailStr.Split(';');
            mailTextBox.Clear();

            NumberArray = null;
            NumberArray = c.PhoneStr.Split(';');
            numberTextBox.Clear();

            //Creates instances of textbox dynamically
            foreach (string MailItem in MailArray)
            {
                if(MailItem != "")
                {
                    var MailTxtBox = new MaterialSingleLineTextField();
                    MailTxtBox.Text = MailItem;
                    mailTextBox.Add(MailTxtBox);
                }
            }

            foreach(string PhoneItem in NumberArray)
            {
                if(PhoneItem != "")
                {
                    var PhoneTxtBox = new MaterialSingleLineTextField();
                    PhoneTxtBox.Text = PhoneItem;
                    numberTextBox.Add(PhoneTxtBox);
                }
            }
            //Drawing textboxes and sets text in them
            int Increment = 0;
            foreach (MaterialSingleLineTextField MailItem in mailTextBox)
            {
                //Clears data from array
                foreach (Control rm in Controls.Find("txtMail" + Increment, true))
                {
                    Controls.Remove(rm);
                }
                //Draws TextBox
                if(MailItem.Text != "")
                {
                    MaterialSingleLineTextField txtMail = new MaterialSingleLineTextField();
                    txtMail.Name = "txtMail" + Increment++;
                    txtMail.Text = MailItem.Text;
                    txtMail.Location = new System.Drawing.Point(45, 161 + (25 * Increment));
                    txtMail.Size = new System.Drawing.Size(200, 80);
                    this.Controls.Add(txtMail);
                }
            }

            //Draws blank field -> adds Mail
            MaterialSingleLineTextField txtBlankMail = new MaterialSingleLineTextField();
            txtBlankMail.Name = "txtMail" + Increment++;
            txtBlankMail.Location = new System.Drawing.Point(45, 161 + (25 * Increment));
            txtBlankMail.Size = new System.Drawing.Size(200, 80);
            this.Controls.Add(txtBlankMail);

            Increment = 0;
            foreach (MaterialSingleLineTextField NumberItem in numberTextBox)
            {
                foreach (Control rm in Controls.Find("txtPhone" + Increment, true))
                {
                    Controls.Remove(rm);
                }
                if (NumberItem.Text != "")
                {
                    MaterialSingleLineTextField txtNumber = new MaterialSingleLineTextField();
                    txtNumber.Name = "txtPhone" + Increment++;
                    txtNumber.Text = NumberItem.Text;
                    txtNumber.Location = new System.Drawing.Point(345, 161 + (25 * Increment));
                    txtNumber.Size = new System.Drawing.Size(200, 80);
                    this.Controls.Add(txtNumber);
                }
            }

            //Draws blank field -> adds Number
            MaterialSingleLineTextField txtBlankNumber = new MaterialSingleLineTextField();
            txtBlankNumber.Name = "txtPhone" + Increment++;
            txtBlankNumber.Location = new System.Drawing.Point(345, 161 + (25 * Increment));
            txtBlankNumber.Size = new System.Drawing.Size(200, 80);
            this.Controls.Add(txtBlankNumber);

            menoEdit.Text = c.FName;
            PriezviskoEdit.Text = c.LName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (menoEdit.Text != "" && PriezviskoEdit.Text != "")
            {
                con.FName = menoEdit.Text;
                con.LName = PriezviskoEdit.Text;

                //Converts from object to string and sends to database
                List<Email> mailout = new List<Email>();
                List<PhoneNumber> phoneout = new List<PhoneNumber>();
                foreach (Control c in Controls)
                {
                    if(c is MaterialSingleLineTextField)
                    {
                        if(c.Name != "menoEdit" && c.Name != "PriezviskoEdit")
                        {
                            if(c.Name.StartsWith("txtPhone"))
                            {
                                phoneout.Add(new PhoneNumber(c.Text));
                            }
                            else
                            {
                                mailout.Add(new Email(c.Text));
                            }
                        }
                    }
                }
                con.GetMails = mailout;
                con.GetNums = phoneout;
                con.generateMailStr();

                DataAcess.Update(this.con);
                if (CustomControlClickEdit != null)
                    CustomControlClickEdit("Close");
            }
            else
            {
                MessageBox.Show("Chyba! Niekde nastala chyba!");
            }
            
        }
        
    }
}

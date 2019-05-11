using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Contact_Manager
{
    public partial class Form1 : MaterialForm
    {
        //People array
        private List<Contact> people = new List<Contact>();
        //Edit boolean
        private bool Edit = false;

        public Form1()
        {
            InitializeComponent();

            //Theme skins
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            //Draws Blank
            blank1.BringToFront();
            //Loads People
            LoadPeople();
            //Hides all other UC
            blank1.Show();
            addContact1.Hide();
            editContact1.Hide();
            displayContact1.Hide();
        }

        //Event handeler
        void LoadPeople(string meno)
        {
            if(meno == "Close")
            {
                Edit = false;
            }
            LoadPeople();
        }
        
        //Gets data from database
        public void LoadPeople()
        {
            listBox1.BeginUpdate();
            var data = DataAcess.Load();
            if (!data.Equals(people))
            {
                people = data;
                DrawList();
            }
            
        }
        //Adds data to listbox
        private void DrawList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = people;
            listBox1.DisplayMember = "FullName";
            listBox1.EndUpdate();
        }
        //Launch AddContact UC
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            AddContact a = new AddContact();
            addContact1.CustomControlClickMe += new ClickMe(LoadPeople);

            addContact1.Show();
            blank1.Hide();    
            displayContact1.Hide();
        }

        //Edit Button UC
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addContact1.Hide();
            blank1.Hide();

            object selected = listBox1.SelectedItem;
            foreach (Contact c in people)
            {
                if (c.Equals(selected))
                {
                    if (Edit) //Determine if to draw eedit UC
                    {
                        displayContact1.Hide();
                        editContact1.LoadContact(c);
                        editContact1.CustomControlClickEdit += new ClickEdit(LoadPeople);
                        editContact1.Show();
                        editContact1.BringToFront();
                    }
                    else
                    {
                        editContact1.Hide();
                        displayContact1.LoadContact(c);
                        displayContact1.Show();
                        displayContact1.BringToFront();
                    }
                }
            }
        }
        //EditButton - trigger
        private void edit_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                Edit = false;
                LoadPeople();
            }
            else
            {
                Edit = true;
                LoadPeople();
            }
        }
    }
}

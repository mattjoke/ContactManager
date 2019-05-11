namespace Contact_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addContact1 = new Contact_Manager.AddContact();
            this.blank1 = new Contact_Manager.Blank();
            this.displayContact1 = new Contact_Manager.DisplayContact();
            this.editContact1 = new Contact_Manager.EditContact();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.edit);
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 622);
            this.panel2.TabIndex = 1;
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.Depth = 0;
            this.edit.Icon = null;
            this.edit.Location = new System.Drawing.Point(211, 73);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit.Name = "edit";
            this.edit.Primary = false;
            this.edit.Size = new System.Drawing.Size(65, 36);
            this.edit.TabIndex = 2;
            this.edit.Text = "Uprav";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(58, 73);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(145, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "+ Pridaj kontakt";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(12, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 462);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 64);
            this.panel3.TabIndex = 2;
            // 
            // addContact1
            // 
            this.addContact1.AutoSize = true;
            this.addContact1.Location = new System.Drawing.Point(343, 118);
            this.addContact1.Name = "addContact1";
            this.addContact1.Size = new System.Drawing.Size(744, 437);
            this.addContact1.TabIndex = 5;
            // 
            // blank1
            // 
            this.blank1.Location = new System.Drawing.Point(382, 135);
            this.blank1.Name = "blank1";
            this.blank1.Size = new System.Drawing.Size(620, 405);
            this.blank1.TabIndex = 4;
            // 
            // displayContact1
            // 
            this.displayContact1.Location = new System.Drawing.Point(354, 73);
            this.displayContact1.Name = "displayContact1";
            this.displayContact1.Size = new System.Drawing.Size(702, 522);
            this.displayContact1.TabIndex = 3;
            // 
            // editContact1
            // 
            this.editContact1.Location = new System.Drawing.Point(354, 73);
            this.editContact1.Name = "editContact1";
            this.editContact1.Size = new System.Drawing.Size(702, 522);
            this.editContact1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1099, 622);
            this.Controls.Add(this.editContact1);
            this.Controls.Add(this.addContact1);
            this.Controls.Add(this.blank1);
            this.Controls.Add(this.displayContact1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Manažér kontaktov";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private DisplayContact displayContact1;
        private Blank blank1;
        private AddContact addContact1;
        private MaterialSkin.Controls.MaterialFlatButton edit;
        private EditContact editContact1;
    }
}


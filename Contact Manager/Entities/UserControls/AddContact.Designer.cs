namespace Contact_Manager
{
    partial class AddContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MenoLabel = new System.Windows.Forms.Label();
            this.PriezviskoLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.MenoTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PriezviskoTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TelTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MailTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pridať kontakt";
            // 
            // MenoLabel
            // 
            this.MenoLabel.AutoSize = true;
            this.MenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenoLabel.Location = new System.Drawing.Point(210, 87);
            this.MenoLabel.Name = "MenoLabel";
            this.MenoLabel.Size = new System.Drawing.Size(74, 29);
            this.MenoLabel.TabIndex = 2;
            this.MenoLabel.Text = "Meno";
            // 
            // PriezviskoLabel
            // 
            this.PriezviskoLabel.AutoSize = true;
            this.PriezviskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriezviskoLabel.Location = new System.Drawing.Point(169, 132);
            this.PriezviskoLabel.Name = "PriezviskoLabel";
            this.PriezviskoLabel.Size = new System.Drawing.Size(123, 29);
            this.PriezviskoLabel.TabIndex = 4;
            this.PriezviskoLabel.Text = "Priezvisko";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelLabel.Location = new System.Drawing.Point(113, 179);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(179, 29);
            this.TelLabel.TabIndex = 7;
            this.TelLabel.Text = "Telefónne číslo";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLabel.Location = new System.Drawing.Point(210, 229);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(82, 29);
            this.MailLabel.TabIndex = 9;
            this.MailLabel.Text = "E-mail";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveBtn.Depth = 0;
            this.SaveBtn.Icon = null;
            this.SaveBtn.Location = new System.Drawing.Point(351, 280);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Primary = false;
            this.SaveBtn.Size = new System.Drawing.Size(67, 36);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Uložiť";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenoTxtBox
            // 
            this.MenoTxtBox.Depth = 0;
            this.MenoTxtBox.Hint = "";
            this.MenoTxtBox.Location = new System.Drawing.Point(298, 93);
            this.MenoTxtBox.MaxLength = 32767;
            this.MenoTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenoTxtBox.Name = "MenoTxtBox";
            this.MenoTxtBox.PasswordChar = '\0';
            this.MenoTxtBox.SelectedText = "";
            this.MenoTxtBox.SelectionLength = 0;
            this.MenoTxtBox.SelectionStart = 0;
            this.MenoTxtBox.Size = new System.Drawing.Size(191, 23);
            this.MenoTxtBox.TabIndex = 11;
            this.MenoTxtBox.TabStop = false;
            this.MenoTxtBox.UseSystemPasswordChar = false;
            // 
            // PriezviskoTextBox
            // 
            this.PriezviskoTextBox.Depth = 0;
            this.PriezviskoTextBox.Hint = "";
            this.PriezviskoTextBox.Location = new System.Drawing.Point(298, 138);
            this.PriezviskoTextBox.MaxLength = 32767;
            this.PriezviskoTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriezviskoTextBox.Name = "PriezviskoTextBox";
            this.PriezviskoTextBox.PasswordChar = '\0';
            this.PriezviskoTextBox.SelectedText = "";
            this.PriezviskoTextBox.SelectionLength = 0;
            this.PriezviskoTextBox.SelectionStart = 0;
            this.PriezviskoTextBox.Size = new System.Drawing.Size(191, 23);
            this.PriezviskoTextBox.TabIndex = 12;
            this.PriezviskoTextBox.TabStop = false;
            this.PriezviskoTextBox.UseSystemPasswordChar = false;
            // 
            // TelTextBox
            // 
            this.TelTextBox.Depth = 0;
            this.TelTextBox.Hint = "";
            this.TelTextBox.Location = new System.Drawing.Point(298, 185);
            this.TelTextBox.MaxLength = 32767;
            this.TelTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.PasswordChar = '\0';
            this.TelTextBox.SelectedText = "";
            this.TelTextBox.SelectionLength = 0;
            this.TelTextBox.SelectionStart = 0;
            this.TelTextBox.Size = new System.Drawing.Size(191, 23);
            this.TelTextBox.TabIndex = 13;
            this.TelTextBox.TabStop = false;
            this.TelTextBox.UseSystemPasswordChar = false;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Depth = 0;
            this.MailTextBox.Hint = "";
            this.MailTextBox.Location = new System.Drawing.Point(298, 229);
            this.MailTextBox.MaxLength = 32767;
            this.MailTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.PasswordChar = '\0';
            this.MailTextBox.SelectedText = "";
            this.MailTextBox.SelectionLength = 0;
            this.MailTextBox.SelectionStart = 0;
            this.MailTextBox.Size = new System.Drawing.Size(191, 23);
            this.MailTextBox.TabIndex = 14;
            this.MailTextBox.TabStop = false;
            this.MailTextBox.UseSystemPasswordChar = false;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.TelTextBox);
            this.Controls.Add(this.PriezviskoTextBox);
            this.Controls.Add(this.MenoTxtBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.PriezviskoLabel);
            this.Controls.Add(this.MenoLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddContact";
            this.Size = new System.Drawing.Size(717, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MenoLabel;
        private System.Windows.Forms.Label PriezviskoLabel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label MailLabel;
        private MaterialSkin.Controls.MaterialFlatButton SaveBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField MenoTxtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PriezviskoTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField TelTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField MailTextBox;
    }
}

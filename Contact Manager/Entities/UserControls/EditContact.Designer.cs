namespace Contact_Manager
{
    partial class EditContact
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
            this.label2 = new System.Windows.Forms.Label();
            this.menoEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PriezviskoEdit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priezvisko:";
            // 
            // menoEdit
            // 
            this.menoEdit.Depth = 0;
            this.menoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menoEdit.Hint = "";
            this.menoEdit.Location = new System.Drawing.Point(134, 40);
            this.menoEdit.MaxLength = 32767;
            this.menoEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.menoEdit.Name = "menoEdit";
            this.menoEdit.PasswordChar = '\0';
            this.menoEdit.SelectedText = "";
            this.menoEdit.SelectionLength = 0;
            this.menoEdit.SelectionStart = 0;
            this.menoEdit.Size = new System.Drawing.Size(119, 23);
            this.menoEdit.TabIndex = 4;
            this.menoEdit.TabStop = false;
            this.menoEdit.Text = "materialSingleLineTextField1";
            this.menoEdit.UseSystemPasswordChar = false;
            // 
            // PriezviskoEdit
            // 
            this.PriezviskoEdit.Depth = 0;
            this.PriezviskoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriezviskoEdit.Hint = "";
            this.PriezviskoEdit.Location = new System.Drawing.Point(192, 71);
            this.PriezviskoEdit.MaxLength = 32767;
            this.PriezviskoEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriezviskoEdit.Name = "PriezviskoEdit";
            this.PriezviskoEdit.PasswordChar = '\0';
            this.PriezviskoEdit.SelectedText = "";
            this.PriezviskoEdit.SelectionLength = 0;
            this.PriezviskoEdit.SelectionStart = 0;
            this.PriezviskoEdit.Size = new System.Drawing.Size(119, 23);
            this.PriezviskoEdit.TabIndex = 5;
            this.PriezviskoEdit.TabStop = false;
            this.PriezviskoEdit.Text = "materialSingleLineTextField2";
            this.PriezviskoEdit.UseSystemPasswordChar = false;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.Depth = 0;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(537, 40);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(67, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Uložiť";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefónne čísla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-maily";
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.PriezviskoEdit);
            this.Controls.Add(this.menoEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditContact";
            this.Size = new System.Drawing.Size(702, 522);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField menoEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField PriezviskoEdit;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

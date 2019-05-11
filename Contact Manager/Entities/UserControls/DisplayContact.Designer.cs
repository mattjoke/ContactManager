namespace Contact_Manager
{
    partial class DisplayContact
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
            this.MenoLabel = new System.Windows.Forms.Label();
            this.PriezviskoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emails = new System.Windows.Forms.Label();
            this.phonenums = new System.Windows.Forms.Label();
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
            // MenoLabel
            // 
            this.MenoLabel.AutoSize = true;
            this.MenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenoLabel.Location = new System.Drawing.Point(134, 32);
            this.MenoLabel.Name = "MenoLabel";
            this.MenoLabel.Size = new System.Drawing.Size(81, 31);
            this.MenoLabel.TabIndex = 2;
            this.MenoLabel.Text = "meno";
            // 
            // PriezviskoLabel
            // 
            this.PriezviskoLabel.AutoSize = true;
            this.PriezviskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriezviskoLabel.Location = new System.Drawing.Point(192, 63);
            this.PriezviskoLabel.Name = "PriezviskoLabel";
            this.PriezviskoLabel.Size = new System.Drawing.Size(124, 31);
            this.PriezviskoLabel.TabIndex = 3;
            this.PriezviskoLabel.Text = "lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-maily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefónne čísla";
            // 
            // emails
            // 
            this.emails.AutoSize = true;
            this.emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emails.Location = new System.Drawing.Point(40, 168);
            this.emails.Name = "emails";
            this.emails.Size = new System.Drawing.Size(51, 20);
            this.emails.TabIndex = 6;
            this.emails.Text = "label5";
            // 
            // phonenums
            // 
            this.phonenums.AutoSize = true;
            this.phonenums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenums.Location = new System.Drawing.Point(355, 168);
            this.phonenums.Name = "phonenums";
            this.phonenums.Size = new System.Drawing.Size(51, 20);
            this.phonenums.TabIndex = 7;
            this.phonenums.Text = "label6";
            // 
            // DisplayContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phonenums);
            this.Controls.Add(this.emails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriezviskoLabel);
            this.Controls.Add(this.MenoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayContact";
            this.Size = new System.Drawing.Size(702, 522);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MenoLabel;
        private System.Windows.Forms.Label PriezviskoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emails;
        private System.Windows.Forms.Label phonenums;
    }
}

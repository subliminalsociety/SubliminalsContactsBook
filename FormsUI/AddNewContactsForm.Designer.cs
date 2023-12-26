using System.ComponentModel;

namespace FormsUI
{
    partial class AddNewContactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.name_Textbox = new System.Windows.Forms.TextBox();
            this.phone_Textbox = new System.Windows.Forms.TextBox();
            this.address_Textbox = new System.Windows.Forms.TextBox();
            this.email_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notes_Textbox = new System.Windows.Forms.TextBox();
            this.birthday_Textbox = new System.Windows.Forms.TextBox();
            this.company_Textbox = new System.Windows.Forms.TextBox();
            this.jobTitle_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.restart_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_Textbox
            // 
            this.name_Textbox.AcceptsReturn = true;
            this.name_Textbox.AcceptsTab = true;
            this.name_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.name_Textbox.Location = new System.Drawing.Point(76, 47);
            this.name_Textbox.Name = "name_Textbox";
            this.name_Textbox.Size = new System.Drawing.Size(279, 20);
            this.name_Textbox.TabIndex = 0;
            this.name_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // phone_Textbox
            // 
            this.phone_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.phone_Textbox.Location = new System.Drawing.Point(76, 73);
            this.phone_Textbox.Name = "phone_Textbox";
            this.phone_Textbox.Size = new System.Drawing.Size(279, 20);
            this.phone_Textbox.TabIndex = 1;
            this.phone_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // address_Textbox
            // 
            this.address_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.address_Textbox.Location = new System.Drawing.Point(76, 125);
            this.address_Textbox.Multiline = true;
            this.address_Textbox.Name = "address_Textbox";
            this.address_Textbox.Size = new System.Drawing.Size(279, 46);
            this.address_Textbox.TabIndex = 3;
            this.address_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // email_Textbox
            // 
            this.email_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.email_Textbox.Location = new System.Drawing.Point(76, 99);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Size = new System.Drawing.Size(279, 20);
            this.email_Textbox.TabIndex = 2;
            this.email_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone #:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notes_Textbox
            // 
            this.notes_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.notes_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_Textbox.Location = new System.Drawing.Point(76, 255);
            this.notes_Textbox.Multiline = true;
            this.notes_Textbox.Name = "notes_Textbox";
            this.notes_Textbox.Size = new System.Drawing.Size(279, 154);
            this.notes_Textbox.TabIndex = 12;
            this.notes_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // birthday_Textbox
            // 
            this.birthday_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.birthday_Textbox.Location = new System.Drawing.Point(76, 229);
            this.birthday_Textbox.Name = "birthday_Textbox";
            this.birthday_Textbox.Size = new System.Drawing.Size(279, 20);
            this.birthday_Textbox.TabIndex = 11;
            this.birthday_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // company_Textbox
            // 
            this.company_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.company_Textbox.Location = new System.Drawing.Point(76, 203);
            this.company_Textbox.Name = "company_Textbox";
            this.company_Textbox.Size = new System.Drawing.Size(279, 20);
            this.company_Textbox.TabIndex = 10;
            this.company_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // jobTitle_Textbox
            // 
            this.jobTitle_Textbox.BackColor = System.Drawing.Color.OldLace;
            this.jobTitle_Textbox.Location = new System.Drawing.Point(76, 177);
            this.jobTitle_Textbox.Name = "jobTitle_Textbox";
            this.jobTitle_Textbox.Size = new System.Drawing.Size(279, 20);
            this.jobTitle_Textbox.TabIndex = 9;
            this.jobTitle_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Notes:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Birthday:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Company:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Caladea", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "New Contact Form:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submit_Button
            // 
            this.submit_Button.BackColor = System.Drawing.Color.YellowGreen;
            this.submit_Button.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_Button.Location = new System.Drawing.Point(12, 415);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(190, 40);
            this.submit_Button.TabIndex = 19;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = false;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // restart_Button
            // 
            this.restart_Button.BackColor = System.Drawing.Color.Peru;
            this.restart_Button.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_Button.Location = new System.Drawing.Point(208, 415);
            this.restart_Button.Name = "restart_Button";
            this.restart_Button.Size = new System.Drawing.Size(147, 40);
            this.restart_Button.TabIndex = 21;
            this.restart_Button.Text = "Restart";
            this.restart_Button.UseVisualStyleBackColor = false;
            this.restart_Button.Click += new System.EventHandler(this.restart_Button_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.OldLace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Job Title:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(367, 463);
            this.Controls.Add(this.restart_Button);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.notes_Textbox);
            this.Controls.Add(this.birthday_Textbox);
            this.Controls.Add(this.company_Textbox);
            this.Controls.Add(this.jobTitle_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_Textbox);
            this.Controls.Add(this.email_Textbox);
            this.Controls.Add(this.phone_Textbox);
            this.Controls.Add(this.name_Textbox);
            this.Name = "AddNewContactsForm";
            this.Text = "AddContactForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewContactsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button restart_Button;

        private System.Windows.Forms.Button submit_Button;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox notes_Textbox;
        private System.Windows.Forms.TextBox birthday_Textbox;
        private System.Windows.Forms.TextBox company_Textbox;
        private System.Windows.Forms.TextBox jobTitle_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox name_Textbox;
        private System.Windows.Forms.TextBox phone_Textbox;
        private System.Windows.Forms.TextBox address_Textbox;
        private System.Windows.Forms.TextBox email_Textbox;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}
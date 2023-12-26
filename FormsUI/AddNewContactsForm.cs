using System;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class AddNewContactsForm : Form
    {
        public Contact ContactData;

        public AddNewContactsForm()
        {
            InitializeComponent();
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            var newContact = new Contact(
                name_Textbox.Text,
                phone_Textbox.Text,
                email_Textbox.Text,
                address_Textbox.Text,
                jobTitle_Textbox.Text,
                company_Textbox.Text,
                birthday_Textbox.Text,
                notes_Textbox.Text);

            ContactData = newContact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void restart_Button_Click(object sender, EventArgs e)
        {
            name_Textbox.Text = string.Empty;
            phone_Textbox.Text = string.Empty;
            email_Textbox.Text = string.Empty;
            address_Textbox.Text = string.Empty;
            address_Textbox.Text = string.Empty;
            jobTitle_Textbox.Text = string.Empty;
            company_Textbox.Text = string.Empty;
            birthday_Textbox.Text = string.Empty;
            notes_Textbox.Text = string.Empty;
        }

        private void AddNewContactsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using TextFieldParserStandard;

namespace FormsUI
{
    public partial class ContactListForm : Form
    {
        private readonly BindingSource _contactListBindingSource = new BindingSource();

        private void UpdateConfiguration()
        {
            contactList_DataGridView.Anchor =
                AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            // Set column properties for each column
            foreach (DataGridViewColumn column in contactList_DataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; // You can adjust this value based on your preferences
            }
        }

        private void ExportDataGridViewToCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.CurrentUICulture)))
                {
                    // Write header row
                    for (var i = 0; i < dataGridView.ColumnCount; i++)
                        csv.WriteField(dataGridView.Columns[i].HeaderText);
                    csv.NextRecord();

                    // Write all rows, not just visible ones
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (var i = 0; i < dataGridView.ColumnCount; i++) csv.WriteField(row.Cells[i].Value);
                        csv.NextRecord();
                    }
                }

                MessageBox.Show(@"DataGridView contents exported to CSV successfully.", @"Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message}", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ImportCsvToDataGridView(string filePath)
        {
            try
            {
                // Clear existing data in the DataGridView
                contactList_DataGridView.DataSource = null;

                // Create DataTable to store CSV data
                var csvDataTable = new DataTable();

                using (var parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Read header row
                    var headers = parser.ReadFields();
                    foreach (var header in headers)
                        // Add columns to DataTable based on header row
                        csvDataTable.Columns.Add(header);

                    // Read data rows
                    while (!parser.EndOfData)
                    {
                        var fields = parser.ReadFields();


                        // ReSharper disable once CoVariantArrayConversion
                        csvDataTable.Rows.Add(fields);
                    }
                }

                // Bind DataTable to DataGridView
                contactList_DataGridView.DataSource = csvDataTable;

                MessageBox.Show(@"CSV file imported into DataGridView successfully.", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message}", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /*private void ImportCsvToDataGridView(string filePath)
        {
            try
            {
                // Clear existing data in the DataGridView
                contactList_DataGridView.DataSource = null;

                // Create DataTable to store CSV data
                DataTable csvDataTable = new DataTable();

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
                {
                    // Read all rows as data
                    IEnumerable<dynamic> records = csv.GetRecords<dynamic>();

                    // If using the first record to determine columns
                    if (records.Any())
                    {
                        foreach (var header in ((IDictionary<string, object>)records.First()).Keys)
                        {
                            // Add columns to DataTable based on header row
                            csvDataTable.Columns.Add(header);
                        }
                    }

                    // Populate DataTable with data
                    foreach (var record in records)
                    {
                        DataRow dataRow = csvDataTable.NewRow();
                        foreach (DataColumn column in csvDataTable.Columns)
                        {
                            dataRow[column.ColumnName] = ((IDictionary<string, object>)record)[column.ColumnName];
                        }
                        csvDataTable.Rows.Add(dataRow);
                    }
                }

                // Bind DataTable to DataGridView
                contactList_DataGridView.DataSource = csvDataTable;

                MessageBox.Show("CSV file imported into DataGridView successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        private void about_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Subliminal's Contact Card Planner V0.01" + Environment.NewLine +
                @"Created on 12/25/2023 in one Adderall Infused Night." + Environment.NewLine + Environment.NewLine +
                @"Hope you enjoy this big milestone for me!");
        }


        #region Initialization & Constructors

        public ContactListForm()
        {
            InitializeComponent();
            InitializeDataView(false);
        }

        private void InitializeDataView(bool rand)
        {
            ContactsDatabase.Instance.GenerateContacts();
            if (rand == false)
            {
                contactList_DataGridView.DataSource = _contactListBindingSource;
                contactList_DataGridView.AutoGenerateColumns = true;
                contactList_DataGridView.AllowUserToAddRows = false;

                foreach (var contact in ContactsDatabase.Instance.ContactList) _contactListBindingSource.Add(contact);
            }
            else
            {
                contactList_DataGridView.DataSource = _contactListBindingSource;
                contactList_DataGridView.AutoGenerateColumns = true;
                contactList_DataGridView.AllowUserToAddRows = false;
                foreach (var contact in ContactsDatabase.Instance.RandomContactList)
                    _contactListBindingSource.Add(contact);
            }
        }

        #endregion


        #region UI Events

        private void newProject_Button_Click(object sender, EventArgs e)
        {
            var proceedWithReset = MessageBox.Show(
                @"This cannot be undone. Are you sure you want to start a new project?",
                @"Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (proceedWithReset != DialogResult.Yes) return;
            _contactListBindingSource.Clear();
            InitializeDataView(false);
        }

        private void newRandomProject_Button_Click(object sender, EventArgs e)
        {
            var proceedWithReset = MessageBox.Show(
                @"This cannot be undone. Are you sure you want to start a new project?",
                @"Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (proceedWithReset != DialogResult.Yes) return;
            _contactListBindingSource.Clear();
            InitializeDataView(true);
        }

        private void newBlankProject_Button_Click(object sender, EventArgs e)
        {
            var proceedWithReset = MessageBox.Show(
                @"This cannot be undone. Are you sure you want to start a new empty project?",
                @"Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (proceedWithReset != DialogResult.Yes) return;
            _contactListBindingSource.Clear();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = @"Export DataGridView to CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                ExportDataGridViewToCsv(contactList_DataGridView, filePath);
            }
        }

        private void load_Button_Click(object sender, EventArgs e)
        {
            /*_contactListBindingSource.Clear();*/
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = @"Import CSV into DataGridView";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                ImportCsvToDataGridView(filePath);
            }
        }

        private void newContact_Button_Click(object sender, EventArgs e)
        {
            using (var contactFormInstance = new AddNewContactsForm())
            {
                if (contactFormInstance.ShowDialog() == DialogResult.OK)
                {
                    var newContact = contactFormInstance.ContactData;
                    MessageBox.Show(newContact.ToString());
                    _contactListBindingSource.Add(newContact);
                    _contactListBindingSource.ResetBindings(false);
                }
            }
        }

        private void deleteContact_Button_Click(object sender, EventArgs e)
        {
            if (contactList_DataGridView.SelectedCells.Count > 0)
            {
                var selectedIndex = contactList_DataGridView.SelectedCells[0].RowIndex;
                _contactListBindingSource.RemoveAt(selectedIndex);
            }

            if (contactList_DataGridView.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                var selectedIndex = contactList_DataGridView.SelectedRows[0].Index;

                // Remove the row from the BindingSource
                _contactListBindingSource.RemoveAt(selectedIndex);
            }
        }

        private void update_Timer_Tick(object sender, EventArgs e)
        {
            UpdateConfiguration();
        }

        private void ContactListForm_Load(object sender, EventArgs e)
        {
            update_Timer.Start();
        }

        private void ContactListForm_FormClose(object sender, FormClosedEventArgs e)
        {
            update_Timer.Stop();
        }

        #endregion

        private void numRandContacts_ComboBox_TextChanged(object sender, EventArgs e)
        {
            var selectedIndex = numRandContacts_ComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                string selectedString = numRandContacts_ComboBox.Items[selectedIndex].ToString();
                if (int.TryParse(selectedString, out int selectedInt))
                {
                    ContactsDatabase.RandomNumberOfContacts = selectedInt;
                }
            }
        }
    }
}
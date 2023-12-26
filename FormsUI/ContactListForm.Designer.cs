using System.Windows.Forms;

namespace FormsUI
{
    partial class ContactListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactListForm));
            this.contactList_DataGridView = new System.Windows.Forms.DataGridView();
            this.menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.file_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.newProject_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.newRandomProject_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlankProject_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.save_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.load_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contacts_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.newContact_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContact_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settings_DropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.about_Button = new System.Windows.Forms.ToolStripButton();
            this.numRandContacts_ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.update_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactList_DataGridView)).BeginInit();
            this.menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactList_DataGridView
            // 
            this.contactList_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.contactList_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contactList_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.contactList_DataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.contactList_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contactList_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contactList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactList_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.contactList_DataGridView.Location = new System.Drawing.Point(5, 43);
            this.contactList_DataGridView.Margin = new System.Windows.Forms.Padding(15);
            this.contactList_DataGridView.Name = "contactList_DataGridView";
            this.contactList_DataGridView.Size = new System.Drawing.Size(809, 585);
            this.contactList_DataGridView.TabIndex = 0;
            // 
            // menu_ToolStrip
            // 
            this.menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.file_DropDown, this.toolStripSeparator1, this.contacts_DropDown, this.toolStripSeparator2, this.settings_DropDown });
            this.menu_ToolStrip.Location = new System.Drawing.Point(5, 5);
            this.menu_ToolStrip.Name = "menu_ToolStrip";
            this.menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_ToolStrip.Size = new System.Drawing.Size(809, 30);
            this.menu_ToolStrip.TabIndex = 6;
            this.menu_ToolStrip.Text = "toolStrip1";
            // 
            // file_DropDown
            // 
            this.file_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newProject_Button, this.newRandomProject_Button, this.newBlankProject_Button, this.save_Button, this.load_Button });
            this.file_DropDown.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_DropDown.Name = "file_DropDown";
            this.file_DropDown.Size = new System.Drawing.Size(39, 27);
            this.file_DropDown.Text = "File";
            this.file_DropDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // newProject_Button
            // 
            this.newProject_Button.Name = "newProject_Button";
            this.newProject_Button.Size = new System.Drawing.Size(190, 22);
            this.newProject_Button.Text = "New Project";
            this.newProject_Button.Click += new System.EventHandler(this.newProject_Button_Click);
            // 
            // newRandomProject_Button
            // 
            this.newRandomProject_Button.Name = "newRandomProject_Button";
            this.newRandomProject_Button.Size = new System.Drawing.Size(190, 22);
            this.newRandomProject_Button.Text = "New Random Project";
            this.newRandomProject_Button.Click += new System.EventHandler(this.newRandomProject_Button_Click);
            // 
            // newBlankProject_Button
            // 
            this.newBlankProject_Button.Name = "newBlankProject_Button";
            this.newBlankProject_Button.Size = new System.Drawing.Size(190, 22);
            this.newBlankProject_Button.Text = "New Empty Project";
            this.newBlankProject_Button.Click += new System.EventHandler(this.newBlankProject_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(190, 22);
            this.save_Button.Text = "Save";
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // load_Button
            // 
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(190, 22);
            this.load_Button.Text = "Load";
            this.load_Button.Click += new System.EventHandler(this.load_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(15, 30);
            // 
            // contacts_DropDown
            // 
            this.contacts_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contacts_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newContact_Button, this.deleteContact_Button });
            this.contacts_DropDown.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contacts_DropDown.Name = "contacts_DropDown";
            this.contacts_DropDown.Size = new System.Drawing.Size(67, 27);
            this.contacts_DropDown.Text = "Contacts";
            this.contacts_DropDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // newContact_Button
            // 
            this.newContact_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newContact_Button.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newContact_Button.Image = ((System.Drawing.Image)(resources.GetObject("newContact_Button.Image")));
            this.newContact_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newContact_Button.Name = "newContact_Button";
            this.newContact_Button.Size = new System.Drawing.Size(145, 22);
            this.newContact_Button.Text = "Add Contact";
            // 
            // deleteContact_Button
            // 
            this.deleteContact_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteContact_Button.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContact_Button.Image = ((System.Drawing.Image)(resources.GetObject("deleteContact_Button.Image")));
            this.deleteContact_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteContact_Button.Name = "deleteContact_Button";
            this.deleteContact_Button.Size = new System.Drawing.Size(85, 18);
            this.deleteContact_Button.Text = "Delete Contact";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(15, 30);
            // 
            // settings_DropDown
            // 
            this.settings_DropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settings_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.about_Button, this.numRandContacts_ComboBox });
            this.settings_DropDown.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_DropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings_DropDown.Name = "settings_DropDown";
            this.settings_DropDown.Size = new System.Drawing.Size(63, 27);
            this.settings_DropDown.Text = "Settings";
            this.settings_DropDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // about_Button
            // 
            this.about_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.about_Button.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_Button.Image = ((System.Drawing.Image)(resources.GetObject("about_Button.Image")));
            this.about_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_Button.Name = "about_Button";
            this.about_Button.Size = new System.Drawing.Size(40, 18);
            this.about_Button.Text = "About";
            // 
            // numRandContacts_ComboBox
            // 
            this.numRandContacts_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRandContacts_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "75", "100", "125", "150", "175", "200" });
            this.numRandContacts_ComboBox.Name = "numRandContacts_ComboBox";
            this.numRandContacts_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.numRandContacts_ComboBox.Text = "# Rnd Contacts";
            this.numRandContacts_ComboBox.TextChanged += new System.EventHandler(this.numRandContacts_ComboBox_TextChanged);
            // 
            // update_Timer
            // 
            this.update_Timer.Interval = 200;
            this.update_Timer.Tick += new System.EventHandler(this.update_Timer_Tick);
            // 
            // ContactListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(819, 633);
            this.Controls.Add(this.menu_ToolStrip);
            this.Controls.Add(this.contactList_DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ContactListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactListForm_FormClose);
            this.Load += new System.EventHandler(this.ContactListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactList_DataGridView)).EndInit();
            this.menu_ToolStrip.ResumeLayout(false);
            this.menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripComboBox numRandContacts_ComboBox;

        private System.Windows.Forms.ToolStripDropDownButton contacts_DropDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton settings_DropDown;

        private System.Windows.Forms.ToolStripMenuItem newRandomProject_Button;

        private System.Windows.Forms.ToolStripMenuItem newBlankProject_Button;

        private System.Windows.Forms.ToolStripButton about_Button;

        private System.Windows.Forms.Timer update_Timer;

        private System.Windows.Forms.ToolStripMenuItem newProject_Button;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;


        private System.Windows.Forms.ToolStripDropDownButton file_DropDown;
        private System.Windows.Forms.ToolStrip menu_ToolStrip;

        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem save_Button;
        private System.Windows.Forms.ToolStripMenuItem load_Button;

        private System.Windows.Forms.ToolStripMenuItem newContact_Button;
        private System.Windows.Forms.ToolStripButton deleteContact_Button;
        private System.Windows.Forms.Button factoryReset_Button;

        private System.Windows.Forms.DataGridView contactList_DataGridView;

        #endregion
    }
}
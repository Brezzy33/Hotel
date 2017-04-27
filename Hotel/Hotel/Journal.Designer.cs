namespace Hotel
{
    partial class Journal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.mbtnDelete = new MetroFramework.Controls.MetroButton();
            this.mbtnSave = new MetroFramework.Controls.MetroButton();
            this.mbtnEdit = new MetroFramework.Controls.MetroButton();
            this.mbtnReturn = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronimicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.clientsTableAdapter = new Hotel.HotelDataSetTableAdapters.ClientsTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPatronimic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPassport = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTagging = new MetroFramework.Controls.MetroTextBox();
            this.tstSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Location = new System.Drawing.Point(14, 592);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(136, 35);
            this.mbtnAdd.TabIndex = 7;
            this.mbtnAdd.Text = "Add new";
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Location = new System.Drawing.Point(438, 592);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(135, 35);
            this.mbtnDelete.TabIndex = 10;
            this.mbtnDelete.Text = "Delete";
            this.mbtnDelete.UseSelectable = true;
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // mbtnSave
            // 
            this.mbtnSave.Location = new System.Drawing.Point(156, 592);
            this.mbtnSave.Name = "mbtnSave";
            this.mbtnSave.Size = new System.Drawing.Size(135, 35);
            this.mbtnSave.TabIndex = 8;
            this.mbtnSave.Text = "Save";
            this.mbtnSave.UseSelectable = true;
            this.mbtnSave.Click += new System.EventHandler(this.mbtnSave_Click);
            // 
            // mbtnEdit
            // 
            this.mbtnEdit.Location = new System.Drawing.Point(297, 592);
            this.mbtnEdit.Name = "mbtnEdit";
            this.mbtnEdit.Size = new System.Drawing.Size(135, 35);
            this.mbtnEdit.TabIndex = 9;
            this.mbtnEdit.Text = "Edit";
            this.mbtnEdit.UseSelectable = true;
            this.mbtnEdit.Click += new System.EventHandler(this.mbtnEdit_Click);
            // 
            // mbtnReturn
            // 
            this.mbtnReturn.Location = new System.Drawing.Point(592, 592);
            this.mbtnReturn.Name = "mbtnReturn";
            this.mbtnReturn.Size = new System.Drawing.Size(135, 35);
            this.mbtnReturn.TabIndex = 11;
            this.mbtnReturn.Text = "Return";
            this.mbtnReturn.UseSelectable = true;
            this.mbtnReturn.Click += new System.EventHandler(this.mbtnReturn_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronimicDataGridViewTextBoxColumn,
            this.dataPasportDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(14, 203);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(713, 383);
            this.metroGrid1.TabIndex = 36;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "ID Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronimicDataGridViewTextBoxColumn
            // 
            this.patronimicDataGridViewTextBoxColumn.DataPropertyName = "Patronimic";
            this.patronimicDataGridViewTextBoxColumn.HeaderText = "Patronimic";
            this.patronimicDataGridViewTextBoxColumn.Name = "patronimicDataGridViewTextBoxColumn";
            this.patronimicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPasportDataGridViewTextBoxColumn
            // 
            this.dataPasportDataGridViewTextBoxColumn.DataPropertyName = "DataPasport";
            this.dataPasportDataGridViewTextBoxColumn.HeaderText = "Pasport Information";
            this.dataPasportDataGridViewTextBoxColumn.Name = "dataPasportDataGridViewTextBoxColumn";
            this.dataPasportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Number client:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "idClient", true));
            this.txtID.Enabled = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(118, 58);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Client id. (auto)";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(192, 23);
            this.txtID.TabIndex = 0;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Client id. (auto)";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Name:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(118, 87);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter name.";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(192, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter name.";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Surname:";
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Surname", true));
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(118, 116);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PromptText = "Enter surname.";
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(192, 23);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMark = "Enter surname.";
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Patronimic:";
            // 
            // txtPatronimic
            // 
            // 
            // 
            // 
            this.txtPatronimic.CustomButton.Image = null;
            this.txtPatronimic.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtPatronimic.CustomButton.Name = "";
            this.txtPatronimic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatronimic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatronimic.CustomButton.TabIndex = 1;
            this.txtPatronimic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatronimic.CustomButton.UseSelectable = true;
            this.txtPatronimic.CustomButton.Visible = false;
            this.txtPatronimic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Patronimic", true));
            this.txtPatronimic.Lines = new string[0];
            this.txtPatronimic.Location = new System.Drawing.Point(118, 145);
            this.txtPatronimic.MaxLength = 32767;
            this.txtPatronimic.Name = "txtPatronimic";
            this.txtPatronimic.PasswordChar = '\0';
            this.txtPatronimic.PromptText = "Enter patronimic.";
            this.txtPatronimic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatronimic.SelectedText = "";
            this.txtPatronimic.SelectionLength = 0;
            this.txtPatronimic.SelectionStart = 0;
            this.txtPatronimic.ShortcutsEnabled = true;
            this.txtPatronimic.Size = new System.Drawing.Size(192, 23);
            this.txtPatronimic.TabIndex = 3;
            this.txtPatronimic.UseSelectable = true;
            this.txtPatronimic.WaterMark = "Enter patronimic.";
            this.txtPatronimic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatronimic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(320, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Passport data:";
            // 
            // txtPassport
            // 
            // 
            // 
            // 
            this.txtPassport.CustomButton.Image = null;
            this.txtPassport.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtPassport.CustomButton.Name = "";
            this.txtPassport.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtPassport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassport.CustomButton.TabIndex = 1;
            this.txtPassport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassport.CustomButton.UseSelectable = true;
            this.txtPassport.CustomButton.Visible = false;
            this.txtPassport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "DataPasport", true));
            this.txtPassport.Lines = new string[0];
            this.txtPassport.Location = new System.Drawing.Point(418, 56);
            this.txtPassport.MaxLength = 32767;
            this.txtPassport.Multiline = true;
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.PasswordChar = '\0';
            this.txtPassport.PromptText = "Enter client passport information.";
            this.txtPassport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassport.SelectedText = "";
            this.txtPassport.SelectionLength = 0;
            this.txtPassport.SelectionStart = 0;
            this.txtPassport.ShortcutsEnabled = true;
            this.txtPassport.Size = new System.Drawing.Size(309, 53);
            this.txtPassport.TabIndex = 4;
            this.txtPassport.UseSelectable = true;
            this.txtPassport.WaterMark = "Enter client passport information.";
            this.txtPassport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(320, 115);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "Tagging:";
            // 
            // txtTagging
            // 
            // 
            // 
            // 
            this.txtTagging.CustomButton.Image = null;
            this.txtTagging.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtTagging.CustomButton.Name = "";
            this.txtTagging.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtTagging.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTagging.CustomButton.TabIndex = 1;
            this.txtTagging.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTagging.CustomButton.UseSelectable = true;
            this.txtTagging.CustomButton.Visible = false;
            this.txtTagging.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Comments", true));
            this.txtTagging.Lines = new string[0];
            this.txtTagging.Location = new System.Drawing.Point(418, 115);
            this.txtTagging.MaxLength = 32767;
            this.txtTagging.Multiline = true;
            this.txtTagging.Name = "txtTagging";
            this.txtTagging.PasswordChar = '\0';
            this.txtTagging.PromptText = "Eneter your tag about client.";
            this.txtTagging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTagging.SelectedText = "";
            this.txtTagging.SelectionLength = 0;
            this.txtTagging.SelectionStart = 0;
            this.txtTagging.ShortcutsEnabled = true;
            this.txtTagging.Size = new System.Drawing.Size(309, 53);
            this.txtTagging.TabIndex = 5;
            this.txtTagging.UseSelectable = true;
            this.txtTagging.WaterMark = "Eneter your tag about client.";
            this.txtTagging.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTagging.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tstSearch
            // 
            // 
            // 
            // 
            this.tstSearch.CustomButton.Image = null;
            this.tstSearch.CustomButton.Location = new System.Drawing.Point(587, 1);
            this.tstSearch.CustomButton.Name = "";
            this.tstSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tstSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tstSearch.CustomButton.TabIndex = 1;
            this.tstSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tstSearch.CustomButton.UseSelectable = true;
            this.tstSearch.CustomButton.Visible = false;
            this.tstSearch.Lines = new string[0];
            this.tstSearch.Location = new System.Drawing.Point(118, 174);
            this.tstSearch.MaxLength = 32767;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.PasswordChar = '\0';
            this.tstSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tstSearch.SelectedText = "";
            this.tstSearch.SelectionLength = 0;
            this.tstSearch.SelectionStart = 0;
            this.tstSearch.ShortcutsEnabled = true;
            this.tstSearch.Size = new System.Drawing.Size(609, 23);
            this.tstSearch.TabIndex = 6;
            this.tstSearch.UseSelectable = true;
            this.tstSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tstSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 178);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Search:";
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 638);
            this.Controls.Add(this.txtTagging);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tstSearch);
            this.Controls.Add(this.txtPatronimic);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.mbtnReturn);
            this.Controls.Add(this.mbtnEdit);
            this.Controls.Add(this.mbtnSave);
            this.Controls.Add(this.mbtnDelete);
            this.Controls.Add(this.mbtnAdd);
            this.MaximizeBox = false;
            this.Name = "Journal";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private MetroFramework.Controls.MetroButton mbtnDelete;
        private MetroFramework.Controls.MetroButton mbtnSave;
        private MetroFramework.Controls.MetroButton mbtnEdit;
        private MetroFramework.Controls.MetroButton mbtnReturn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPatronimic;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPassport;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTagging;
        private MetroFramework.Controls.MetroTextBox tstSearch;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronimicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}
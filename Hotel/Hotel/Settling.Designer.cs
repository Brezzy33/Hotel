namespace Hotel
{
    partial class Settling
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
            this.btnPopulate = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtPriceWithDisc = new MetroFramework.Controls.MetroTextBox();
            this.settlementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.dateTimeSattl = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeRelease = new MetroFramework.Controls.MetroDateTime();
            this.comboBoxClients = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxRooms = new MetroFramework.Controls.MetroComboBox();
            this.numbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxType = new MetroFramework.Controls.MetroComboBox();
            this.typeZaselBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtWithoutDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.settlementTableAdapter = new Hotel.HotelDataSetTableAdapters.SettlementTableAdapter();
            this.typeZaselTableAdapter = new Hotel.HotelDataSetTableAdapters.TypeZaselTableAdapter();
            this.numbersTableAdapter = new Hotel.HotelDataSetTableAdapters.NumbersTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Hotel.HotelDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZaselBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 411);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(100, 42);
            this.btnPopulate.TabIndex = 17;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseSelectable = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(118, 411);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 42);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Calculate";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(224, 411);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(100, 42);
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "Return";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Clients number:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Room number";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Date sattling:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Date release:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 205);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Comments:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 289);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Discount:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(22, 318);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(139, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Price without discount:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 347);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Price with discount:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 376);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Type set:";
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(161, 289);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(163, 23);
            this.txtDiscount.TabIndex = 19;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPriceWithDisc
            // 
            // 
            // 
            // 
            this.txtPriceWithDisc.CustomButton.Image = null;
            this.txtPriceWithDisc.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtPriceWithDisc.CustomButton.Name = "";
            this.txtPriceWithDisc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceWithDisc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceWithDisc.CustomButton.TabIndex = 1;
            this.txtPriceWithDisc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceWithDisc.CustomButton.UseSelectable = true;
            this.txtPriceWithDisc.CustomButton.Visible = false;
            this.txtPriceWithDisc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementBindingSource, "EndPrice", true));
            this.txtPriceWithDisc.Lines = new string[0];
            this.txtPriceWithDisc.Location = new System.Drawing.Point(161, 347);
            this.txtPriceWithDisc.MaxLength = 32767;
            this.txtPriceWithDisc.Name = "txtPriceWithDisc";
            this.txtPriceWithDisc.PasswordChar = '\0';
            this.txtPriceWithDisc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceWithDisc.SelectedText = "";
            this.txtPriceWithDisc.SelectionLength = 0;
            this.txtPriceWithDisc.SelectionStart = 0;
            this.txtPriceWithDisc.ShortcutsEnabled = true;
            this.txtPriceWithDisc.Size = new System.Drawing.Size(163, 23);
            this.txtPriceWithDisc.TabIndex = 19;
            this.txtPriceWithDisc.UseSelectable = true;
            this.txtPriceWithDisc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceWithDisc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // settlementBindingSource
            // 
            this.settlementBindingSource.DataMember = "Settlement";
            this.settlementBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimeSattl
            // 
            this.dateTimeSattl.Location = new System.Drawing.Point(148, 133);
            this.dateTimeSattl.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeSattl.Name = "dateTimeSattl";
            this.dateTimeSattl.Size = new System.Drawing.Size(176, 29);
            this.dateTimeSattl.TabIndex = 20;
            // 
            // dateTimeRelease
            // 
            this.dateTimeRelease.Location = new System.Drawing.Point(148, 168);
            this.dateTimeRelease.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeRelease.Name = "dateTimeRelease";
            this.dateTimeRelease.Size = new System.Drawing.Size(176, 29);
            this.dateTimeRelease.TabIndex = 21;
            this.dateTimeRelease.Value = new System.DateTime(2017, 6, 9, 21, 35, 0, 0);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.DataSource = this.clientsBindingSource;
            this.comboBoxClients.DisplayMember = "idClient";
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.ItemHeight = 23;
            this.comboBoxClients.Location = new System.Drawing.Point(148, 63);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(176, 29);
            this.comboBoxClients.TabIndex = 22;
            this.comboBoxClients.UseSelectable = true;
            this.comboBoxClients.ValueMember = "idClient";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.DataSource = this.numbersBindingSource;
            this.comboBoxRooms.DisplayMember = "idNumber";
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.ItemHeight = 23;
            this.comboBoxRooms.Location = new System.Drawing.Point(148, 98);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(176, 29);
            this.comboBoxRooms.TabIndex = 22;
            this.comboBoxRooms.UseSelectable = true;
            this.comboBoxRooms.ValueMember = "idNumber";
            // 
            // numbersBindingSource
            // 
            this.numbersBindingSource.DataMember = "Numbers";
            this.numbersBindingSource.DataSource = this.hotelDataSet;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.typeZaselBindingSource;
            this.comboBoxType.DisplayMember = "TypeZas";
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.ItemHeight = 23;
            this.comboBoxType.Location = new System.Drawing.Point(161, 376);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(163, 29);
            this.comboBoxType.TabIndex = 22;
            this.comboBoxType.UseSelectable = true;
            this.comboBoxType.ValueMember = "idTypeZasel";
            // 
            // typeZaselBindingSource
            // 
            this.typeZaselBindingSource.DataMember = "TypeZasel";
            this.typeZaselBindingSource.DataSource = this.hotelDataSet;
            // 
            // txtWithoutDiscount
            // 
            // 
            // 
            // 
            this.txtWithoutDiscount.CustomButton.Image = null;
            this.txtWithoutDiscount.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtWithoutDiscount.CustomButton.Name = "";
            this.txtWithoutDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWithoutDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWithoutDiscount.CustomButton.TabIndex = 1;
            this.txtWithoutDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWithoutDiscount.CustomButton.UseSelectable = true;
            this.txtWithoutDiscount.CustomButton.Visible = false;
            this.txtWithoutDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numbersBindingSource, "PriceForNumber", true));
            this.txtWithoutDiscount.Lines = new string[0];
            this.txtWithoutDiscount.Location = new System.Drawing.Point(161, 318);
            this.txtWithoutDiscount.MaxLength = 32767;
            this.txtWithoutDiscount.Name = "txtWithoutDiscount";
            this.txtWithoutDiscount.PasswordChar = '\0';
            this.txtWithoutDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWithoutDiscount.SelectedText = "";
            this.txtWithoutDiscount.SelectionLength = 0;
            this.txtWithoutDiscount.SelectionStart = 0;
            this.txtWithoutDiscount.ShortcutsEnabled = true;
            this.txtWithoutDiscount.Size = new System.Drawing.Size(163, 23);
            this.txtWithoutDiscount.TabIndex = 19;
            this.txtWithoutDiscount.UseSelectable = true;
            this.txtWithoutDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWithoutDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(27, 227);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(297, 56);
            this.txtComments.TabIndex = 23;
            // 
            // settlementTableAdapter
            // 
            this.settlementTableAdapter.ClearBeforeFill = true;
            // 
            // typeZaselTableAdapter
            // 
            this.typeZaselTableAdapter.ClearBeforeFill = true;
            // 
            // numbersTableAdapter
            // 
            this.numbersTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Settling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 467);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.dateTimeRelease);
            this.Controls.Add(this.dateTimeSattl);
            this.Controls.Add(this.txtPriceWithDisc);
            this.Controls.Add(this.txtWithoutDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnPopulate);
            this.Name = "Settling";
            this.Text = "Settling";
            this.Load += new System.EventHandler(this.Settling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeZaselBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnPopulate;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroTextBox txtPriceWithDisc;
        private MetroFramework.Controls.MetroDateTime dateTimeSattl;
        private MetroFramework.Controls.MetroDateTime dateTimeRelease;
        private MetroFramework.Controls.MetroComboBox comboBoxClients;
        private MetroFramework.Controls.MetroComboBox comboBoxRooms;
        private MetroFramework.Controls.MetroComboBox comboBoxType;
        private MetroFramework.Controls.MetroTextBox txtWithoutDiscount;
        private System.Windows.Forms.TextBox txtComments;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource settlementBindingSource;
        private HotelDataSetTableAdapters.SettlementTableAdapter settlementTableAdapter;
        private System.Windows.Forms.BindingSource typeZaselBindingSource;
        private HotelDataSetTableAdapters.TypeZaselTableAdapter typeZaselTableAdapter;
        private System.Windows.Forms.BindingSource numbersBindingSource;
        private HotelDataSetTableAdapters.NumbersTableAdapter numbersTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}
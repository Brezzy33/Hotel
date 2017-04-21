namespace Hotel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vmestComboBox = new System.Windows.Forms.ComboBox();
            this.занятыеНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераВГостиницеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.konfortComboBox = new System.Windows.Forms.ComboBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaselenBtn = new System.Windows.Forms.Button();
            this.hotelDataSet = new Hotel.HotelDataSet();
            this.viewMainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMainFormTableAdapter = new Hotel.HotelDataSetTableAdapters.ViewMainFormTableAdapter();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаселенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыселенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комментDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vmestComboBox
            // 
            this.vmestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vmestComboBox.FormattingEnabled = true;
            this.vmestComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vmestComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.vmestComboBox.Location = new System.Drawing.Point(91, 19);
            this.vmestComboBox.Name = "vmestComboBox";
            this.vmestComboBox.Size = new System.Drawing.Size(162, 21);
            this.vmestComboBox.TabIndex = 2;
            // 
            // занятыеНомераToolStripMenuItem
            // 
            this.занятыеНомераToolStripMenuItem.Name = "занятыеНомераToolStripMenuItem";
            this.занятыеНомераToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.занятыеНомераToolStripMenuItem.Text = "Занятые номера";
            this.занятыеНомераToolStripMenuItem.Click += new System.EventHandler(this.занятыеНомераToolStripMenuItem_Click);
            // 
            // журналКлиентовToolStripMenuItem
            // 
            this.журналКлиентовToolStripMenuItem.Name = "журналКлиентовToolStripMenuItem";
            this.журналКлиентовToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.журналКлиентовToolStripMenuItem.Text = "Журнал клиентов";
            this.журналКлиентовToolStripMenuItem.Click += new System.EventHandler(this.журналКлиентовToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // номераВГостиницеToolStripMenuItem
            // 
            this.номераВГостиницеToolStripMenuItem.Name = "номераВГостиницеToolStripMenuItem";
            this.номераВГостиницеToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.номераВГостиницеToolStripMenuItem.Text = "Номера в гостинице";
            this.номераВГостиницеToolStripMenuItem.Click += new System.EventHandler(this.номераВГостиницеToolStripMenuItem_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(174, 132);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 40);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номера в гостинице:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.датазаселенияDataGridViewTextBoxColumn,
            this.датавыселенияDataGridViewTextBoxColumn,
            this.комментDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewMainFormBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(283, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(644, 252);
            this.dataGridView1.TabIndex = 8;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(174, 225);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(103, 41);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Обновить";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цена за номер:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "До:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.konfortComboBox);
            this.groupBox2.Controls.Add(this.vmestComboBox);
            this.groupBox2.Location = new System.Drawing.Point(14, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Комфортность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вместимость:";
            // 
            // konfortComboBox
            // 
            this.konfortComboBox.DisplayMember = "idComfortable";
            this.konfortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konfortComboBox.FormattingEnabled = true;
            this.konfortComboBox.Location = new System.Drawing.Point(91, 51);
            this.konfortComboBox.Name = "konfortComboBox";
            this.konfortComboBox.Size = new System.Drawing.Size(162, 21);
            this.konfortComboBox.TabIndex = 3;
            this.konfortComboBox.ValueMember = "idComfortable";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(174, 271);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 41);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(174, 178);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 41);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номераВГостиницеToolStripMenuItem,
            this.занятыеНомераToolStripMenuItem,
            this.журналКлиентовToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaselenBtn
            // 
            this.zaselenBtn.Location = new System.Drawing.Point(12, 272);
            this.zaselenBtn.Name = "zaselenBtn";
            this.zaselenBtn.Size = new System.Drawing.Size(103, 40);
            this.zaselenBtn.TabIndex = 11;
            this.zaselenBtn.Text = "Заселить";
            this.zaselenBtn.UseVisualStyleBackColor = true;
            this.zaselenBtn.Click += new System.EventHandler(this.zaselenBtn_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewMainFormBindingSource
            // 
            this.viewMainFormBindingSource.DataMember = "ViewMainForm";
            this.viewMainFormBindingSource.DataSource = this.hotelDataSet;
            // 
            // viewMainFormTableAdapter
            // 
            this.viewMainFormTableAdapter.ClearBeforeFill = true;
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            this.номерКомнатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датазаселенияDataGridViewTextBoxColumn
            // 
            this.датазаселенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_заселения";
            this.датазаселенияDataGridViewTextBoxColumn.HeaderText = "Дата заселения";
            this.датазаселенияDataGridViewTextBoxColumn.Name = "датазаселенияDataGridViewTextBoxColumn";
            this.датазаселенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датавыселенияDataGridViewTextBoxColumn
            // 
            this.датавыселенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_выселения";
            this.датавыселенияDataGridViewTextBoxColumn.HeaderText = "Дата выселения";
            this.датавыселенияDataGridViewTextBoxColumn.Name = "датавыселенияDataGridViewTextBoxColumn";
            this.датавыселенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // комментDataGridViewTextBoxColumn
            // 
            this.комментDataGridViewTextBoxColumn.DataPropertyName = "Коммент";
            this.комментDataGridViewTextBoxColumn.HeaderText = "Коммент";
            this.комментDataGridViewTextBoxColumn.Name = "комментDataGridViewTextBoxColumn";
            this.комментDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 320);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.zaselenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vmestComboBox;
        private System.Windows.Forms.ToolStripMenuItem занятыеНомераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераВГостиницеToolStripMenuItem;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox konfortComboBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button zaselenBtn;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource viewMainFormBindingSource;
        private HotelDataSetTableAdapters.ViewMainFormTableAdapter viewMainFormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаселенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыселенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментDataGridViewTextBoxColumn;
    }
}


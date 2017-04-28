using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Journal : MetroFramework.Forms.MetroForm
    {
        public Journal()
        {
            InitializeComponent();
            Edit(false);
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);
        }

        private void mbtnReturn_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            Edit(false);
            ClearText();
            this.Close();
        }

        void Edit(bool value)
        {
            txtName.Enabled = value;
            txtPassport.Enabled = value;
            txtPatronimic.Enabled = value;
            txtSurname.Enabled = value;
            txtTagging.Enabled = value;
        }

        private void mbtnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);//Allow edit
            txtName.Focus();
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            try
            {
                txtName.Focus();
                this.hotelDataSet.Clients.AddClientsRow(this.hotelDataSet.Clients.NewClientsRow());
                clientsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Edit(true);//Allow edit
            txtName.Focus();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to delete this client?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int IndentId = Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value);
                HotelDataSetTableAdapters.QueriesTableAdapter delsetl = new HotelDataSetTableAdapters.QueriesTableAdapter();
                delsetl.DelClient((int)IndentId);
                Journal_Load(null, null);
                ClearText();
            }
           
        }

        void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassport.Text = string.Empty;
            txtPatronimic.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtTagging.Text = string.Empty;
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    clientsBindingSource.EndEdit();
                    clientsTableAdapter.Update(this.hotelDataSet.Clients);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MetroFramework.MetroMessageBox.Show(this,"Your data has been successfuly saved.","Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //ClearText();
                Edit(false);//Read only
        }

        private void tstSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Clients". При необходимости она может быть перемещена или удалена.
                this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);
                clientsBindingSource.DataSource = this.hotelDataSet.Clients;
            }
            else
            {
                var query = from o in this.hotelDataSet.Clients
                            where o.Surname.Contains(tstSearch.Text) || o.Name.Contains(tstSearch.Text) || o.Patronimic.Contains(tstSearch.Text)
                            select o;
                clientsBindingSource.DataSource = query.ToList();
            }
        }
    }
}

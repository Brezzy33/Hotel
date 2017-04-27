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
            Edit(true);
            ClearText();
            this.Close();
        }

        void Edit(bool value)
        {
            txtID.ReadOnly = value;
            txtName.ReadOnly = value;
            txtPassport.ReadOnly = value;
            txtPatronimic.ReadOnly = value;
            txtSurname.ReadOnly = value;
            txtTagging.ReadOnly = value;
        }

        private void mbtnEdit_Click(object sender, EventArgs e)
        {
            Edit(false);//Allow edit
            txtName.Focus();
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            clientsBindingSource.Add(new Clients());
            clientsBindingSource.MoveLast();
            Edit(false);//Allow edit
            txtName.Focus();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to delete this client?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
               
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
            using (RedisClient client = new RedisClient("localhost", 7504))
            {
                clientsBindingSource.EndEdit();
                

                MetroFramework.MetroMessageBox.Show(this,"Your data has been successfuly saved.","Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //ClearText();
                Edit(true);//Read only
            }
        }
    }
}

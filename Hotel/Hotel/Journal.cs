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

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void Journal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDataSet.Clients);

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
    }
}

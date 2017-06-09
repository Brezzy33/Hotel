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
    public partial class Settling : MetroFramework.Forms.MetroForm
    {
        public Settling()
        {
            InitializeComponent();
        }

        private void Settling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Numbers' table. You can move, or remove it, as needed.
            this.numbersTableAdapter.Fill(this.hotelDataSet.Numbers);
            // TODO: This line of code loads data into the 'hotelDataSet.TypeZasel' table. You can move, or remove it, as needed.
            this.typeZaselTableAdapter.Fill(this.hotelDataSet.TypeZasel);
            // TODO: This line of code loads data into the 'hotelDataSet.Settlement' table. You can move, or remove it, as needed.
            this.settlementTableAdapter.Fill(this.hotelDataSet.Settlement);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Math()
        {
            try
            {
                int x = Convert.ToInt32(txtWithoutDiscount.Text);
                int y = Convert.ToInt32(txtDiscount.Text);
                int day = (dateTimeSattl.Value - dateTimeRelease.Value).Days;
                int z = ((x - (x * y / 100)) * (day + 1));
                txtPriceWithDisc.Text = z.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Math();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            HotelDataSetTableAdapters.QueriesTableAdapter add = new HotelDataSetTableAdapters.QueriesTableAdapter();
            string z = comboBoxType.Text;
            int idClient = Convert.ToInt32(comboBoxClients.SelectedValue);
            int idNumber = Convert.ToInt32(comboBoxRooms.SelectedValue);
            DateTime DateSettlement = dateTimeSattl.Value;
            DateTime DateRelease = dateTimeRelease.Value;
            string Comments = txtComments.Text;
            int EndPrice = Convert.ToInt32(txtPriceWithDisc.Text);

            //Хранимая процедар на добавление строк в таблица заселения.

            Settling_Load(null, null);
        }
    }
}

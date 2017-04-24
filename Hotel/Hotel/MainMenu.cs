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
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        /*
        public void RowsColor() //Подсвечиваем ячейки заселенные и забронированные
        {
            for (int i = 0; i < mGrid.RowCount; i++)
            {
                
                if (mGrid.Rows[i].Cells[5].Value.ToString() == "Заселен")
                {
                    mGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (mGrid.Rows[i].Cells[5].Value.ToString() == "Забронирован")
                {
                    mGrid.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
       */

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void zaselenBtn_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Заполните все поля для поиска.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int IndentId = Convert.ToInt32(mGrid.CurrentRow.Cells[3].Value);
            {
                if (MessageBox.Show("Вы точно желаете освободить комнату № " + IndentId + "? ",
                    "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
            }

        }

        private void номераВГостиницеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //RowsColor();
        }

        private void занятыеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void журналКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.TypeComfortable' table. You can move, or remove it, as needed.
            this.typeComfortableTableAdapter.Fill(this.hotelDataSet.TypeComfortable);
            // TODO: This line of code loads data into the 'hotelDataSet.Numbers' table. You can move, or remove it, as needed.
            this.numbersTableAdapter.Fill(this.hotelDataSet.Numbers);
            // TODO: This line of code loads data into the 'hotelDataSet.Numbers' table. You can move, or remove it, as needed.
            this.numbersTableAdapter.Fill(this.hotelDataSet.Numbers);
            // TODO: This line of code loads data into the 'hotelDataSet.ViewMainForm' table. You can move, or remove it, as needed.
            this.viewMainFormTableAdapter.Fill(this.hotelDataSet.ViewMainForm);
            //RowsColor();
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}

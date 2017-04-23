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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void RowsColor() //Подсвечиваем ячейки заселенные и забронированные
        {
            for (int i=0; i<dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() =="Заселен")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if(dataGridView1.Rows[i].Cells[3].Value.ToString() == "Забронирован")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.ViewMainForm' table. You can move, or remove it, as needed.
            this.viewMainFormTableAdapter.Fill(this.hotelDataSet.ViewMainForm);
            RowsColor();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int IndentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            {
                if (MessageBox.Show("Вы точно желаете освободить комнату № " + IndentId + "? ",
                    "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }
            }
            
        }

        private void номераВГостиницеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            RowsColor();
        }

        private void занятыеНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBtn.Enabled = true;
        }

        private void журналКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }
    }
}

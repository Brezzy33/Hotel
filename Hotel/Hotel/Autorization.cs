using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace Hotel
{
    public partial class Autorization : MetroFramework.Forms.MetroForm
    {
        public Autorization()
        {
            InitializeComponent();       

        }


        private void Autorization_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your user name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotel.Properties.Settings.HotelConnectionString"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    User obj = db.Query<User>($"select *from dbuser where UserName = '{txtUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj !=null)
                    {
                        if (obj.Password== txtPassword.Text)
                        {
                            using (MainMenu frm1 = new MainMenu())
                            {
                                this.Hide();
                                frm1.ShowDialog();
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Your username don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.RememberMe = chkRememberMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chkRememberMe.Checked==false)
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.Save();
        }
    }
}

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
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeComboBox.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(colorComboBox.SelectedIndex);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            themeComboBox.SelectedIndex = 0;
            colorComboBox.SelectedIndex = 0;
        }
    }
}

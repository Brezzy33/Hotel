﻿using System;
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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void журналКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }
    }
}

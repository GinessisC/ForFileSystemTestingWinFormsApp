﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForFileSystemTestingWinFormsApp.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            DefiningKatalogForm definingKatalogForm = new DefiningKatalogForm();
            definingKatalogForm.Show();
        }
    }
}

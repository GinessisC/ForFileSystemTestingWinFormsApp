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
    public partial class DefiningKatalogForm : Form
    {

        public DefiningKatalogForm()
        {
            InitializeComponent();
        }

        private void DefiningKatalogForm_Load(object sender, EventArgs e)
        {

            

        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

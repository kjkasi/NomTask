﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomTask
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = resultTableAdapter.GetData(Int32.Parse(comboBox1.Text));
        }
    }
}

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
    public partial class FormPlan : Form
    {
        public FormPlan()
        {
            InitializeComponent();
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nomTaskDataSet.PlanView". При необходимости она может быть перемещена или удалена.
            this.planViewTableAdapter.Fill(this.nomTaskDataSet.PlanView);

        }
    }
}

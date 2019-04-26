using System;
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
    public partial class FormMachine : Form
    {
        public FormMachine()
        {
            InitializeComponent();
        }

        private void FormMachine_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nomTaskDataSet.Machine". При необходимости она может быть перемещена или удалена.
            this.machineTableAdapter.Fill(this.nomTaskDataSet.Machine);

        }
    }
}

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
    public partial class FormMachineByGroup : Form
    {
        public FormMachineByGroup()
        {
            InitializeComponent();
        }

        private void FormMachineByGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nomTaskDataSet.MachineByGroupView". При необходимости она может быть перемещена или удалена.
            this.machineByGroupViewTableAdapter.Fill(this.nomTaskDataSet.MachineByGroupView);

        }
    }
}

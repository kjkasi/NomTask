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
    public partial class FormRoute : Form
    {
        public FormRoute()
        {
            InitializeComponent();
        }

        private void FormRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nomTaskDataSet.RouteView". При необходимости она может быть перемещена или удалена.
            this.routeViewTableAdapter.Fill(this.nomTaskDataSet.RouteView);

        }
    }
}

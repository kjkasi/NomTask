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
    public partial class FormArticle : Form
    {
        public FormArticle()
        {
            InitializeComponent();
        }

        private void FormArticle_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nomTaskDataSet.Article". При необходимости она может быть перемещена или удалена.
            this.articleTableAdapter.Fill(this.nomTaskDataSet.Article);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

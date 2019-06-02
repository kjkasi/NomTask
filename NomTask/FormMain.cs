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
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Окно " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticle form = new FormArticle();
            form.MdiParent = this;
            form.Show();
        }

        private void MachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMachine form = new FormMachine();
            form.MdiParent = this;
            form.Show();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGroup form = new FormGroup();
            form.MdiParent = this;
            form.Show();
        }

        private void MachineByGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMachineByGroup form = new FormMachineByGroup();
            form.MdiParent = this;
            form.Show();
        }

        private void RouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoute form = new FormRoute();
            form.MdiParent = this;
            form.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            FormResult form = new FormResult();
            form.MdiParent = this;
            form.Show();
        }

        private void TimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTime form = new FormTime();
            form.MdiParent = this;
            form.Show();
        }

        private void PlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlan form = new FormPlan();
            form.MdiParent = this;
            form.Show();
        }
    }
}

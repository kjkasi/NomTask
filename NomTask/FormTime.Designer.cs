namespace NomTask
{
    partial class FormTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.routeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTaskDataSet = new NomTask.NomTaskDataSet();
            this.nomTaskDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeViewTableAdapter = new NomTask.NomTaskDataSetTableAdapters.RouteViewTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeViewTableAdapter = new NomTask.NomTaskDataSetTableAdapters.TimeViewTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // routeViewBindingSource
            // 
            this.routeViewBindingSource.DataMember = "RouteView";
            this.routeViewBindingSource.DataSource = this.nomTaskDataSetBindingSource;
            // 
            // nomTaskDataSet
            // 
            this.nomTaskDataSet.DataSetName = "NomTaskDataSet";
            this.nomTaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomTaskDataSetBindingSource
            // 
            this.nomTaskDataSetBindingSource.DataSource = this.nomTaskDataSet;
            this.nomTaskDataSetBindingSource.Position = 0;
            // 
            // routeViewTableAdapter
            // 
            this.routeViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.nameArticleDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.nameGroupDataGridViewTextBoxColumn,
            this.processTimeDataGridViewTextBoxColumn,
            this.produceTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // timeViewBindingSource
            // 
            this.timeViewBindingSource.DataMember = "TimeView";
            this.timeViewBindingSource.DataSource = this.nomTaskDataSetBindingSource;
            // 
            // timeViewTableAdapter
            // 
            this.timeViewTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameArticleDataGridViewTextBoxColumn
            // 
            this.nameArticleDataGridViewTextBoxColumn.DataPropertyName = "NameArticle";
            this.nameArticleDataGridViewTextBoxColumn.HeaderText = "Обозначение";
            this.nameArticleDataGridViewTextBoxColumn.Name = "nameArticleDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameGroupDataGridViewTextBoxColumn
            // 
            this.nameGroupDataGridViewTextBoxColumn.DataPropertyName = "NameGroup";
            this.nameGroupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.nameGroupDataGridViewTextBoxColumn.Name = "nameGroupDataGridViewTextBoxColumn";
            // 
            // processTimeDataGridViewTextBoxColumn
            // 
            this.processTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcessTime";
            this.processTimeDataGridViewTextBoxColumn.HeaderText = "Время обработки";
            this.processTimeDataGridViewTextBoxColumn.Name = "processTimeDataGridViewTextBoxColumn";
            // 
            // produceTimeDataGridViewTextBoxColumn
            // 
            this.produceTimeDataGridViewTextBoxColumn.DataPropertyName = "ProduceTime";
            this.produceTimeDataGridViewTextBoxColumn.HeaderText = "ПЗ";
            this.produceTimeDataGridViewTextBoxColumn.Name = "produceTimeDataGridViewTextBoxColumn";
            // 
            // FormTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTime";
            this.Text = "FormTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NomTaskDataSet nomTaskDataSet;
        private System.Windows.Forms.BindingSource nomTaskDataSetBindingSource;
        private System.Windows.Forms.BindingSource routeViewBindingSource;
        private NomTaskDataSetTableAdapters.RouteViewTableAdapter routeViewTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource timeViewBindingSource;
        private NomTaskDataSetTableAdapters.TimeViewTableAdapter timeViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceTimeDataGridViewTextBoxColumn;
    }
}
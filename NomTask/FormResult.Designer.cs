﻿namespace NomTask
{
    partial class FormResult
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTaskDataSet = new NomTask.NomTaskDataSet();
            this.resultTableAdapter = new NomTask.NomTaskDataSetTableAdapters.ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(113, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество смен";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.sUMDataGridViewTextBoxColumn,
            this.dAYDataGridViewTextBoxColumn,
            this.lAGDataGridViewTextBoxColumn,
            this.rOWDataGridViewTextBoxColumn,
            this.fACTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 3;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "ДСЕ ";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Группа станков";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 150;
            // 
            // sUMDataGridViewTextBoxColumn
            // 
            this.sUMDataGridViewTextBoxColumn.DataPropertyName = "SUM";
            this.sUMDataGridViewTextBoxColumn.HeaderText = "Время изготовления партии (дни)";
            this.sUMDataGridViewTextBoxColumn.Name = "sUMDataGridViewTextBoxColumn";
            this.sUMDataGridViewTextBoxColumn.Width = 150;
            // 
            // dAYDataGridViewTextBoxColumn
            // 
            this.dAYDataGridViewTextBoxColumn.DataPropertyName = "DAY";
            this.dAYDataGridViewTextBoxColumn.HeaderText = "План";
            this.dAYDataGridViewTextBoxColumn.Name = "dAYDataGridViewTextBoxColumn";
            this.dAYDataGridViewTextBoxColumn.Width = 150;
            // 
            // lAGDataGridViewTextBoxColumn
            // 
            this.lAGDataGridViewTextBoxColumn.DataPropertyName = "LAG#";
            this.lAGDataGridViewTextBoxColumn.HeaderText = "LAG#";
            this.lAGDataGridViewTextBoxColumn.Name = "lAGDataGridViewTextBoxColumn";
            this.lAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // rOWDataGridViewTextBoxColumn
            // 
            this.rOWDataGridViewTextBoxColumn.DataPropertyName = "ROW#";
            this.rOWDataGridViewTextBoxColumn.HeaderText = "ROW#";
            this.rOWDataGridViewTextBoxColumn.Name = "rOWDataGridViewTextBoxColumn";
            this.rOWDataGridViewTextBoxColumn.Visible = false;
            // 
            // fACTDataGridViewTextBoxColumn
            // 
            this.fACTDataGridViewTextBoxColumn.DataPropertyName = "FACT";
            this.fACTDataGridViewTextBoxColumn.HeaderText = "Факт";
            this.fACTDataGridViewTextBoxColumn.Name = "fACTDataGridViewTextBoxColumn";
            this.fACTDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACTDataGridViewTextBoxColumn.Width = 150;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.nomTaskDataSet;
            // 
            // nomTaskDataSet
            // 
            this.nomTaskDataSet.DataSetName = "NomTaskDataSet";
            this.nomTaskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormResult";
            this.Text = "Номенклатурное задание";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTaskDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private NomTaskDataSet nomTaskDataSet;
        private NomTaskDataSetTableAdapters.ResultTableAdapter resultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACTDataGridViewTextBoxColumn;
    }
}
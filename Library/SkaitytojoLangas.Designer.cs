﻿namespace Library
{
    partial class SkaitytojoLangas
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
            this.knygosDataSet1 = new Library.KnygosDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Library.KnygosDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Library.KnygosDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.knygosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // knygosDataSet1
            // 
            this.knygosDataSet1.DataSetName = "KnygosDataSet1";
            this.knygosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.knygosDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.KnygosDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.autoriusDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(49, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // autoriusDataGridViewTextBoxColumn
            // 
            this.autoriusDataGridViewTextBoxColumn.DataPropertyName = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.HeaderText = "Autorius";
            this.autoriusDataGridViewTextBoxColumn.Name = "autoriusDataGridViewTextBoxColumn";
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            // 
            // tableBindingSource3
            // 
            this.tableBindingSource3.DataMember = "Table";
            this.tableBindingSource3.DataSource = this.knygosDataSet1;
            // 
            // knygosDataSet1BindingSource
            // 
            this.knygosDataSet1BindingSource.DataSource = this.knygosDataSet1;
            this.knygosDataSet1BindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.knygosDataSet1;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.knygosDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rezervuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ID";
            // 
            // SkaitytojoLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SkaitytojoLangas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SkaitytojoLangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knygosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KnygosDataSet1 knygosDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private KnygosDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private KnygosDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource knygosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private System.Windows.Forms.BindingSource tableBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
    }
}
﻿namespace MaterialList.Forms
{
    partial class frmMaterialList
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
            btnClear = new Button();
            BtnCalculate = new Button();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(232, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 46);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(12, 12);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(104, 46);
            BtnCalculate.TabIndex = 13;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1256, 361);
            dataGridView1.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(122, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 46);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmMaterialList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 443);
            Controls.Add(btnClear);
            Controls.Add(BtnCalculate);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Name = "frmMaterialList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private Button BtnCalculate;
        private DataGridView dataGridView1;
        private Button btnSave;
    }
}
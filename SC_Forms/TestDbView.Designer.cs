using SC_DbConfig;
using System.Windows.Forms;

namespace SC_Forms
{
    partial class TestDbView
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            init6BindingSource = new BindingSource(components);
            init6BindingSource1 = new BindingSource(components);
            btnDelete = new Button();
            btnUpdata = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 335);
            dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(345, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdata
            // 
            btnUpdata.Location = new Point(159, 393);
            btnUpdata.Name = "btnUpdata";
            btnUpdata.Size = new Size(75, 23);
            btnUpdata.TabIndex = 3;
            btnUpdata.Text = "updata";
            btnUpdata.UseVisualStyleBackColor = true;
            btnUpdata.Click += button3_Click;
            // 
            // TestDbView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdata);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Name = "TestDbView";
            Text = "TestDbView";
            Load += TestDbView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource init6BindingSource;
        private Button btnSave;
        private BindingSource init6BindingSource1;
        private Button btnDelete;
        private Button btnUpdata;
    }
}
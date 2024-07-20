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
            button1 = new Button();
            init6BindingSource = new BindingSource(components);
            init6BindingSource1 = new BindingSource(components);
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

            // data添加到窗口初始化去，并且窗口要每次都New
            SC_DbContext SC_Db = new SC_DbContext();
            var data = SC_Db.Users.ToList(); // 或者其他查询方式
            dataGridView1.DataSource = data;
            // 
            // button1
            // 
            button1.Location = new Point(345, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            // 
            // init6BindingSource
            // 
            init6BindingSource.DataSource = typeof(SC_DbConfig.Migrations.Init6);
            // 
            // init6BindingSource1
            // 
            init6BindingSource1.DataSource = typeof(SC_DbConfig.Migrations.Init6);
            // 
            // TestDbView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "TestDbView";
            Text = "TestDbView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)init6BindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource init6BindingSource;
        private Button button1;
        private BindingSource init6BindingSource1;
    }
}
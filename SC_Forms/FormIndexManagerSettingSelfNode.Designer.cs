namespace SC_Forms
{
    partial class FormIndexManagerSettingSelfNode
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            Guid = new DataGridViewTextBoxColumn();
            EmpName = new DataGridViewTextBoxColumn();
            OrgName = new DataGridViewTextBoxColumn();
            OwnerId = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewTextBoxColumn();
            ParentGuid = new DataGridViewTextBoxColumn();
            AV = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            txParentNode = new TextBox();
            button2 = new Button();
            txEmpName = new Label();
            txOrgName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(txOrgName);
            splitContainer1.Panel2.Controls.Add(txEmpName);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(txParentNode);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Guid, EmpName, OrgName, OwnerId, IsDeleted, ParentGuid, AV });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 266);
            dataGridView1.TabIndex = 0;
            // 
            // Guid
            // 
            Guid.HeaderText = "唯一识别";
            Guid.Name = "Guid";
            Guid.ReadOnly = true;
            // 
            // EmpName
            // 
            EmpName.HeaderText = "负责人名字";
            EmpName.Name = "EmpName";
            EmpName.ReadOnly = true;
            // 
            // OrgName
            // 
            OrgName.HeaderText = "部门名字";
            OrgName.Name = "OrgName";
            OrgName.ReadOnly = true;
            // 
            // OwnerId
            // 
            OwnerId.HeaderText = "权属人";
            OwnerId.Name = "OwnerId";
            OwnerId.ReadOnly = true;
            // 
            // IsDeleted
            // 
            IsDeleted.HeaderText = "IsDeleted";
            IsDeleted.Name = "IsDeleted";
            IsDeleted.ReadOnly = true;
            IsDeleted.Visible = false;
            // 
            // ParentGuid
            // 
            ParentGuid.HeaderText = "父节点";
            ParentGuid.Name = "ParentGuid";
            ParentGuid.ReadOnly = true;
            // 
            // AV
            // 
            AV.HeaderText = "合法性";
            AV.Name = "AV";
            AV.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(154, 122);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "加入节点";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 34);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 1;
            label1.Text = "父节点 Guid :";
            // 
            // txParentNode
            // 
            txParentNode.Location = new Point(154, 28);
            txParentNode.Name = "txParentNode";
            txParentNode.Size = new Size(106, 23);
            txParentNode.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(434, 72);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            // 
            // txEmpName
            // 
            txEmpName.AutoSize = true;
            txEmpName.Location = new Point(63, 67);
            txEmpName.Name = "txEmpName";
            txEmpName.Size = new Size(75, 17);
            txEmpName.TabIndex = 4;
            txEmpName.Text = "负责人名字 :";
            // 
            // txOrgName
            // 
            txOrgName.AutoSize = true;
            txOrgName.Location = new Point(75, 96);
            txOrgName.Name = "txOrgName";
            txOrgName.Size = new Size(63, 17);
            txOrgName.TabIndex = 5;
            txOrgName.Text = "部门名字 :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 7;
            // 
            // FormIndexManagerSettingSelfNode
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormIndexManagerSettingSelfNode";
            Text = "FormIndexManagerSettingLoadSelfNote";
            Load += FormIndexManagerSettingLoadSelfNote_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Guid;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn OrgName;
        private DataGridViewTextBoxColumn OwnerId;
        private DataGridViewTextBoxColumn IsDeleted;
        private DataGridViewTextBoxColumn ParentGuid;
        private DataGridViewTextBoxColumn AV;
        private TextBox txParentNode;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label txOrgName;
        private Label txEmpName;
    }
}
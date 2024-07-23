namespace SC_Forms
{
    partial class FormIndexManagerSettingRegisteredRootNode
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
            label1 = new Label();
            txEmpName = new TextBox();
            label2 = new Label();
            txOrgName = new TextBox();
            btnRegistered = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 159);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "负责人名字";
            // 
            // txEmpName
            // 
            txEmpName.Location = new Point(211, 156);
            txEmpName.Name = "txEmpName";
            txEmpName.Size = new Size(100, 23);
            txEmpName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 130);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "组织名字";
            // 
            // txOrgName
            // 
            txOrgName.Location = new Point(211, 127);
            txOrgName.Name = "txOrgName";
            txOrgName.Size = new Size(100, 23);
            txOrgName.TabIndex = 3;
            // 
            // btnRegistered
            // 
            btnRegistered.Location = new Point(211, 211);
            btnRegistered.Name = "btnRegistered";
            btnRegistered.Size = new Size(75, 23);
            btnRegistered.TabIndex = 4;
            btnRegistered.Text = "注册";
            btnRegistered.UseVisualStyleBackColor = true;
            btnRegistered.Click += btnRegistered_Click;
            // 
            // FormIndexManagerSettingRegisteredRootNode
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistered);
            Controls.Add(txOrgName);
            Controls.Add(label2);
            Controls.Add(txEmpName);
            Controls.Add(label1);
            Name = "FormIndexManagerSettingRegisteredRootNode";
            Text = "FormIndexManagerSettingRegisteredRootNode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txEmpName;
        private Label label2;
        private TextBox txOrgName;
        private Button btnRegistered;
    }
}
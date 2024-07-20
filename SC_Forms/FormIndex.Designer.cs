namespace SC_Forms
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            btnSetting = new ToolStripSplitButton();
            btnUserSetting = new ToolStripMenuItem();
            组织管理ToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, btnSetting, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Transparent;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 22);
            toolStripButton1.Text = "关闭";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // btnSetting
            // 
            btnSetting.DropDownItems.AddRange(new ToolStripItem[] { btnUserSetting, 组织管理ToolStripMenuItem });
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(72, 22);
            btnSetting.Text = "管理界面";
            // 
            // btnUserSetting
            // 
            btnUserSetting.Name = "btnUserSetting";
            btnUserSetting.Size = new Size(180, 22);
            btnUserSetting.Text = "用户管理";
            btnUserSetting.Click += btnUserSetting_Click;
            // 
            // 组织管理ToolStripMenuItem
            // 
            组织管理ToolStripMenuItem.Name = "组织管理ToolStripMenuItem";
            组织管理ToolStripMenuItem.Size = new Size(180, 22);
            组织管理ToolStripMenuItem.Text = "组织管理";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 22);
            toolStripButton2.Text = "最大";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 22);
            toolStripButton3.Text = "最大";
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hi, ";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton btnSetting;
        private ToolStripMenuItem btnUserSetting;
        private ToolStripMenuItem 组织管理ToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
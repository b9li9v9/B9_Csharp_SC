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
            menuNodeManager = new ToolStripMenuItem();
            注册根节点ToolStripMenuItem = new ToolStripMenuItem();
            删除根节点ToolStripMenuItem = new ToolStripMenuItem();
            修改根节点ToolStripMenuItem = new ToolStripMenuItem();
            查询根节点ToolStripMenuItem = new ToolStripMenuItem();
            menuSelfNode = new ToolStripMenuItem();
            加入节点ToolStripMenuItem = new ToolStripMenuItem();
            menuSelectSelfNode = new ToolStripMenuItem();
            menuDeleteSelfNode = new ToolStripMenuItem();
            查询子节点ToolStripMenuItem = new ToolStripMenuItem();
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
            toolStrip1.MouseDown += toolStrip1_MouseDown;
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
            组织管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNodeManager, menuSelfNode, 查询子节点ToolStripMenuItem });
            组织管理ToolStripMenuItem.Name = "组织管理ToolStripMenuItem";
            组织管理ToolStripMenuItem.Size = new Size(180, 22);
            组织管理ToolStripMenuItem.Text = "组织管理";
            // 
            // menuNodeManager
            // 
            menuNodeManager.DropDownItems.AddRange(new ToolStripItem[] { 注册根节点ToolStripMenuItem, 删除根节点ToolStripMenuItem, 修改根节点ToolStripMenuItem, 查询根节点ToolStripMenuItem });
            menuNodeManager.Name = "menuNodeManager";
            menuNodeManager.Size = new Size(180, 22);
            menuNodeManager.Text = "根节点管理";
            // 
            // 注册根节点ToolStripMenuItem
            // 
            注册根节点ToolStripMenuItem.Name = "注册根节点ToolStripMenuItem";
            注册根节点ToolStripMenuItem.Size = new Size(180, 22);
            注册根节点ToolStripMenuItem.Text = "注册根节点";
            注册根节点ToolStripMenuItem.Click += 注册根节点ToolStripMenuItem_Click;
            // 
            // 删除根节点ToolStripMenuItem
            // 
            删除根节点ToolStripMenuItem.Name = "删除根节点ToolStripMenuItem";
            删除根节点ToolStripMenuItem.Size = new Size(180, 22);
            删除根节点ToolStripMenuItem.Text = "删除根节点";
            // 
            // 修改根节点ToolStripMenuItem
            // 
            修改根节点ToolStripMenuItem.Name = "修改根节点ToolStripMenuItem";
            修改根节点ToolStripMenuItem.Size = new Size(180, 22);
            修改根节点ToolStripMenuItem.Text = "修改根节点";
            // 
            // 查询根节点ToolStripMenuItem
            // 
            查询根节点ToolStripMenuItem.Name = "查询根节点ToolStripMenuItem";
            查询根节点ToolStripMenuItem.Size = new Size(180, 22);
            查询根节点ToolStripMenuItem.Text = "查询根节点";
            查询根节点ToolStripMenuItem.Click += 查询根节点ToolStripMenuItem_Click;
            // 
            // menuSelfNode
            // 
            menuSelfNode.DropDownItems.AddRange(new ToolStripItem[] { 加入节点ToolStripMenuItem, menuSelectSelfNode, menuDeleteSelfNode });
            menuSelfNode.Name = "menuSelfNode";
            menuSelfNode.Size = new Size(180, 22);
            menuSelfNode.Text = "本节点管理";
            // 
            // 加入节点ToolStripMenuItem
            // 
            加入节点ToolStripMenuItem.Name = "加入节点ToolStripMenuItem";
            加入节点ToolStripMenuItem.Size = new Size(180, 22);
            加入节点ToolStripMenuItem.Text = "加入父节点";
            // 
            // menuSelectSelfNode
            // 
            menuSelectSelfNode.Name = "menuSelectSelfNode";
            menuSelectSelfNode.Size = new Size(180, 22);
            menuSelectSelfNode.Text = "查阅本节点";
            menuSelectSelfNode.Click += menuSelectSelfNode_Click;
            // 
            // menuDeleteSelfNode
            // 
            menuDeleteSelfNode.Name = "menuDeleteSelfNode";
            menuDeleteSelfNode.Size = new Size(180, 22);
            menuDeleteSelfNode.Text = "删除本节点";
            // 
            // 查询子节点ToolStripMenuItem
            // 
            查询子节点ToolStripMenuItem.Name = "查询子节点ToolStripMenuItem";
            查询子节点ToolStripMenuItem.Size = new Size(180, 22);
            查询子节点ToolStripMenuItem.Text = "子节点管理";
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
        private ToolStripMenuItem menuNodeManager;
        private ToolStripMenuItem 查询子节点ToolStripMenuItem;
        private ToolStripMenuItem menuSelfNode;
        private ToolStripMenuItem 注册根节点ToolStripMenuItem;
        private ToolStripMenuItem 删除根节点ToolStripMenuItem;
        private ToolStripMenuItem 修改根节点ToolStripMenuItem;
        private ToolStripMenuItem 查询根节点ToolStripMenuItem;
        private ToolStripMenuItem 加入节点ToolStripMenuItem;
        private ToolStripMenuItem menuSelectSelfNode;
        private ToolStripMenuItem menuDeleteSelfNode;
    }
}
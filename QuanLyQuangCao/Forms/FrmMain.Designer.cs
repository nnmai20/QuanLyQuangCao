namespace QLQC
{
    partial class FrmMain
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.treeViewNav = new System.Windows.Forms.TreeView();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnVịPhátHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBàiViếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biểuĐồToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            // 
            // panelNav
            // 
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 28);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 422);
            this.panelNav.TabIndex = 2;
            // 
            // treeViewNav
            // 
            this.treeViewNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNav.Location = new System.Drawing.Point(0, 0);
            this.treeViewNav.Name = "treeViewNav";
            this.treeViewNav.Size = new System.Drawing.Size(200, 422);
            this.treeViewNav.TabIndex = 0;
            this.treeViewNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                new System.Windows.Forms.TreeNode("Khách hàng"),
                new System.Windows.Forms.TreeNode("Đơn vị phát hành"),
                new System.Windows.Forms.TreeNode("Thống kê bài viết"),
                new System.Windows.Forms.TreeNode("Biểu đồ")
            });
            this.treeViewNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNav_AfterSelect);
            // 
            // Add controls to panelNav
            // 
            this.panelNav.Controls.Add(this.treeViewNav);
            // 
            // Adjust Controls collection order
            // 
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNav);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.đơnVịPhátHànhToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // đơnVịPhátHànhToolStripMenuItem
            // 
            this.đơnVịPhátHànhToolStripMenuItem.Name = "đơnVịPhátHànhToolStripMenuItem";
            this.đơnVịPhátHànhToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.đơnVịPhátHànhToolStripMenuItem.Text = "Đơn vị phát hành";
            this.đơnVịPhátHànhToolStripMenuItem.Click += new System.EventHandler(this.đơnVịPhátHànhToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêBàiViếtToolStripMenuItem,
            this.biểuĐồToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // thốngKêBàiViếtToolStripMenuItem
            // 
            this.thốngKêBàiViếtToolStripMenuItem.Name = "thốngKêBàiViếtToolStripMenuItem";
            this.thốngKêBàiViếtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thốngKêBàiViếtToolStripMenuItem.Text = "Thống kê bài viết";
            this.thốngKêBàiViếtToolStripMenuItem.Click += new System.EventHandler(this.thốngKêBàiViếtToolStripMenuItem_Click);
            // 
            // biểuĐồToolStripMenuItem
            // 
            this.biểuĐồToolStripMenuItem.Name = "biểuĐồToolStripMenuItem";
            this.biểuĐồToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.biểuĐồToolStripMenuItem.Text = "Biểu đồ";
            this.biểuĐồToolStripMenuItem.Click += new System.EventHandler(this.biểuĐồToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.panelContent = new System.Windows.Forms.Panel();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 422);
            this.panelContent.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnVịPhátHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBàiViếtToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
    }
}


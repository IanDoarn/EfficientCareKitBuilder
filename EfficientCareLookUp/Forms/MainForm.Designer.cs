namespace EfficientCareLookUp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ecluMainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainForTabControl = new System.Windows.Forms.TabControl();
            this.bundleTab = new System.Windows.Forms.TabPage();
            this.loosepieceTab = new System.Windows.Forms.TabPage();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecluMainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainForTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecluMainPanel
            // 
            this.ecluMainPanel.Controls.Add(this.mainForTabControl);
            this.ecluMainPanel.Controls.Add(this.menuStrip1);
            this.ecluMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecluMainPanel.Location = new System.Drawing.Point(0, 0);
            this.ecluMainPanel.Name = "ecluMainPanel";
            this.ecluMainPanel.Size = new System.Drawing.Size(574, 343);
            this.ecluMainPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainForTabControl
            // 
            this.mainForTabControl.Controls.Add(this.bundleTab);
            this.mainForTabControl.Controls.Add(this.loosepieceTab);
            this.mainForTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainForTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainForTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainForTabControl.Name = "mainForTabControl";
            this.mainForTabControl.SelectedIndex = 0;
            this.mainForTabControl.Size = new System.Drawing.Size(574, 319);
            this.mainForTabControl.TabIndex = 1;
            // 
            // bundleTab
            // 
            this.bundleTab.Location = new System.Drawing.Point(4, 22);
            this.bundleTab.Name = "bundleTab";
            this.bundleTab.Padding = new System.Windows.Forms.Padding(3);
            this.bundleTab.Size = new System.Drawing.Size(566, 293);
            this.bundleTab.TabIndex = 0;
            this.bundleTab.Text = "Bundle Search";
            this.bundleTab.UseVisualStyleBackColor = true;
            // 
            // loosepieceTab
            // 
            this.loosepieceTab.Location = new System.Drawing.Point(4, 22);
            this.loosepieceTab.Name = "loosepieceTab";
            this.loosepieceTab.Padding = new System.Windows.Forms.Padding(3);
            this.loosepieceTab.Size = new System.Drawing.Size(566, 293);
            this.loosepieceTab.TabIndex = 1;
            this.loosepieceTab.Text = "Loose Piece Search";
            this.loosepieceTab.UseVisualStyleBackColor = true;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 343);
            this.Controls.Add(this.ecluMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Efficient Care Kit Builder";
            this.ecluMainPanel.ResumeLayout(false);
            this.ecluMainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainForTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ecluMainPanel;
        private System.Windows.Forms.TabControl mainForTabControl;
        private System.Windows.Forms.TabPage bundleTab;
        private System.Windows.Forms.TabPage loosepieceTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
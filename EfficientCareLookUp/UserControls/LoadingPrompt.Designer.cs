namespace EfficientCareLookUp.UserControls
{
    partial class LoadingPrompt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadingPromptPanel = new System.Windows.Forms.Panel();
            this.loadingPromptTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.loadingPromptPanel.SuspendLayout();
            this.loadingPromptTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingPromptPanel
            // 
            this.loadingPromptPanel.Controls.Add(this.loadingPromptTableLayoutPanel);
            this.loadingPromptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPromptPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPromptPanel.Name = "loadingPromptPanel";
            this.loadingPromptPanel.Size = new System.Drawing.Size(371, 60);
            this.loadingPromptPanel.TabIndex = 0;
            // 
            // loadingPromptTableLayoutPanel
            // 
            this.loadingPromptTableLayoutPanel.ColumnCount = 1;
            this.loadingPromptTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadingPromptTableLayoutPanel.Controls.Add(this.progressBar, 0, 0);
            this.loadingPromptTableLayoutPanel.Controls.Add(this.textBox, 0, 1);
            this.loadingPromptTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPromptTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPromptTableLayoutPanel.Name = "loadingPromptTableLayoutPanel";
            this.loadingPromptTableLayoutPanel.RowCount = 2;
            this.loadingPromptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.loadingPromptTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.loadingPromptTableLayoutPanel.Size = new System.Drawing.Size(371, 60);
            this.loadingPromptTableLayoutPanel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(365, 25);
            this.progressBar.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(3, 34);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(365, 20);
            this.textBox.TabIndex = 1;
            // 
            // LoadingPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadingPromptPanel);
            this.Name = "LoadingPrompt";
            this.Size = new System.Drawing.Size(371, 60);
            this.loadingPromptPanel.ResumeLayout(false);
            this.loadingPromptTableLayoutPanel.ResumeLayout(false);
            this.loadingPromptTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loadingPromptPanel;
        private System.Windows.Forms.TableLayoutPanel loadingPromptTableLayoutPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox;
    }
}

namespace SimpleChat
{
    partial class serversideForm
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
            this.userBaseListBox = new System.Windows.Forms.ListBox();
            this.userListLabel = new System.Windows.Forms.Label();
            this.serverAppMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverAppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBaseListBox
            // 
            this.userBaseListBox.FormattingEnabled = true;
            this.userBaseListBox.Location = new System.Drawing.Point(12, 104);
            this.userBaseListBox.Name = "userBaseListBox";
            this.userBaseListBox.Size = new System.Drawing.Size(183, 381);
            this.userBaseListBox.TabIndex = 0;
            // 
            // userListLabel
            // 
            this.userListLabel.AutoSize = true;
            this.userListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userListLabel.Location = new System.Drawing.Point(12, 81);
            this.userListLabel.Name = "userListLabel";
            this.userListLabel.Size = new System.Drawing.Size(56, 20);
            this.userListLabel.TabIndex = 1;
            this.userListLabel.Text = "Users";
            // 
            // serverAppMenu
            // 
            this.serverAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.serverAppMenu.Location = new System.Drawing.Point(0, 0);
            this.serverAppMenu.Name = "serverAppMenu";
            this.serverAppMenu.Size = new System.Drawing.Size(626, 24);
            this.serverAppMenu.TabIndex = 2;
            this.serverAppMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serversideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 497);
            this.Controls.Add(this.userListLabel);
            this.Controls.Add(this.userBaseListBox);
            this.Controls.Add(this.serverAppMenu);
            this.MainMenuStrip = this.serverAppMenu;
            this.Name = "serversideForm";
            this.Text = "serversideForm";
            this.serverAppMenu.ResumeLayout(false);
            this.serverAppMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userBaseListBox;
        private System.Windows.Forms.Label userListLabel;
        private System.Windows.Forms.MenuStrip serverAppMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
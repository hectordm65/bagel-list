namespace Dominguez_Bagel_Lists
{
    partial class Bagels
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
            this.BagelmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countBagelTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BagelListBox = new System.Windows.Forms.ListBox();
            this.BagelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BagelTextBox = new System.Windows.Forms.TextBox();
            this.BagelmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BagelmenuStrip
            // 
            this.BagelmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.BagelmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.BagelmenuStrip.Name = "BagelmenuStrip";
            this.BagelmenuStrip.Size = new System.Drawing.Size(427, 24);
            this.BagelmenuStrip.TabIndex = 1;
            this.BagelmenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAndLoadToolStripMenuItem,
            this.openAndAddToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAndLoadToolStripMenuItem
            // 
            this.openAndLoadToolStripMenuItem.Name = "openAndLoadToolStripMenuItem";
            this.openAndLoadToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openAndLoadToolStripMenuItem.Text = "Open and Load";
            this.openAndLoadToolStripMenuItem.Click += new System.EventHandler(this.openAndLoadToolStripMenuItem_Click);
            // 
            // openAndAddToolStripMenuItem
            // 
            this.openAndAddToolStripMenuItem.Name = "openAndAddToolStripMenuItem";
            this.openAndAddToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openAndAddToolStripMenuItem.Text = "Open and Add";
            this.openAndAddToolStripMenuItem.Click += new System.EventHandler(this.openAndAddToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageListToolStripMenuItem
            // 
            this.manageListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBagelTypeToolStripMenuItem,
            this.removeBagelTypeToolStripMenuItem,
            this.countBagelTypesToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.manageListToolStripMenuItem.Name = "manageListToolStripMenuItem";
            this.manageListToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.manageListToolStripMenuItem.Text = "Manage List";
            // 
            // addBagelTypeToolStripMenuItem
            // 
            this.addBagelTypeToolStripMenuItem.Name = "addBagelTypeToolStripMenuItem";
            this.addBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addBagelTypeToolStripMenuItem.Text = "Add Bagel Type";
            this.addBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.addBagelTypeToolStripMenuItem_Click);
            // 
            // removeBagelTypeToolStripMenuItem
            // 
            this.removeBagelTypeToolStripMenuItem.Name = "removeBagelTypeToolStripMenuItem";
            this.removeBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.removeBagelTypeToolStripMenuItem.Text = "Remove Bagel Type";
            this.removeBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.removeBagelTypeToolStripMenuItem_Click);
            // 
            // countBagelTypesToolStripMenuItem
            // 
            this.countBagelTypesToolStripMenuItem.Name = "countBagelTypesToolStripMenuItem";
            this.countBagelTypesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.countBagelTypesToolStripMenuItem.Text = "Count Bagel Types";
            this.countBagelTypesToolStripMenuItem.Click += new System.EventHandler(this.countBagelTypesToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BagelListBox
            // 
            this.BagelListBox.FormattingEnabled = true;
            this.BagelListBox.HorizontalScrollbar = true;
            this.BagelListBox.Location = new System.Drawing.Point(37, 48);
            this.BagelListBox.Name = "BagelListBox";
            this.BagelListBox.Size = new System.Drawing.Size(120, 264);
            this.BagelListBox.Sorted = true;
            this.BagelListBox.TabIndex = 2;
            // 
            // BagelOpenFileDialog
            // 
            this.BagelOpenFileDialog.FileName = "openFileDialog1";
            // 
            // BagelTextBox
            // 
            this.BagelTextBox.Location = new System.Drawing.Point(245, 133);
            this.BagelTextBox.Name = "BagelTextBox";
            this.BagelTextBox.Size = new System.Drawing.Size(100, 20);
            this.BagelTextBox.TabIndex = 3;
            // 
            // Bagels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 413);
            this.Controls.Add(this.BagelTextBox);
            this.Controls.Add(this.BagelListBox);
            this.Controls.Add(this.BagelmenuStrip);
            this.MainMenuStrip = this.BagelmenuStrip;
            this.Name = "Bagels";
            this.Text = "Bagels";
            this.BagelmenuStrip.ResumeLayout(false);
            this.BagelmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BagelmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countBagelTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox BagelListBox;
        private System.Windows.Forms.OpenFileDialog BagelOpenFileDialog;
        private System.Windows.Forms.TextBox BagelTextBox;
    }
}


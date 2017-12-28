namespace Epidemic.Builder
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.tree = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbDismiss = new System.Windows.Forms.Panel();
            this.sbDelete = new System.Windows.Forms.Panel();
            this.sbRename = new System.Windows.Forms.Panel();
            this.sbDown = new System.Windows.Forms.Panel();
            this.sbUp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.ForeColor = System.Drawing.Color.White;
            this.tree.LineColor = System.Drawing.Color.White;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(319, 392);
            this.tree.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.sbDismiss);
            this.panel1.Controls.Add(this.sbDelete);
            this.panel1.Controls.Add(this.sbRename);
            this.panel1.Controls.Add(this.sbDown);
            this.panel1.Controls.Add(this.sbUp);
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 392);
            this.panel1.TabIndex = 1;
            // 
            // sbDismiss
            // 
            this.sbDismiss.BackColor = System.Drawing.Color.Maroon;
            this.sbDismiss.BackgroundImage = global::Epidemic.Builder.Properties.Resources.Ok;
            this.sbDismiss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbDismiss.Location = new System.Drawing.Point(4, 357);
            this.sbDismiss.Name = "sbDismiss";
            this.sbDismiss.Size = new System.Drawing.Size(58, 32);
            this.sbDismiss.TabIndex = 2;
            this.sbDismiss.Click += new System.EventHandler(this.sbDismiss_Click);
            // 
            // sbDelete
            // 
            this.sbDelete.BackColor = System.Drawing.Color.Maroon;
            this.sbDelete.BackgroundImage = global::Epidemic.Builder.Properties.Resources.Trash;
            this.sbDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbDelete.Location = new System.Drawing.Point(4, 195);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(58, 58);
            this.sbDelete.TabIndex = 1;
            // 
            // sbRename
            // 
            this.sbRename.BackColor = System.Drawing.Color.Maroon;
            this.sbRename.BackgroundImage = global::Epidemic.Builder.Properties.Resources.Rename;
            this.sbRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbRename.Location = new System.Drawing.Point(4, 131);
            this.sbRename.Name = "sbRename";
            this.sbRename.Size = new System.Drawing.Size(58, 58);
            this.sbRename.TabIndex = 1;
            // 
            // sbDown
            // 
            this.sbDown.BackColor = System.Drawing.Color.Maroon;
            this.sbDown.BackgroundImage = global::Epidemic.Builder.Properties.Resources.ArrowDown;
            this.sbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbDown.Location = new System.Drawing.Point(4, 67);
            this.sbDown.Name = "sbDown";
            this.sbDown.Size = new System.Drawing.Size(58, 58);
            this.sbDown.TabIndex = 1;
            this.sbDown.Click += new System.EventHandler(this.sbDown_Click);
            // 
            // sbUp
            // 
            this.sbUp.BackColor = System.Drawing.Color.Maroon;
            this.sbUp.BackgroundImage = global::Epidemic.Builder.Properties.Resources.ArrowUp;
            this.sbUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbUp.Location = new System.Drawing.Point(4, 3);
            this.sbUp.Name = "sbUp";
            this.sbUp.Size = new System.Drawing.Size(58, 58);
            this.sbUp.TabIndex = 0;
            this.sbUp.Click += new System.EventHandler(this.sbUp_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(390, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sbDismiss;
        private System.Windows.Forms.Panel sbDelete;
        private System.Windows.Forms.Panel sbRename;
        private System.Windows.Forms.Panel sbDown;
        private System.Windows.Forms.Panel sbUp;
    }
}
namespace Epidemic.Runtime
{
    partial class Console
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
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleTopBar = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.warnings = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Panel();
            this.informationLabel = new System.Windows.Forms.Label();
            this.consoleTopBar.SuspendLayout();
            this.warnings.SuspendLayout();
            this.information.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 24);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(440, 197);
            this.consoleTextBox.TabIndex = 0;
            // 
            // consoleTopBar
            // 
            this.consoleTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.consoleTopBar.Controls.Add(this.errorLabel);
            this.consoleTopBar.Controls.Add(this.warnings);
            this.consoleTopBar.Controls.Add(this.information);
            this.consoleTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleTopBar.Location = new System.Drawing.Point(0, 0);
            this.consoleTopBar.Name = "consoleTopBar";
            this.consoleTopBar.Size = new System.Drawing.Size(440, 24);
            this.consoleTopBar.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(206, 4);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(16, 17);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "0";
            // 
            // warnings
            // 
            this.warnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.warnings.Controls.Add(this.warningLabel);
            this.warnings.Dock = System.Windows.Forms.DockStyle.Left;
            this.warnings.Location = new System.Drawing.Point(100, 0);
            this.warnings.Name = "warnings";
            this.warnings.Size = new System.Drawing.Size(100, 24);
            this.warnings.TabIndex = 1;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.ForeColor = System.Drawing.Color.White;
            this.warningLabel.Location = new System.Drawing.Point(6, 4);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(16, 17);
            this.warningLabel.TabIndex = 1;
            this.warningLabel.Text = "0";
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(128)))));
            this.information.Controls.Add(this.informationLabel);
            this.information.Dock = System.Windows.Forms.DockStyle.Left;
            this.information.Location = new System.Drawing.Point(0, 0);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(100, 24);
            this.information.TabIndex = 0;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.BackColor = System.Drawing.Color.Transparent;
            this.informationLabel.ForeColor = System.Drawing.Color.White;
            this.informationLabel.Location = new System.Drawing.Point(4, 4);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(16, 17);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "0";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.consoleTopBar);
            this.Controls.Add(this.consoleTextBox);
            this.Name = "Console";
            this.Size = new System.Drawing.Size(440, 221);
            this.consoleTopBar.ResumeLayout(false);
            this.consoleTopBar.PerformLayout();
            this.warnings.ResumeLayout(false);
            this.warnings.PerformLayout();
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Panel consoleTopBar;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel warnings;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Panel information;
        private System.Windows.Forms.Label informationLabel;
    }
}

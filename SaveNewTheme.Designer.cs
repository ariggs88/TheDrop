namespace TheDrop
{
    partial class SaveNewTheme
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
            this.txtBoxNewTheme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNewTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNewTheme
            // 
            this.txtBoxNewTheme.Location = new System.Drawing.Point(112, 12);
            this.txtBoxNewTheme.Name = "txtBoxNewTheme";
            this.txtBoxNewTheme.Size = new System.Drawing.Size(230, 20);
            this.txtBoxNewTheme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Your Theme";
            // 
            // btnSaveNewTheme
            // 
            this.btnSaveNewTheme.Location = new System.Drawing.Point(207, 39);
            this.btnSaveNewTheme.Name = "btnSaveNewTheme";
            this.btnSaveNewTheme.Size = new System.Drawing.Size(135, 23);
            this.btnSaveNewTheme.TabIndex = 2;
            this.btnSaveNewTheme.Text = "Save Theme";
            this.btnSaveNewTheme.UseVisualStyleBackColor = true;
            this.btnSaveNewTheme.Click += new System.EventHandler(this.btnSaveNewTheme_Click);
            // 
            // SaveNewTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 75);
            this.Controls.Add(this.btnSaveNewTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNewTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaveNewTheme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save New Theme";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNewTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNewTheme;
    }
}
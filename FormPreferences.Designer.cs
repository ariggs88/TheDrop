namespace TheDrop
{
    partial class FormPreferences
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLeftPane = new System.Windows.Forms.TabPage();
            this.btnBackColorLeftPane = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFontColorLeftPane = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFontLeftPane = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLeftPaneExampleTxt = new System.Windows.Forms.Label();
            this.lblLeftPaneHeader = new System.Windows.Forms.Label();
            this.tabDropArea = new System.Windows.Forms.TabPage();
            this.btnDropAreaIconBackColor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTransparent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDropAreaFontColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDropAreaExampleTxt = new System.Windows.Forms.Label();
            this.btnDropAreaBackImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDropAreaBackColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDropAreaHeader = new System.Windows.Forms.Label();
            this.btnDropAreaChangeFont = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabClock = new System.Windows.Forms.TabPage();
            this.btnClockFontColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClockExampleTxt = new System.Windows.Forms.Label();
            this.btnClockChangeBackColor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblClockPreferencesHeader = new System.Windows.Forms.Label();
            this.btnClockChangeFont = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialogP = new System.Windows.Forms.OpenFileDialog();
            this.fontDialogP = new System.Windows.Forms.FontDialog();
            this.colorDialogP = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabLeftPane.SuspendLayout();
            this.tabDropArea.SuspendLayout();
            this.tabClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabLeftPane);
            this.tabControl1.Controls.Add(this.tabDropArea);
            this.tabControl1.Controls.Add(this.tabClock);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLeftPane
            // 
            this.tabLeftPane.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.tabLeftPane.AutoScroll = true;
            this.tabLeftPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabLeftPane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabLeftPane.Controls.Add(this.btnBackColorLeftPane);
            this.tabLeftPane.Controls.Add(this.label4);
            this.tabLeftPane.Controls.Add(this.btnFontColorLeftPane);
            this.tabLeftPane.Controls.Add(this.label3);
            this.tabLeftPane.Controls.Add(this.btnFontLeftPane);
            this.tabLeftPane.Controls.Add(this.label2);
            this.tabLeftPane.Controls.Add(this.lblLeftPaneExampleTxt);
            this.tabLeftPane.Controls.Add(this.lblLeftPaneHeader);
            this.tabLeftPane.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabLeftPane.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLeftPane.ForeColor = System.Drawing.Color.Lime;
            this.tabLeftPane.Location = new System.Drawing.Point(4, 34);
            this.tabLeftPane.Name = "tabLeftPane";
            this.tabLeftPane.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeftPane.Size = new System.Drawing.Size(531, 591);
            this.tabLeftPane.TabIndex = 0;
            this.tabLeftPane.Text = "Left Pane ";
            // 
            // btnBackColorLeftPane
            // 
            this.btnBackColorLeftPane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackColorLeftPane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackColorLeftPane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackColorLeftPane.ForeColor = System.Drawing.Color.Black;
            this.btnBackColorLeftPane.Location = new System.Drawing.Point(43, 301);
            this.btnBackColorLeftPane.Name = "btnBackColorLeftPane";
            this.btnBackColorLeftPane.Size = new System.Drawing.Size(153, 39);
            this.btnBackColorLeftPane.TabIndex = 7;
            this.btnBackColorLeftPane.Text = "Change Color";
            this.btnBackColorLeftPane.UseVisualStyleBackColor = false;
            this.btnBackColorLeftPane.Click += new System.EventHandler(this.btnBackColorLeftPane_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change Back Color";
            // 
            // btnFontColorLeftPane
            // 
            this.btnFontColorLeftPane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFontColorLeftPane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFontColorLeftPane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFontColorLeftPane.ForeColor = System.Drawing.Color.Black;
            this.btnFontColorLeftPane.Location = new System.Drawing.Point(43, 212);
            this.btnFontColorLeftPane.Name = "btnFontColorLeftPane";
            this.btnFontColorLeftPane.Size = new System.Drawing.Size(153, 39);
            this.btnFontColorLeftPane.TabIndex = 5;
            this.btnFontColorLeftPane.Text = "Change Color";
            this.btnFontColorLeftPane.UseVisualStyleBackColor = false;
            this.btnFontColorLeftPane.Click += new System.EventHandler(this.btnFontColorLeftPane_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change Font Color";
            // 
            // btnFontLeftPane
            // 
            this.btnFontLeftPane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFontLeftPane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFontLeftPane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFontLeftPane.ForeColor = System.Drawing.Color.Black;
            this.btnFontLeftPane.Location = new System.Drawing.Point(43, 125);
            this.btnFontLeftPane.Name = "btnFontLeftPane";
            this.btnFontLeftPane.Size = new System.Drawing.Size(153, 39);
            this.btnFontLeftPane.TabIndex = 3;
            this.btnFontLeftPane.Text = "Change Font";
            this.btnFontLeftPane.UseVisualStyleBackColor = false;
            this.btnFontLeftPane.Click += new System.EventHandler(this.btnFontLeftPane_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Font, Style and Size";
            // 
            // lblLeftPaneExampleTxt
            // 
            this.lblLeftPaneExampleTxt.AutoSize = true;
            this.lblLeftPaneExampleTxt.Location = new System.Drawing.Point(39, 418);
            this.lblLeftPaneExampleTxt.Name = "lblLeftPaneExampleTxt";
            this.lblLeftPaneExampleTxt.Size = new System.Drawing.Size(130, 22);
            this.lblLeftPaneExampleTxt.TabIndex = 1;
            this.lblLeftPaneExampleTxt.Text = "Example Text";
            // 
            // lblLeftPaneHeader
            // 
            this.lblLeftPaneHeader.AutoSize = true;
            this.lblLeftPaneHeader.BackColor = System.Drawing.Color.Black;
            this.lblLeftPaneHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeftPaneHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblLeftPaneHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLeftPaneHeader.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftPaneHeader.Location = new System.Drawing.Point(145, 34);
            this.lblLeftPaneHeader.Name = "lblLeftPaneHeader";
            this.lblLeftPaneHeader.Size = new System.Drawing.Size(234, 29);
            this.lblLeftPaneHeader.TabIndex = 0;
            this.lblLeftPaneHeader.Text = "Left Pane Preferences";
            // 
            // tabDropArea
            // 
            this.tabDropArea.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.tabDropArea.AutoScroll = true;
            this.tabDropArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabDropArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDropArea.Controls.Add(this.btnDropAreaIconBackColor);
            this.tabDropArea.Controls.Add(this.label10);
            this.tabDropArea.Controls.Add(this.btnTransparent);
            this.tabDropArea.Controls.Add(this.label8);
            this.tabDropArea.Controls.Add(this.btnDropAreaFontColor);
            this.tabDropArea.Controls.Add(this.label1);
            this.tabDropArea.Controls.Add(this.lblDropAreaExampleTxt);
            this.tabDropArea.Controls.Add(this.btnDropAreaBackImage);
            this.tabDropArea.Controls.Add(this.label7);
            this.tabDropArea.Controls.Add(this.btnDropAreaBackColor);
            this.tabDropArea.Controls.Add(this.label6);
            this.tabDropArea.Controls.Add(this.lblDropAreaHeader);
            this.tabDropArea.Controls.Add(this.btnDropAreaChangeFont);
            this.tabDropArea.Controls.Add(this.label5);
            this.tabDropArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDropArea.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDropArea.ForeColor = System.Drawing.Color.Lime;
            this.tabDropArea.Location = new System.Drawing.Point(4, 34);
            this.tabDropArea.Name = "tabDropArea";
            this.tabDropArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabDropArea.Size = new System.Drawing.Size(531, 591);
            this.tabDropArea.TabIndex = 1;
            this.tabDropArea.Text = "Drop Area";
            // 
            // btnDropAreaIconBackColor
            // 
            this.btnDropAreaIconBackColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDropAreaIconBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropAreaIconBackColor.Enabled = false;
            this.btnDropAreaIconBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDropAreaIconBackColor.ForeColor = System.Drawing.Color.Black;
            this.btnDropAreaIconBackColor.Location = new System.Drawing.Point(319, 144);
            this.btnDropAreaIconBackColor.Name = "btnDropAreaIconBackColor";
            this.btnDropAreaIconBackColor.Size = new System.Drawing.Size(153, 39);
            this.btnDropAreaIconBackColor.TabIndex = 17;
            this.btnDropAreaIconBackColor.Text = "Change Color";
            this.btnDropAreaIconBackColor.UseVisualStyleBackColor = false;
            this.btnDropAreaIconBackColor.Click += new System.EventHandler(this.btnDropAreaIconBackColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(322, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 36);
            this.label10.TabIndex = 16;
            this.label10.Text = "Change Highlighted\r\nBack Color for Icons";
            // 
            // btnTransparent
            // 
            this.btnTransparent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransparent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransparent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransparent.ForeColor = System.Drawing.Color.Black;
            this.btnTransparent.Location = new System.Drawing.Point(319, 245);
            this.btnTransparent.Name = "btnTransparent";
            this.btnTransparent.Size = new System.Drawing.Size(153, 39);
            this.btnTransparent.TabIndex = 15;
            this.btnTransparent.Text = "Transparent";
            this.btnTransparent.UseVisualStyleBackColor = false;
            this.btnTransparent.Click += new System.EventHandler(this.btnTransparent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Click here to make Font \r\nBack Color Transparent";
            // 
            // btnDropAreaFontColor
            // 
            this.btnDropAreaFontColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDropAreaFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropAreaFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDropAreaFontColor.ForeColor = System.Drawing.Color.Black;
            this.btnDropAreaFontColor.Location = new System.Drawing.Point(43, 301);
            this.btnDropAreaFontColor.Name = "btnDropAreaFontColor";
            this.btnDropAreaFontColor.Size = new System.Drawing.Size(153, 39);
            this.btnDropAreaFontColor.TabIndex = 13;
            this.btnDropAreaFontColor.Text = "Change Color";
            this.btnDropAreaFontColor.UseVisualStyleBackColor = false;
            this.btnDropAreaFontColor.Click += new System.EventHandler(this.btnDropAreaFontColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Font Color";
            // 
            // lblDropAreaExampleTxt
            // 
            this.lblDropAreaExampleTxt.AutoSize = true;
            this.lblDropAreaExampleTxt.Location = new System.Drawing.Point(39, 494);
            this.lblDropAreaExampleTxt.Name = "lblDropAreaExampleTxt";
            this.lblDropAreaExampleTxt.Size = new System.Drawing.Size(130, 22);
            this.lblDropAreaExampleTxt.TabIndex = 11;
            this.lblDropAreaExampleTxt.Text = "Example Text";
            // 
            // btnDropAreaBackImage
            // 
            this.btnDropAreaBackImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDropAreaBackImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropAreaBackImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDropAreaBackImage.ForeColor = System.Drawing.Color.Black;
            this.btnDropAreaBackImage.Location = new System.Drawing.Point(43, 394);
            this.btnDropAreaBackImage.Name = "btnDropAreaBackImage";
            this.btnDropAreaBackImage.Size = new System.Drawing.Size(153, 39);
            this.btnDropAreaBackImage.TabIndex = 10;
            this.btnDropAreaBackImage.Text = "Change Image";
            this.btnDropAreaBackImage.UseVisualStyleBackColor = false;
            this.btnDropAreaBackImage.Click += new System.EventHandler(this.btnDropAreaBackImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Change Background Image";
            // 
            // btnDropAreaBackColor
            // 
            this.btnDropAreaBackColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDropAreaBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropAreaBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDropAreaBackColor.ForeColor = System.Drawing.Color.Black;
            this.btnDropAreaBackColor.Location = new System.Drawing.Point(43, 210);
            this.btnDropAreaBackColor.Name = "btnDropAreaBackColor";
            this.btnDropAreaBackColor.Size = new System.Drawing.Size(153, 39);
            this.btnDropAreaBackColor.TabIndex = 8;
            this.btnDropAreaBackColor.Text = "Change Color";
            this.btnDropAreaBackColor.UseVisualStyleBackColor = false;
            this.btnDropAreaBackColor.Click += new System.EventHandler(this.btnDropAreaBackColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Change Background Color";
            // 
            // lblDropAreaHeader
            // 
            this.lblDropAreaHeader.AutoSize = true;
            this.lblDropAreaHeader.BackColor = System.Drawing.Color.Black;
            this.lblDropAreaHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDropAreaHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDropAreaHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDropAreaHeader.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropAreaHeader.Location = new System.Drawing.Point(143, 34);
            this.lblDropAreaHeader.Name = "lblDropAreaHeader";
            this.lblDropAreaHeader.Size = new System.Drawing.Size(242, 29);
            this.lblDropAreaHeader.TabIndex = 6;
            this.lblDropAreaHeader.Text = "Drop Area Preferences";
            // 
            // btnDropAreaChangeFont
            // 
            this.btnDropAreaChangeFont.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDropAreaChangeFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropAreaChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDropAreaChangeFont.ForeColor = System.Drawing.Color.Black;
            this.btnDropAreaChangeFont.Location = new System.Drawing.Point(43, 123);
            this.btnDropAreaChangeFont.Name = "btnDropAreaChangeFont";
            this.btnDropAreaChangeFont.Size = new System.Drawing.Size(153, 39);
            this.btnDropAreaChangeFont.TabIndex = 5;
            this.btnDropAreaChangeFont.Text = "Change Font";
            this.btnDropAreaChangeFont.UseVisualStyleBackColor = false;
            this.btnDropAreaChangeFont.Click += new System.EventHandler(this.btnDropAreaChangeFont_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Font, Style and Size";
            // 
            // tabClock
            // 
            this.tabClock.AccessibleRole = System.Windows.Forms.AccessibleRole.PropertyPage;
            this.tabClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabClock.Controls.Add(this.btnClockFontColor);
            this.tabClock.Controls.Add(this.label9);
            this.tabClock.Controls.Add(this.lblClockExampleTxt);
            this.tabClock.Controls.Add(this.btnClockChangeBackColor);
            this.tabClock.Controls.Add(this.label11);
            this.tabClock.Controls.Add(this.lblClockPreferencesHeader);
            this.tabClock.Controls.Add(this.btnClockChangeFont);
            this.tabClock.Controls.Add(this.label13);
            this.tabClock.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClock.ForeColor = System.Drawing.Color.Lime;
            this.tabClock.Location = new System.Drawing.Point(4, 34);
            this.tabClock.Name = "tabClock";
            this.tabClock.Size = new System.Drawing.Size(531, 591);
            this.tabClock.TabIndex = 2;
            this.tabClock.Text = "Clock";
            // 
            // btnClockFontColor
            // 
            this.btnClockFontColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClockFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClockFontColor.ForeColor = System.Drawing.Color.Black;
            this.btnClockFontColor.Location = new System.Drawing.Point(45, 212);
            this.btnClockFontColor.Name = "btnClockFontColor";
            this.btnClockFontColor.Size = new System.Drawing.Size(153, 39);
            this.btnClockFontColor.TabIndex = 21;
            this.btnClockFontColor.Text = "Change Color";
            this.btnClockFontColor.UseVisualStyleBackColor = false;
            this.btnClockFontColor.Click += new System.EventHandler(this.btnClockFontColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Change Font Color";
            // 
            // lblClockExampleTxt
            // 
            this.lblClockExampleTxt.AutoSize = true;
            this.lblClockExampleTxt.Location = new System.Drawing.Point(41, 408);
            this.lblClockExampleTxt.Name = "lblClockExampleTxt";
            this.lblClockExampleTxt.Size = new System.Drawing.Size(130, 22);
            this.lblClockExampleTxt.TabIndex = 19;
            this.lblClockExampleTxt.Text = "Example Text";
            // 
            // btnClockChangeBackColor
            // 
            this.btnClockChangeBackColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClockChangeBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockChangeBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClockChangeBackColor.ForeColor = System.Drawing.Color.Black;
            this.btnClockChangeBackColor.Location = new System.Drawing.Point(45, 303);
            this.btnClockChangeBackColor.Name = "btnClockChangeBackColor";
            this.btnClockChangeBackColor.Size = new System.Drawing.Size(153, 39);
            this.btnClockChangeBackColor.TabIndex = 16;
            this.btnClockChangeBackColor.Text = "Change Color";
            this.btnClockChangeBackColor.UseVisualStyleBackColor = false;
            this.btnClockChangeBackColor.Click += new System.EventHandler(this.btnClockChangeBackColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Change Back Color";
            // 
            // lblClockPreferencesHeader
            // 
            this.lblClockPreferencesHeader.AutoSize = true;
            this.lblClockPreferencesHeader.BackColor = System.Drawing.Color.Black;
            this.lblClockPreferencesHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClockPreferencesHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblClockPreferencesHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClockPreferencesHeader.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockPreferencesHeader.Location = new System.Drawing.Point(168, 36);
            this.lblClockPreferencesHeader.Name = "lblClockPreferencesHeader";
            this.lblClockPreferencesHeader.Size = new System.Drawing.Size(195, 29);
            this.lblClockPreferencesHeader.TabIndex = 14;
            this.lblClockPreferencesHeader.Text = "Clock Preferences";
            // 
            // btnClockChangeFont
            // 
            this.btnClockChangeFont.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClockChangeFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClockChangeFont.ForeColor = System.Drawing.Color.Black;
            this.btnClockChangeFont.Location = new System.Drawing.Point(45, 125);
            this.btnClockChangeFont.Name = "btnClockChangeFont";
            this.btnClockChangeFont.Size = new System.Drawing.Size(153, 39);
            this.btnClockChangeFont.TabIndex = 13;
            this.btnClockChangeFont.Text = "Change Font";
            this.btnClockChangeFont.UseVisualStyleBackColor = false;
            this.btnClockChangeFont.Click += new System.EventHandler(this.btnClockChangeFont_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Choose Font, Style and Size";
            // 
            // openFileDialogP
            // 
            this.openFileDialogP.FileName = "openFileDialog1";
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(539, 629);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPreferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreferences_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabLeftPane.ResumeLayout(false);
            this.tabLeftPane.PerformLayout();
            this.tabDropArea.ResumeLayout(false);
            this.tabDropArea.PerformLayout();
            this.tabClock.ResumeLayout(false);
            this.tabClock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLeftPane;
        private System.Windows.Forms.TabPage tabDropArea;
        private System.Windows.Forms.TabPage tabClock;
        private System.Windows.Forms.Button btnBackColorLeftPane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFontColorLeftPane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFontLeftPane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeftPaneExampleTxt;
        private System.Windows.Forms.Label lblLeftPaneHeader;
        private System.Windows.Forms.Label lblDropAreaExampleTxt;
        private System.Windows.Forms.Button btnDropAreaBackImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDropAreaBackColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDropAreaHeader;
        private System.Windows.Forms.Button btnDropAreaChangeFont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClockExampleTxt;
        private System.Windows.Forms.Button btnClockChangeBackColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblClockPreferencesHeader;
        private System.Windows.Forms.Button btnClockChangeFont;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialogP;
        private System.Windows.Forms.FontDialog fontDialogP;
        private System.Windows.Forms.ColorDialog colorDialogP;
        private System.Windows.Forms.Button btnTransparent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDropAreaFontColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClockFontColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDropAreaIconBackColor;
        private System.Windows.Forms.Label label10;
    }
}
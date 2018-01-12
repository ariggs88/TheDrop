using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDrop
{
    public partial class FormPreferences : Form
    {
        public FormPreferences()
        {
            InitializeComponent();
        }

        private void btnFontLeftPane_Click(object sender, EventArgs e)
        {
            if(fontDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblLeftPaneExampleTxt.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                fontDialogP.Dispose();
            }
            fontDialogP.Dispose();
            return;
        }

        private void btnFontColorLeftPane_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblLeftPaneExampleTxt.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnBackColorLeftPane_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.BackColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).treeView1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnDropAreaChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblDropAreaExampleTxt.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                fontDialogP.Dispose();
            }
            fontDialogP.Dispose();
            return;
        }
        public Color fBackColor;
    
        private void btnDropAreaBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    try
                    {
                        lblDropAreaExampleTxt.BackColor = colorDialogP.Color;
                       fBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.BackColor = colorDialogP.Color;
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.BackgroundImage = null;
                       (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Refresh();
                    }catch(ArgumentException ae)
                    {
                        MessageBox.Show("Error: " + ae.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnDropAreaBackImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.BackgroundImage = Image.FromFile(openFileDialogP.FileName);
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnDropAreaFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblDropAreaExampleTxt.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnTransparent_Click(object sender, EventArgs e)
        {
            lblDropAreaExampleTxt.BackColor = System.Drawing.Color.Transparent;
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).flowLayoutPanel1.Refresh();
            }
        }
        //CLOCK
        private void btnClockChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblClockExampleTxt.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.Font = fontDialogP.Font;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                fontDialogP.Dispose();
            }
            fontDialogP.Dispose();
            return;
        }

        private void btnClockChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblClockExampleTxt.BackColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.BackColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        private void btnClockFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialogP.ShowDialog() == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    lblClockExampleTxt.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.ForeColor = colorDialogP.Color;
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).lblClock.Refresh();
                }
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                colorDialogP.Dispose();
            }
            colorDialogP.Dispose();
            return;
        }

        public void btnDropAreaIconBackColor_Click(object sender, EventArgs e)
        {
 
        }

        private void FormPreferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            this.Close();
            return;
        }
    }
}

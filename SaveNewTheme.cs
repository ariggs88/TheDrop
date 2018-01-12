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
    public partial class SaveNewTheme : Form
    {

        ToolStripMenuItem item = new ToolStripMenuItem();
        public int count;

        public SaveNewTheme()
        {
            InitializeComponent();
        }

        private void btnSaveNewTheme_Click(object sender, EventArgs e)
        {

            Form1 fm1 = new Form1();
            MessageBox.Show("This will save as your current theme.  No need to click save current theme.  This will also add your theme to the theme drop down menu!", "Saving Your New Theme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(count == 0)
            {
                count = 1;
            }
            int countedItems = fm1.themeToolStripMenuItem.DropDownItems.Count;

            for (int i = 0; i < countedItems; i++)
            {
                item = new ToolStripMenuItem();
                item.Name = txtBoxNewTheme.Text + "_" + i;

                item.Size = DefaultSize;
                item.Text = txtBoxNewTheme.Text;
                item.Click += new EventHandler(MenuItemClickHandler);

            }
            count++;
            fm1.themeToolStripMenuItem.DropDownItems.Add(item);

            fm1.lblClockBackColor = fm1.lblClock.BackColor;
            fm1.lblClockForeColor = fm1.lblClock.ForeColor;
            fm1.lbl1ForeColor = fm1.label1.ForeColor;
            fm1.lbl1BackColor = fm1.label1.BackColor;
            fm1.flowLayoutPanelBackColor = fm1.flowLayoutPanel1.BackColor;
            fm1.menuStripBackColor = fm1.menuStrip1.BackColor;
            fm1.menuStripForeColor = fm1.menuStrip1.ForeColor;
            fm1.programsDropDownForeColor = fm1.programsToolStripMenuItem.ForeColor;
            fm1.programDropDownBackColor = fm1.programsToolStripMenuItem.BackColor;
            fm1.editDropDownBackColor = fm1.editToolStripMenuItem.BackColor;
            fm1.editDropDownForeColor = fm1.editToolStripMenuItem.ForeColor;
            fm1.slitContainerBackColor = fm1.splitContainer1.BackColor;
            fm1.fileDropDownBackColor = fm1.fileToolStripMenuItem.BackColor;
            fm1.fileDropDownForeColor = fm1.fileToolStripMenuItem.ForeColor;
            fm1.treeViewBackColor = fm1.treeView1.BackColor;
            fm1.treeViewForeColor = fm1.treeView1.ForeColor;


            Properties.Settings.Default.lbClockBColor = fm1.lblClock.BackColor;
            Properties.Settings.Default.lblClockFColor = fm1.lblClock.ForeColor;
            Properties.Settings.Default.label1 = fm1.label1.ForeColor;
            Properties.Settings.Default.label1BColor = fm1.label1.BackColor;
            Properties.Settings.Default.flowLayoutPanel1 = fm1.flowLayoutPanel1.BackColor;
            Properties.Settings.Default.menuStrip1 = fm1.menuStrip1.BackColor;
            Properties.Settings.Default.msFColor = fm1.menuStrip1.ForeColor;
            Properties.Settings.Default.programsToolStripDropFColor = fm1.programsToolStripMenuItem.ForeColor;
            Properties.Settings.Default.programsToolStripMenuItem = fm1.programsToolStripMenuItem.BackColor;
            Properties.Settings.Default.editToolStripDropFColor = fm1.editToolStripMenuItem.ForeColor;
            Properties.Settings.Default.editToolStripMenuItem = fm1.editToolStripMenuItem.BackColor;
            Properties.Settings.Default.splitContainer1 = fm1.splitContainer1.BackColor;
            Properties.Settings.Default.fileToolStripDropFColor = fm1.fileToolStripMenuItem.ForeColor;
            Properties.Settings.Default.fileToolStripMenuItem = fm1.fileToolStripMenuItem.BackColor;
            Properties.Settings.Default.treeView1 = fm1.treeView1.BackColor;
            Properties.Settings.Default.treeView1FColor = fm1.treeView1.ForeColor;
            if (fm1.lastBackImg == null)
            {
                Properties.Settings.Default.lastImgPath = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropBackGround.jpg";
            }
            else
            {
                Properties.Settings.Default.lastImgPath = fm1.lastBackImg;
            }
            Properties.Settings.Default.splitContainerSize = fm1.splitContainer1.Panel2.Width;




            Properties.Settings.Default.Save();
            this.Close();
            return;
        }


        public void MenuItemClickHandler(object sender, EventArgs e)
        {
           
/*
            //fm1.flowLayoutPanel1.BackColor = ;
            fm1.treeView1.BackColor = Color.White;
            fm1.treeView1.ForeColor = Color.Black;
            fm1.lblClock.ForeColor = Color.Black;
            fm1.lblClock.BackColor = Color.White;
            fm1.splitContainer1.BackColor = Color.Silver;
            fm1.menuStrip1.BackColor = Color.Silver;
            fm1.menuStrip1.ForeColor = Color.Black;
            fm1.fileToolStripMenuItem.DropDown.BackColor = Color.Silver;  //change these to right color
            fm1.fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fm1.editToolStripMenuItem.DropDown.BackColor = Color.Silver;
            fm1.editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fm1.programsToolStripMenuItem.DropDown.BackColor = Color.Silver;
            fm1.programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fm1.label1.ForeColor = Color.Black;
            fm1.label1.BackColor = Color.Silver;
            fm1.lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropBackGround.jpg";
            fm1.flowLayoutPanel1.BackgroundImage = Image.FromFile(fm1.lastBackImg);*/
        }
    }
}


//figure out how to save new settings to new theme and create DYNAMIC theme drop down!!!
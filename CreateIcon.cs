using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using static TheDrop.Form1;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace TheDrop
{

    class Win32
    {
        SHFILEINFO shinfo = new SHFILEINFO();
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
        public const uint SHGFI_SMALLICON = 0x1; // 'Small icon

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
    }



    public class CreateIcon
    {
        Process myProcess = new Process();
        Form1 fm1 = new Form1();
        private SHFILEINFO shinfo;

        public void Pic_MouseEnter(object sender, EventArgs e)
        {

            PictureBox picBox_active = sender as PictureBox;
            Cursor Cursor = Cursors.Hand;
            if (fm1.lightTheme == true)
            {
                picBox_active.BackColor = Color.DodgerBlue;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if (fm1.blueTheme == true)
            {
                picBox_active.BackColor = Color.LightBlue;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if (fm1.yellowTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Yellow;
            }
            else if (fm1.orangeTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Orange;
            }
            else if (fm1.greenTheme == true)
            {
                picBox_active.BackColor = Color.LightGreen;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if (fm1.redTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Red;
            }
            else if (fm1.darkTheme == true)
            {
                picBox_active.BackColor = Color.Lime;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;


            }
            else if (fm1.purpleTheme == true)
            {
                picBox_active.BackColor = Color.White;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Purple;
            }
            else
            {


            }

        }

        public void Pic_MouseHover(object sender, EventArgs e)
        {
            PictureBox picBox_active = sender as PictureBox;
            Cursor Cursor = Cursors.Hand;
        }

        public void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox_active = sender as PictureBox;
            picBox_active.BackColor = Color.Transparent;
            Cursor Cursor = Cursors.Arrow;

            if (fm1.lightTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.DarkBlue;
                }


            }
            else if (fm1.blueTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.White;
                }
            }
            else if (fm1.yellowTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (fm1.orangeTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (fm1.greenTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (fm1.redTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.White;
                }
            }
            else if (fm1.darkTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Lime;
                }

            }
            else if (fm1.purpleTheme == true)
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.White;
                }
            }
            else
            {
                var controls = fm1.flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.DarkBlue;
                }

            }
        }
        public bool isFolder;
        private void Pic_DoubleClick(object sender, EventArgs e)
        {
            // Obtain via Tag
            String path_app = ((sender as PictureBox).Tag as String);

            myProcess.StartInfo.FileName = path_app;
            if (isFolder == true)
            {
                if (Directory.Exists(path_app))
                {
                    myProcess.Start();
                }
                else
                {

                    MessageBox.Show("This folder does not exist within The Drops file folder.  ", "Hey Human there is no folder here", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isFolder == false)
            {
                if (File.Exists(path_app))
                {
                    myProcess.Start();
                }
                else
                {
                    MessageBox.Show("This file does not exist within The Drops file folder.  ", "Hey Human there is no file here", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool mouseIsDown;
        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor Cursor = Cursors.Hand;
            mouseIsDown = true;
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                base.OnMouseDown(e);
                DoDragDrop(sender, DragDropEffects.Move);
                mouseIsDown = false;
            }
            return;
        }
        PictureBox pic = new PictureBox();
        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            pic = null;
            Cursor Cursor = Cursors.Default;

            return;
        }

        private void Pic_DragOver(object sender, DragEventArgs e)
        {
            base.OnDragOver(e);
            // is another dragable
            if (e.Data.GetData(typeof(PictureBox)) != null)
            {

                FlowLayoutPanel p = (FlowLayoutPanel)(sender as PictureBox).Parent;
                //Current Position             
                int myIndex = p.Controls.GetChildIndex((sender as PictureBox));

                //Dragged to control to location of next picturebox
                PictureBox q = (PictureBox)e.Data.GetData(typeof(PictureBox));
                p.Controls.SetChildIndex(q, myIndex);


            }
        }






        public void CreateIcons()
        {
        }

        public void CreateIcons(string path, Control flowPanel)
        {
            Form1 fm1 = new Form1();
            //get ICON
            var hImgLarge = Win32.SHGetFileInfo(path, 0,
            ref shinfo, (uint)Marshal.SizeOf(shinfo),
            Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);

            //The icon is returned in the hIcon member of the shinfo struct
            System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);

            //create label text  
            string name = Path.GetFileNameWithoutExtension(path);
            Label lb = new Label();
            Icon ico = Icon.ExtractAssociatedIcon(path);
            PictureBox pic = new PictureBox();
            pic.AllowDrop = true;
            if (fm1.fixedsingleborder == true)
            {
                pic.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (fm1.fixed3dborder == true)
            {
                pic.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (fm1.noborder == true)
            {
                pic.BorderStyle = BorderStyle.None;
            }
            int height = 85;
            int width = 90;
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.BackColor = Color.Transparent;
            pic.Height = height;
            pic.Width = width;
            pic.Location = new Point(0, 0);
            pic.Name = path;
            pic.Image = ico.ToBitmap();
            path = String.Format("{0}", path);
            pic.Tag = path;
            pic.ContextMenuStrip = fm1.contextMenuStrip1;

            pic.MouseDown += new MouseEventHandler(Pic_MouseDown);
            pic.MouseUp += new MouseEventHandler(Pic_MouseUp);
            pic.DragOver += new DragEventHandler(Pic_DragOver);

            pic.MouseHover += new EventHandler(this.Pic_MouseHover);
            pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
            pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
            pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);


            string newpath_app = Path.GetFileNameWithoutExtension(path);
            string f = Path.GetFileNameWithoutExtension(path);
            string fileNameNoExt = Path.GetFileNameWithoutExtension(path);

            Point p = new Point(0, 65);
            lb.Padding.All.Equals(10);
            lb.Margin.All.Equals(20);
            lb.Text = f;
            lb.Font.Bold.Equals(true);
            lb.Parent = pic;
            lb.BackColor = Color.Transparent;
            if (Properties.Settings.Default.piBoxLabelForeColor != null)
            {
                lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
            }
            else
            {
                lb.ForeColor = Color.Gray;
            }

            lb.BringToFront();
            lb.Location = p;

            flowPanel.Controls.Add(pic);


            // LOAD ALL FOLDERS!!!!!
            string[] folders = System.IO.Directory.GetDirectories(Environment.CurrentDirectory + @"\theDropFiles\", "*", System.IO.SearchOption.TopDirectoryOnly);
            foreach (var subdirs in folders)
            {
                string folderPath = subdirs;
                string lastFolderName = Path.GetFileName(folderPath.TrimEnd(Path.DirectorySeparatorChar));
                string fName = subdirs;
                //var hImgLarge;
                //Use this to get the small Icon
                // var hImgSmall = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                //Use this to get the large Icon
                var hImgLarge = Win32.SHGetFileInfo(fName, 0,
                ref shinfo, (uint)Marshal.SizeOf(shinfo),
                Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);

                //The icon is returned in the hIcon member of the shinfo struct
                System.Drawing.Icon myIco = System.Drawing.Icon.FromHandle(shinfo.hIcon);

              



                pic.AllowDrop = true;
                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);
                pic.MouseDown += new MouseEventHandler(this.Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(this.Pic_MouseUp);
                pic.DragOver += new DragEventHandler(this.Pic_DragOver);
                //path_app is a string for the filename.  
                path = String.Format("{0}", subdirs);
                // Add tag to each picturebox created with filename as the tag
                string path = lastFolderName;
                pic.Tag = path;

                //MODIFY the PICTUREBOX
                if (fm1.fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fm1.fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (fm1.noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                Point p = new Point(0, 65);
                pic.ContextMenuStrip = fm1.contextMenuStrip1; mijknb





                   \
]"                lb.Parent = pic;
                lb.BackColor = Color.Transparent;
                lb.BringToFront();
                lb.Location = p;
                pic.Name = fName;
                if (Properties.Settings.Default.piBoxLabelForeColor != null)
                {
                    lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
                }
                else
                {
                    lb.ForeColor = Color.Gray;  
                }
                flowPanel.Controls.Add(pic);

                try
                {
                    pic.Image = myIcon.ToBitmap();
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show("Error: " + ae.Message, "Couldn't find file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    




    

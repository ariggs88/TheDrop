using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleSearchApi;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using TheDrop.Properties;
using System.Threading;






namespace TheDrop
{
    public partial class Form1 : Form
    {
        public bool hideIsClicked = false;
        public bool showIsClicked = false;

        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        #region GLOBAL VARIABLES
        public bool normalWindowSize;
        public bool regularTime = false;
        public bool militaryTimeSelected = false;
        public bool showSeconds = false;
        public bool dontShowSeconds = false;
        public bool showShortDate = false;
        public bool showLongDate = false;
        public bool websitesAreOpen;
        public bool blueTheme, redTheme, purpleTheme, yellowTheme, lightTheme, darkTheme, greenTheme, orangeTheme;
        public bool fixed3dborder;
        public bool noborder;
        public bool fixedsingleborder;   //border functions add this.  <<<<<<<

        private static string PLACEHOLDER = "...";

        /*save new theme public variables*/
        public Color lblClockBackColor;
        public Color lblClockForeColor;
        public Color lbl1ForeColor;
        public Color lbl1BackColor;
        public Color flowLayoutPanelBackColor;
        public Color menuStripBackColor;
        public Color menuStripForeColor;
        public Color programsDropDownForeColor;
        public Color programDropDownBackColor;
        public Color editDropDownBackColor;
        public Color editDropDownForeColor;
        public Color slitContainerBackColor;
        public Color fileDropDownBackColor;
        public Color fileDropDownForeColor;
        public Color treeViewBackColor;
        public Color treeViewForeColor;

        public string backgroundImage;
        public int count;
        public string lastBackImg;

        #region CONSTRUCTORS
        public Form1(IContainer components, TreeView treeView1, SplitContainer splitContainer1, MenuStrip menuStrip1, ToolStripMenuItem fileToolStripMenuItem, ToolStripMenuItem aboutToolStripMenuItem, ToolStripMenuItem cLoseToolStripMenuItem, ToolStripMenuItem editToolStripMenuItem, ToolStripMenuItem changeFontColorToolStripMenuItem, ToolStripMenuItem changeBrowserBackColorToolStripMenuItem, ToolStripMenuItem programsToolStripMenuItem, ToolStripMenuItem addProgramToolStripMenuItem, ToolStripMenuItem deleteProgramToolStripMenuItem, ToolStripMenuItem changeFontToolStripMenuItem1, ToolStripMenuItem changeFontColorToolStripMenuItem1, ToolStripMenuItem changeBackColorToolStripMenuItem, ToolStripMenuItem changeFontToolStripMenuItem2, ToolStripMenuItem changeFontColorToolStripMenuItem2, ToolStripMenuItem changeBackColorToolStripMenuItem1, OpenFileDialog openFileDialog1, FontDialog leftPanelFontDialog, ColorDialog leftPanelColorDialog, Button btnGoogleSearch, TextBox txtBoxSearch, Label lblClock, ToolStripMenuItem changeBackgroundImageToolStripMenuItem, ToolStripMenuItem clockiToolStripMenuItem, ToolStripMenuItem appearanceToolStripMenuItem, ToolStripMenuItem addWebsiteToolStripMenuItem, ToolStripMenuItem changeBackColorToolStripMenuItem3, ToolStripMenuItem changeFontCOlorToolStripMenuItem4, ToolStripMenuItem changeFontToolStripMenuItem3, ToolStripMenuItem timeStyleToolStripMenuItem, ToolStripMenuItem showRegularTimeToolStripMenuItem1, ToolStripMenuItem showMilitaryTimeToolStripMenuItem1, ToolStripMenuItem showDateShortToolStripMenuItem, ToolStripMenuItem showDateLongToolStripMenuItem, ToolStripMenuItem goBackToDefaultSettingsToolStripMenuItem, ToolStripMenuItem goBackToDefaultSettingsToolStripMenuItem1, FlowLayoutPanel flowLayoutPanel1, bool regularTime, bool militaryTimeSelected, bool showSeconds, bool dontShowSeconds, bool showShortDate, bool showLongDate, int height, int width, PictureBox pic, string rootDir, string path_app, string newPath, string[] fileEntries, string tO_DIRECTORY, string fileFolder, string directoryFolder, string dropPath, string activeFile, Process myProcess)
        {
            this.addWebsiteToolStripMenuItem = addWebsiteToolStripMenuItem;
            this.components = components;
            this.treeView1 = treeView1;
            this.splitContainer1 = splitContainer1;
            this.menuStrip1 = menuStrip1;
            this.fileToolStripMenuItem = fileToolStripMenuItem;
            this.aboutToolStripMenuItem = aboutToolStripMenuItem;
            this.cLoseToolStripMenuItem = cLoseToolStripMenuItem;
            this.programsToolStripMenuItem = programsToolStripMenuItem;
            this.addProgramToolStripMenuItem = addProgramToolStripMenuItem;
            this.deleteProgramToolStripMenuItem = deleteProgramToolStripMenuItem;
            this.openFileDialog1 = openFileDialog1;
            this.leftPanelFontDialog = leftPanelFontDialog;
            this.leftPanelColorDialog = leftPanelColorDialog;
            this.btnGoogleSearch = btnGoogleSearch;
            this.txtBoxSearch = txtBoxSearch;

            this.lblClock = lblClock;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.regularTime = regularTime;
            this.militaryTimeSelected = militaryTimeSelected;
            this.showSeconds = showSeconds;
            this.dontShowSeconds = dontShowSeconds;
            this.showShortDate = showShortDate;
            this.showLongDate = showLongDate;
            this.height = height;
            this.width = width;
            this.pic = pic;
            this.rootDir = rootDir;
            this.path_app = path_app;
            this.newPath = newPath;
            this.fileEntries = fileEntries;
            TO_DIRECTORY = tO_DIRECTORY;
            FileFolder = fileFolder;
            DirectoryFolder = directoryFolder;
            this.dropPath = dropPath;
            this.activeFile = activeFile;
            this.myProcess = myProcess;
        }
        #endregion end CONSTRUCTORS

        public string themeNames;

        public int height = 85, width = 90;
        public PictureBox pic = new PictureBox();

        public string rootDir = Environment.SystemDirectory;
        public string path_app;
        public string newPath = System.IO.Path.Combine(Environment.CurrentDirectory, "theDropFiles");
        public string[] fileEntries = Directory.GetFiles(System.IO.Path.Combine(Environment.CurrentDirectory, "theDropFiles"));
        public string TO_DIRECTORY = Environment.CurrentDirectory + @"\theDropFiles\";
        public string FileFolder = Environment.CurrentDirectory + @"\theDropFiles\";
        public string DirectoryFolder = Environment.CurrentDirectory + @"\theDropFiles\";

        public string dropPath;
        public string activeFile;
        public string[] websiteFiles = Directory.GetFiles(@".\websites");

        //move form
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public bool mouseIsDown = false;
        public bool dubClick = false;
        Process myProcess = new Process();

        SHFILEINFO shinfo = new SHFILEINFO();

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        
        #endregion

        public int timeCount = 0;
        public int timeTOINT;
        public Label labelColor2;

        public Form1()
        {
            //  Thread t = new Thread(new ThreadStart(SplashStart));
            //  t.Start();


            InitializeComponent();

            



            fixed3dborder = true;
            if (Properties.Settings.Default.themeName == null)
            {
                Properties.Settings.Default.themeName = "lightTheme";
            }
            else if (Properties.Settings.Default.themeName != null)
            {

                if (Properties.Settings.Default.themeName == "redTheme")
                {
                    redTheme = true;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "greenTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = true;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "orangeTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = true;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "blueTheme")
                {
                    redTheme = false;
                    blueTheme = true;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "lightTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = true;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "darkTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = true;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "purpleTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = false;
                    purpleTheme = true;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
                else if (Properties.Settings.Default.themeName == "yellowTheme")
                {
                    redTheme = false;
                    blueTheme = false;
                    orangeTheme = false;
                    yellowTheme = true;
                    purpleTheme = false;
                    lightTheme = false;
                    darkTheme = false;
                    greenTheme = false;
                    themeNames = Properties.Settings.Default.themeName;
                }
            }


            lblClock.BackColor = Properties.Settings.Default.lbClockBColor;
            lblClock.ForeColor = Properties.Settings.Default.lblClockFColor;
            treeView1.BackColor = Properties.Settings.Default.treeView1;
            treeView1.ForeColor = Properties.Settings.Default.treeView1FColor;
            flowLayoutPanel1.BackColor = Properties.Settings.Default.flowLayoutPanel1;
            splitContainer1.BackColor = Properties.Settings.Default.splitContainer1;
            menuStrip1.BackColor = Properties.Settings.Default.menuStrip1;
            menuStrip1.ForeColor = Properties.Settings.Default.msFColor;
            fileToolStripMenuItem.BackColor = Properties.Settings.Default.fileToolStripMenuItem;
            fileToolStripMenuItem.ForeColor = Properties.Settings.Default.fileToolStripDropFColor;
            fileToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.fileToolStripMenuItem;
            fileToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.fileToolStripDropFColor;
            editToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.editToolStripMenuItem;
            editToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.editToolStripDropFColor;
            programsToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.programsToolStripMenuItem;
            programsToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.programsToolStripDropFColor;
            label1.ForeColor = Properties.Settings.Default.label1;
            label1.BackColor = Properties.Settings.Default.label1BColor;
            themeToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.themeDropBColor;
            themeToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.themeDropFColor;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.iconPBColor;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.iconPFColor;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Properties.Settings.Default.iconDBColor;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Properties.Settings.Default.iconDFColor;




            try
            {
                if (Properties.Settings.Default.lastImgPath != null)
                {
                    flowLayoutPanel1.BackgroundImage = Image.FromFile(Properties.Settings.Default.lastImgPath);
                    //flowLayoutPanel1.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\theDropBackgrounds\theDropDarkTheme.jpg");
                }
                else
                {

                    flowLayoutPanel1.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\theDropBackgrounds\theDropOriginalBackground.JPG");
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;
            regularTime = true;
            militaryTimeSelected = false;
            if (!Directory.Exists(DirectoryFolder))
            {
                Directory.CreateDirectory(DirectoryFolder);
            }
            reg.SetValue("The Drop", Application.ExecutablePath.ToString());

            LoadFiles();
            //    t.Abort();


            CenterToScreen();
            splitContainer1.Padding.Top.Equals(40);
            try
            {
                ListDrives();

            }
            catch (UnauthorizedAccessException ee)
            {
                MessageBox.Show(ee.Message);

            }

            if(Properties.Settings.Default.themeName == "lightTheme")
            {
                flowLayoutPanel1.ForeColor = Color.DodgerBlue;
            }
            else if (Properties.Settings.Default.themeName == "darkTheme")
            {
                flowLayoutPanel1.ForeColor = Color.Lime;
            }
            else if (Properties.Settings.Default.themeName == "blueTheme")
            {
                flowLayoutPanel1.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.themeName == "redTheme")
            {
                flowLayoutPanel1.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.themeName == "orangeTheme")
            {
                flowLayoutPanel1.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.themeName == "yellowTheme")
            {
                flowLayoutPanel1.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.themeName == "purpleTheme")
            {
                flowLayoutPanel1.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.themeName == "greenTheme")
            {
                flowLayoutPanel1.ForeColor = Color.Black;
            }
            return;




        }


       

        //get Folder or Directory ICONS

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
        IntPtr wParam, IntPtr lParam);



        //LOAD DRIVES TO TREEVIEW
        private void ListDrives()
        {
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                if (Directory.Exists(drive))
                {
                    TreeNode node = new TreeNode(drive)
                    {
                        Tag = drive
                    };
                    treeView1.Nodes.Add(node);
                    node.Nodes.Add(new TreeNode(PLACEHOLDER));
                }
            }
            treeView1.BeforeExpand += new TreeViewCancelEventHandler(TreeView_BeforeExpand);
        }

        public void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == PLACEHOLDER)
                {
                    e.Node.Nodes.Clear();
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name)
                        {
                            Tag = dir
                        };
                        try
                        {
                            if (di.GetDirectories().GetLength(0) > 0)
                                node.Nodes.Add(null, PLACEHOLDER);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            // TODO: update node images
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ExplorerForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }



        //MOUSE EVENTS FOR PICTUREBOXs
        #region mouse events


        public void Pic_MouseEnter(object sender, EventArgs e)
        {
          
            PictureBox picBox_active = sender as PictureBox;

            Cursor = Cursors.Hand;

            if (lightTheme == true)
            {
                picBox_active.BackColor = Color.DodgerBlue;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if (blueTheme == true)
            {
                picBox_active.BackColor = Color.LightBlue;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if(yellowTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Yellow;
            }
            else if (orangeTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Orange;
            }
            else if(greenTheme == true)
            {
                picBox_active.BackColor = Color.LightGreen;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }
            else if(redTheme == true)
            {
                picBox_active.BackColor = Color.Black;

                Point p = new Point(0, 65);
                picBox_active.HasChildren.Equals(true);
                var label = picBox_active.GetChildAtPoint(p);
                label.ForeColor = Color.Red;
            }
            else if (darkTheme == true)
            {
                picBox_active.BackColor = Color.Lime;

                Point p = new Point(0, 65);
                    picBox_active.HasChildren.Equals(true);
                    var label = picBox_active.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;


            }
            else if(purpleTheme == true)
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
            Cursor = Cursors.Hand;
        }

        public void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox_active = sender as PictureBox;
            picBox_active.BackColor = Color.Transparent;
            Cursor = Cursors.Arrow;

            if (lightTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.DarkBlue;
                }


            }
            else if (blueTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.White;
                }
            }
            else if (yellowTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (orangeTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (greenTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Black;
                }
            }
            else if (redTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.White;
                }
            }
            else if (darkTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
                foreach (var control in controls)
                {
                    Point p = new Point(0, 65);
                    var pic = control as PictureBox;
                    pic.HasChildren.Equals(true);
                    var label = pic.GetChildAtPoint(p);
                    label.ForeColor = Color.Lime;
                }
             
            }
            else if (purpleTheme == true)
            {
                var controls = flowLayoutPanel1.Controls;
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
                var controls = flowLayoutPanel1.Controls;
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

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            mouseIsDown = true;
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                base.OnMouseDown(e);
                DoDragDrop(sender, DragDropEffects.Move);
                mouseIsDown = false;
            }
            return;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            pic = null;
            Cursor = Cursors.Default;

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

        #endregion

        //LOAD FILES
        public void LoadFiles()
        {


            var currentdir = Environment.CurrentDirectory;
            string activeDir = currentdir;
            string newPath = System.IO.Path.Combine(activeDir, "theDropFiles");
            string[] fileEntries = Directory.GetFiles(newPath);
            foreach (string file in fileEntries)
            {
                Icon icon = Icon.ExtractAssociatedIcon(file);
                PictureBox pic = new PictureBox();
                DoubleBuffered.Equals(pic).Equals(true);

                pic.AllowDrop = true;
                Label lb = new Label();
                if (fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                pic.Location = new Point(0, 0);
                pic.Name = file;
                pic.Image = icon.ToBitmap();
                path_app = String.Format("{0}", file);
                pic.Tag = path_app;
                pic.ContextMenuStrip = contextMenuStrip1;

              

                pic.MouseDown += new MouseEventHandler(Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(Pic_MouseUp);
                pic.DragOver += new DragEventHandler(Pic_DragOver);

                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);


                string newpath_app = Path.GetFileNameWithoutExtension(path_app);
                string f = Path.GetFileNameWithoutExtension(file);
                string fileNameNoExt = Path.GetFileNameWithoutExtension(dropPath);

                Point p = new Point(0, 65);
                lb.Padding.All.Equals(10);
                lb.Margin.All.Equals(20);
                lb.Text = f;
                lb.Font.Bold.Equals(true);
                lb.Parent = pic;
                lb.BackColor = Color.Transparent;
                if(Properties.Settings.Default.piBoxLabelForeColor != null)
                {
                    lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
                }
                else
                {
                    lb.ForeColor = Color.Gray;
                }

                lb.BringToFront();
                lb.Location = p;

                flowLayoutPanel1.Controls.Add(pic);
            }

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
                System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);

                PictureBox pic = new PictureBox();
                Label lb = new Label();



                pic.AllowDrop = true;
                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);
                pic.MouseDown += new MouseEventHandler(this.Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(this.Pic_MouseUp);
                pic.DragOver += new DragEventHandler(this.Pic_DragOver);
                //path_app is a string for the filename.  
                path_app = String.Format("{0}", subdirs);
                // Add tag to each picturebox created with filename as the tag
                string newpath_app = lastFolderName;
                pic.Tag = path_app;

                //MODIFY the PICTUREBOX
                if (fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                Point p = new Point(0, 65);
                pic.ContextMenuStrip = contextMenuStrip1;
                lb.Text = newpath_app;
                lb.Parent = pic;
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
                flowLayoutPanel1.Controls.Add(pic);

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


        //COPY DIRECTORIES

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                DirectoryNotFoundException de = new DirectoryNotFoundException();
                MessageBox.Show("directory doesn't exist " + sourceDirName + " : " + de.Message);
            }
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();


                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, true);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
            catch (DirectoryNotFoundException de)
            {
                MessageBox.Show(de.Message);
            }
        }





        //FLOW LAYOUT PANEL EVENTS        DRAG AND DROP OPTIONS

        Icon icon;
        string fileBeingDragged;
        bool isFolder;

        private void FlowLayoutPanel1_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

        //flow layoutpanel drag and drop
        private void FlowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            //OMG THANK THE LORD FOR BOOLEANS it works finally
            var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (Directory.Exists(path))
            {
                isFolder = true;
            }
            else if (!Directory.Exists(path))
            {
                isFolder = false;
            }

            if (isFolder == true)
            {
                // then it is a directory
                string[] directoryName = (string[])e.Data.GetData(DataFormats.FileDrop);
                string[] files = Directory.GetFiles(directoryName[0]);
                foreach (string subdir in directoryName)
                {
                    fileBeingDragged = subdir;
                }

                string lastFolderName = Path.GetFileName(fileBeingDragged.TrimEnd(Path.DirectorySeparatorChar));

                DirectoryCopy(fileBeingDragged, Environment.CurrentDirectory + @"\theDropFiles\" + lastFolderName, true);

                string fName = fileBeingDragged;
                //Use this to get the small Icon
                // var hImgSmall = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                //Use this to get the large Icon
                var hImgLarge = Win32.SHGetFileInfo(fName, 0,
                ref shinfo, (uint)Marshal.SizeOf(shinfo),
                Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);

                //The icon is returned in the hIcon member of the shinfo struct
                System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);

                PictureBox pic = new PictureBox();
                Label lb = new Label();



                pic.AllowDrop = true;
                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);
                pic.MouseDown += new MouseEventHandler(this.Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(this.Pic_MouseUp);
                pic.DragOver += new DragEventHandler(this.Pic_DragOver);
                //path_app is a string for the filename.  
                path_app = String.Format("{0}", fileBeingDragged);
                // Add tag to each picturebox created with filename as the tag
                string newpath_app = lastFolderName;
                pic.Tag = Environment.CurrentDirectory + @"\theDropFiles\" + lastFolderName;

                //MODIFY the PICTUREBOX
                if(fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }

                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                Point p = new Point(0, 65);
                pic.ContextMenuStrip = contextMenuStrip1;
                lb.Text = newpath_app;
                lb.Parent = pic;
                lb.BackColor = Color.Transparent;
                lb.BringToFront();
                lb.Location = p;
                pic.Name = fName;
                lb.Tag = "dynamicLabel";
                if (Properties.Settings.Default.piBoxLabelForeColor != null)
                {
                    lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
                }
                else
                {
                    lb.ForeColor = Color.Gray;
                }


                flowLayoutPanel1.Controls.Add(pic);

                try
                {
                    pic.Image = myIcon.ToBitmap();

                    string newFileName = fileBeingDragged;
                    if (Directory.Exists(newPath))
                    {
                        string filePath = newPath + @"\" + System.IO.Path.GetFileName(fileBeingDragged);
                        try
                        {
                            File.Copy(newFileName, filePath, true);
                        }
                        catch (UnauthorizedAccessException ua)
                        {

                        }
                        catch (IOException ioe)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Folder path does not exist ", "ERROR WITH FOLDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ArgumentException ae)
                {

                }

            }
            else if (isFolder != true)
            {
                // then it is a file
                //DRAG N DROP FILES DOWN BELOW

                Label lb = new Label();
                PictureBox pic = new PictureBox();
                MenuStrip ms = new MenuStrip();

                foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop, false))
                {
                    dropPath = file;
                    pic.Tag = file;
                    
                }

                try
                {
                    icon = Icon.ExtractAssociatedIcon(dropPath);
                }
                catch (FileNotFoundException fnfe)
                {
                    MessageBox.Show("Can't copy folders sorry   " + fnfe.Message, "No Folders Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException nfe)
                {
                    MessageBox.Show(nfe.Message);
                }

                if (!File.Exists(newPath))
                {
                    System.IO.Directory.CreateDirectory(newPath);

                }

                string fileNameNoExt = Path.GetFileNameWithoutExtension(dropPath);
                string newpath_app = Path.GetFileNameWithoutExtension(path_app);

                Point p = new Point(0, 65);
                lb.Padding.All.Equals(10);
                lb.Margin.All.Equals(20);
                lb.Text = fileNameNoExt;
                lb.Parent = pic;
                lb.BackColor = Color.Transparent;
                lb.BringToFront();
                lb.Location = p;
                if (Properties.Settings.Default.piBoxLabelForeColor != null)
                {
                    lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
                }
                else
                {
                    lb.ForeColor = Color.Gray;
                }
                path_app = String.Format("{0}", dropPath);
                pic.Name = dropPath;
                pic.ContextMenuStrip = contextMenuStrip1;
                if (fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                pic.AllowDrop = true;
                pic.MouseDown += new MouseEventHandler(Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(Pic_MouseUp);
                pic.DragOver += new DragEventHandler(Pic_DragOver);
                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);



                flowLayoutPanel1.Controls.Add(pic);

                try
                {
                    try
                    {
                        pic.Image = icon.ToBitmap();
                    }
                    catch (NullReferenceException nre)
                    {
                        MessageBox.Show("Error: " + nre.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string newFileName = dropPath;
                    if (Directory.Exists(newPath))
                    {
                        string filePath = newPath + @"\" + System.IO.Path.GetFileName(dropPath);
                        File.Copy(newFileName, filePath, true);
                    }
                    else
                    {
                        MessageBox.Show("Folder path does not exist", "ERROR WITH FOLDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show("Error: " + ae.Message, "Couldn't find file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //DOUBLE CLICK TREEVIEW
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            myProcess.StartInfo.FileName = treeView1.SelectedNode.FullPath;
            myProcess.Start();
        }

        //TOOL STRIP FUNCTIONS
        private void CLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
            this.Close();
            this.Dispose();
        }

        public void DeleteAllControls()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        //CLICK ADD TOOL STRIP TO ADD PROGRAM TO FLOW LAYOUT PANEL
        private void AddProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                //create icon of the file selected
                Icon icon = Icon.ExtractAssociatedIcon(openFileDialog1.FileName);


                PictureBox pic = new PictureBox();
                Label lb = new Label();



                pic.AllowDrop = true;
                pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);
                pic.MouseDown += new MouseEventHandler(this.Pic_MouseDown);
                pic.MouseUp += new MouseEventHandler(this.Pic_MouseUp);
                pic.DragOver += new DragEventHandler(this.Pic_DragOver);
                //path_app is a string for the filename.  
                path_app = String.Format("{0}", openFileDialog1.FileName);
                // Add tag to each picturebox created with filename as the tag
                string newpath_app = Path.GetFileNameWithoutExtension(path_app);
                pic.Tag = path_app;
                //MODIFY the PICTUREBOX
                if (fixedsingleborder == true)
                {
                    pic.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (fixed3dborder == true)
                {
                    pic.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (noborder == true)
                {
                    pic.BorderStyle = BorderStyle.None;
                }
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.BackColor = Color.Transparent;
                pic.Height = height;
                pic.Width = width;
                Point p = new Point(0, 65);
                pic.ContextMenuStrip = contextMenuStrip1;
                lb.Text = newpath_app;
                lb.Parent = pic;
                lb.BackColor = Color.Transparent;
                lb.BringToFront();
                lb.Location = p;
                if (Properties.Settings.Default.piBoxLabelForeColor != null)
                {
                    lb.ForeColor = Properties.Settings.Default.piBoxLabelForeColor;
                }
                else
                {
                    lb.ForeColor = Color.Gray;
                }
                pic.Name = dropPath;
                flowLayoutPanel1.Controls.Add(pic);

                try
                {
                    pic.Image = icon.ToBitmap();
                    string newFileName = openFileDialog1.FileName;
                    if (Directory.Exists(newPath))
                    {
                        string filePath = newPath + @"\" + System.IO.Path.GetFileName(openFileDialog1.FileName);
                        File.Copy(newFileName, filePath, true);
                    }
                    else
                    {
                        MessageBox.Show("Folder path does not exist", "ERROR WITH FOLDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show("Error: " + ae.Message, "Couldn't find file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                openFileDialog1.Dispose();
            }
            else openFileDialog1.Dispose();
            return;
        }

        //ABOUT THE DROP
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Drop was created to clear the clutter on your desktop.  This is done by putting all of your folders to the left of your screen and all of your main programs and files that you access on the right.  Instead of loading 20 shortcuts to your desktop just start this program when your computer starts up.  This way you don't throw the computer out the window waiting for your desktop to load.  :) ", "About The Drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        //TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {

            string time = DateTime.Now.ToString("h:mm tt");
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            string timeAndDate = time + " " + date;
            lblClock.Text = timeAndDate;

            return;
        }




        //SEARCH EVENTS

        private void BtnGoogleSearch_Click(object sender, EventArgs e)
        {
            txtBoxSearch.Text.Replace(" ", "+");

            Process.Start("https://www.google.com/search?q=" + txtBoxSearch.Text);
            return;
        }


        //SEARCH BAR STOP SOUND WHEN PRESSING ENTER

        private void TxtBoxSearch_KeyDown(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnGoogleSearch_Click(this, new EventArgs());
                txtBoxSearch.Clear();
                return;
            }

            else return;
        }


        //FORM CLOSING

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var i = flowLayoutPanel1.BackgroundImage;
            Form1 fm1 = new Form1();
            if (Properties.Settings.Default.lastImgPath == Properties.Settings.Default.lastImgPath)
            {
                timer1.Stop();
                timer1.Dispose();

                treeView1.Dispose();
                flowLayoutPanel1.Dispose();

                fm1.Dispose();
                fm1.Close();

                return;
            }
            else
            {

                i.Save(Properties.Settings.Default.lastImgPath);
                Properties.Settings.Default.lastImgPath = lastBackImg;

            }

            timer1.Stop();
            timer1.Dispose();
            treeView1.Dispose();
            flowLayoutPanel1.Dispose();
            fm1.Dispose();
            fm1.Close();

        }


        //DELETE PROGRAM TOOL STRIP MENU ITEM CLICKED EVENT

        private void DeleteProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            return;
        }




        //CHANGE BACKGROUND IMAGE
        private void changeBackgroundImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var backImg = openFileDialog1.FileName;
                flowLayoutPanel1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                lastBackImg = openFileDialog1.FileName;

            }
            openFileDialog1.Dispose();
            return;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreferences fp = new FormPreferences();
            fp.Show();
            return;
        }

        private void lblClock_Click(object sender, EventArgs e)
        {
        }

        public void addWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddWebsites faw = new FormAddWebsites();

            faw.Show();
            faw.TopMost = true;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp fh = new FormHelp();
            fh.Show();
            return;
        }

        private void txtBoxSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            treeView1.Nodes[e.NewValue].EnsureVisible();
            return;
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

            }
            else
            {

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                this.MaximizedBounds = rect;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;


                return;

            }


        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;



            return;


        }



        //FORM FULLSCREEN AND BORDER TOGGLE
        #region FULLSCREEN AND BORDER TOGGLE
        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void fullscreencoversTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            return;
        }

        private void normalWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;

        }

        private void showFormBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void hideFormBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.FormBorderStyle = FormBorderStyle.None;
            return;
        }
        #endregion

        //SAVE CURRENT THEME TOOL STRIP MENU ITEM
        public Label labelColor;
        private void saveCurrentThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
      

            Properties.Settings.Default.piBoxLabelForeColor = flowLayoutPanel1.ForeColor;
            Properties.Settings.Default.lbClockBColor = lblClock.BackColor;
            Properties.Settings.Default.lblClockFColor = lblClock.ForeColor;
            Properties.Settings.Default.label1 = label1.ForeColor;
            Properties.Settings.Default.label1BColor = label1.BackColor;
            Properties.Settings.Default.flowLayoutPanel1 = flowLayoutPanel1.BackColor;
            Properties.Settings.Default.menuStrip1 = menuStrip1.BackColor;
            Properties.Settings.Default.msFColor = menuStrip1.ForeColor;
            Properties.Settings.Default.programsToolStripDropFColor = programsToolStripMenuItem.ForeColor;
            Properties.Settings.Default.programsToolStripMenuItem = programsToolStripMenuItem.BackColor;
            Properties.Settings.Default.editToolStripDropFColor = editToolStripMenuItem.ForeColor;
            Properties.Settings.Default.editToolStripMenuItem = editToolStripMenuItem.BackColor;
            Properties.Settings.Default.splitContainer1 = splitContainer1.BackColor;
            Properties.Settings.Default.fileToolStripDropFColor = fileToolStripMenuItem.ForeColor;
            Properties.Settings.Default.fileToolStripMenuItem = fileToolStripMenuItem.BackColor;
            Properties.Settings.Default.treeView1 = treeView1.BackColor;
            Properties.Settings.Default.treeView1FColor = treeView1.ForeColor;
            Properties.Settings.Default.themeDropBColor = themeToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.themeDropFColor = themeToolStripMenuItem.DropDown.ForeColor;
            Properties.Settings.Default.iconPBColor = iconPreferencesToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.iconPFColor = iconPreferencesToolStripMenuItem.DropDown.ForeColor;
            Properties.Settings.Default.iconDBColor = changeIconDirectionToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.iconDFColor = changeIconDirectionToolStripMenuItem.DropDown.ForeColor;
            if (lastBackImg == null)
            {
                Properties.Settings.Default.lastImgPath = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropOriginalBackground.JPG";
            }
            else
            {
                Properties.Settings.Default.lastImgPath = lastBackImg;
            }
            Properties.Settings.Default.splitContainerSize = splitContainer1.Panel2.Width;




            Properties.Settings.Default.Save();
            //Properties.Settings.Default.treeView1 = fp.fBackColor;
            //Properties.Settings.Default.flowLayoutPanel1 = BackgroundImage.
        }


        //FORM MOVE AND RESIZE........... pretty much empty

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Refresh();
            return;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }



        //VOLUME CONTROLS

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void volumeUpToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);

            }

        }

        private void volumeToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            }
        }



        //THEMES

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "lightTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach(var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.DarkBlue;
            }

            lightTheme = true;
            blueTheme = false;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.DodgerBlue;
            flowLayoutPanel1.BackColor = Color.White;
            treeView1.BackColor = Color.White;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Black;
            lblClock.BackColor = Color.White;
            splitContainer1.BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ForeColor = Color.Black;
            fileToolStripMenuItem.DropDown.BackColor = Color.Silver;  //change these to right color
            fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            editToolStripMenuItem.DropDown.BackColor = Color.Silver;
            editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            programsToolStripMenuItem.DropDown.BackColor = Color.Silver;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.Silver;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropOriginalBackground.JPG";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            themeToolStripMenuItem.DropDown.BackColor = Color.Silver;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.Silver;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.Silver;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.Silver;
            fileToolStripMenuItem.ForeColor = Color.Black;
            

        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "darkTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.Lime;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = true;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.Lime;
            flowLayoutPanel1.BackColor = Color.DarkGray;
            treeView1.BackColor = Color.Gray;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Lime;
            lblClock.BackColor = Color.Black;
            splitContainer1.BackColor = Color.Black;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Lime;
            label1.ForeColor = Color.Lime;
            label1.BackColor = Color.Black;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropDarkTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.Lime;
            fileToolStripMenuItem.DropDown.BackColor = Color.Black;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            editToolStripMenuItem.DropDown.BackColor = Color.Black;
            editToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            programsToolStripMenuItem.DropDown.BackColor = Color.Black;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            themeToolStripMenuItem.DropDown.BackColor = Color.Black;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Lime;
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.Lime;

        }

        private void redThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "redTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.White;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = true;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.BackColor = Color.Black;
            treeView1.BackColor = Color.Black;
            treeView1.ForeColor = Color.Red;
            lblClock.ForeColor = Color.Red;
            lblClock.BackColor = Color.Black;
            splitContainer1.BackColor = Color.DarkRed;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.Red;
            label1.ForeColor = Color.Red;
            label1.BackColor = Color.Black;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\redTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.Black;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Red;
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.Red;
            editToolStripMenuItem.DropDown.BackColor = Color.Black;
            editToolStripMenuItem.DropDown.ForeColor = Color.Red;
            programsToolStripMenuItem.DropDown.BackColor = Color.Black;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Red;
            themeToolStripMenuItem.DropDown.BackColor = Color.Black;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Red;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Red;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Red;
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.ForeColor = Color.Red;
        }

        private void blueThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "blueTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.White;
            }

            lightTheme = false;
            blueTheme = true;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.BackColor = Color.LightBlue;
            treeView1.BackColor = Color.LightBlue;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Black;
            lblClock.BackColor = Color.LightBlue;
            splitContainer1.BackColor = Color.LightBlue;
            menuStrip1.BackColor = Color.LightBlue;
            menuStrip1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.LightBlue;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\blueTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.LightBlue;
            fileToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            programsToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            themeToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.LightBlue;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.LightBlue;
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void greenThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "greenTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = true;

            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.BackColor = Color.Lime;
            treeView1.BackColor = Color.LightGreen;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Black;
            lblClock.BackColor = Color.LightGreen;
            splitContainer1.BackColor = Color.DarkGreen;
            menuStrip1.BackColor = Color.LightGreen;
            menuStrip1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.LightGreen;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\greenTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.LightGreen;
            fileToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            programsToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            themeToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.LightGreen;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.LightGreen;
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void yellowThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "yellowTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = true;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.BackColor = Color.Yellow;
            treeView1.BackColor = Color.Yellow;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Black;
            lblClock.BackColor = Color.Yellow;
            splitContainer1.BackColor = Color.Yellow;
            menuStrip1.BackColor = Color.Yellow;
            menuStrip1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.Yellow;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\yellowTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            editToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.Yellow;
            fileToolStripMenuItem.ForeColor = Color.Black;
            programsToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            themeToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.Yellow;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.Yellow;
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void purpleThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "purpleTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.White;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = false;
            orangeTheme = false;
            yellowTheme = false;
            purpleTheme = true;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.BackColor = Color.White;
            treeView1.BackColor = Color.Purple;
            treeView1.ForeColor = Color.White;
            lblClock.ForeColor = Color.White;
            lblClock.BackColor = Color.Purple;
            splitContainer1.BackColor = Color.MediumPurple;
            menuStrip1.BackColor = Color.Purple;
            menuStrip1.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Purple;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\purpleTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.Purple;
            fileToolStripMenuItem.DropDown.ForeColor = Color.White;
            editToolStripMenuItem.DropDown.BackColor = Color.Purple;
            editToolStripMenuItem.DropDown.ForeColor = Color.White;
            fileToolStripMenuItem.BackColor = Color.Purple;
            fileToolStripMenuItem.ForeColor = Color.White;
            programsToolStripMenuItem.DropDown.BackColor = Color.Purple;
            programsToolStripMenuItem.DropDown.ForeColor = Color.White;
            themeToolStripMenuItem.DropDown.BackColor = Color.Purple;
            themeToolStripMenuItem.DropDown.ForeColor = Color.White;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.Purple;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.White;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.Purple;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.White;
            fileToolStripMenuItem.BackColor = Color.Purple;
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        private void orangeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.themeName = "orangeTheme";

            var controls = flowLayoutPanel1.Controls;
            foreach (var control in controls)
            {
                Point p = new Point(0, 65);
                var pic = control as PictureBox;
                pic.HasChildren.Equals(true);
                var label = pic.GetChildAtPoint(p);
                label.ForeColor = Color.Black;
            }

            lightTheme = false;
            blueTheme = false;
            redTheme = false;
            orangeTheme = true;
            yellowTheme = false;
            purpleTheme = false;
            darkTheme = false;
            greenTheme = false;

            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.BackColor = Color.DarkOrange;
            treeView1.BackColor = Color.Orange;
            treeView1.ForeColor = Color.Black;
            lblClock.ForeColor = Color.Black;
            lblClock.BackColor = Color.Orange;
            splitContainer1.BackColor = Color.DarkOrange;
            menuStrip1.BackColor = Color.DarkOrange;
            menuStrip1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.DarkOrange;
            lastBackImg = Environment.CurrentDirectory + @"\theDropBackgrounds\orangeTheme.jpg";
            flowLayoutPanel1.BackgroundImage = Image.FromFile(lastBackImg);
            fileToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            fileToolStripMenuItem.DropDown.ForeColor = Color.Black;
            editToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            editToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.DarkOrange;
            fileToolStripMenuItem.ForeColor = Color.Black;
            programsToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            programsToolStripMenuItem.DropDown.ForeColor = Color.Black;
            themeToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            themeToolStripMenuItem.DropDown.ForeColor = Color.Black;
            changeIconDirectionToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            changeIconDirectionToolStripMenuItem.DropDown.ForeColor = Color.Black;
            iconPreferencesToolStripMenuItem.DropDown.BackColor = Color.DarkOrange;
            iconPreferencesToolStripMenuItem.DropDown.ForeColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.DarkOrange;
            fileToolStripMenuItem.ForeColor = Color.Black;

        }



        //Flow layout panel icon direction / flow direction

        private void topDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private void rightToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
        }

        private void bottomUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
        }

        private void iconPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }



        //PICBOX BORDER EDIT

        private void noneToolStripMenuItem_Click(Object Source, EventArgs e)
        {
            fixed3dborder = false;
            noborder = true;
            fixedsingleborder = false;

            var c = flowLayoutPanel1.Controls;
            foreach (var controls in c)
            {
                PictureBox pics = controls as PictureBox;
                pics.BorderStyle = BorderStyle.None;
               
            }
        }

        private void fixedSIngleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixed3dborder = false;
            noborder = false;
            fixedsingleborder = true;
            var c = flowLayoutPanel1.Controls;
            foreach (var controls in c)
            {
                PictureBox pics = controls as PictureBox;
                pics.BorderStyle = BorderStyle.FixedSingle;

            }
        }

        private void fixed3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixed3dborder = true;
            noborder = false;
            fixedsingleborder = false;
            var c = flowLayoutPanel1.Controls;
            foreach (var controls in c)
            {
                PictureBox pics = controls as PictureBox;
                pics.BorderStyle = BorderStyle.Fixed3D;

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            

        }
            Clipboard cb;
        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {



            ContextMenuStrip cm = new ContextMenuStrip();
            //////////// Create a new "ToolStripMenuItem" object:
            ToolStripMenuItem newMenuItem = new ToolStripMenuItem();

            //////////// Set a name, for identification purposes:
            newMenuItem.Name = "Paste";

            //////////// Sets the text that will appear in the new context menu option:
            newMenuItem.Text = "Paste";
            if (e.Button == MouseButtons.Right)
            {
                cm.Items.Add(newMenuItem);
                cm.Items.ContainsKey("Paste");
                cm.Show(MousePosition);
                cm.ItemClicked += new ToolStripItemClickedEventHandler(this.cm_ItemClicked);
            }
        }

        private void cm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Get data from file copied.  file location and file name
            
            MessageBox.Show(Clipboard.GetImage().ToString());

            //Get Icon from file copied.

            //Paste to new location 'theDropFiles'

            //create label and pic add event handlers too them.  
        }

        private void treeView1_DragLeave(object sender, EventArgs e)
        {
        
        }
        string treeviewPath;
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            
        }

        //CONTEXT MENU FOR PICTUREBOXES

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Acquire references to the owning control and item.
            Control c = contextMenuStrip1.SourceControl as Control;
            ToolStripDropDownItem tsi = contextMenuStrip1.OwnerItem as ToolStripDropDownItem;

            // Clear the ContextMenuStrip control's Items collection.
            contextMenuStrip1.Items.Clear();

            // Check the source control first.
            if (c != null)
            {
                // Add custom item (Form)
                contextMenuStrip1.Items.Add("Delete");
            }
            else if (tsi != null)
            {
                // Add custom item (ToolStripDropDownButton or ToolStripMenuItem)
                contextMenuStrip1.Items.Add("Source: " + tsi.GetType().ToString());

            }

            // Populate the ContextMenuStrip control with its default items.



            // Set Cancel to false. 
            // It is optimized to true based on empty entry.
            e.Cancel = false;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Control c = contextMenuStrip1.SourceControl as Control;
            PictureBox picActive = sender as PictureBox;
            if (e.ClickedItem.Text == "Delete")
            {
                c.Dispose();
                if (isFolder == true) {
                    try
                    {
                        File.Delete(c.Name);
                    }
                    catch (UnauthorizedAccessException ue)
                    {

                    }
                }
                else if (isFolder != true)
                {
                    try
                    {
                        string newname = Path.GetFileNameWithoutExtension(c.Name);
                        File.Delete(Environment.CurrentDirectory + @"\theDropFiles\" + newname);
                    }
                    catch (UnauthorizedAccessException uae)
                    {

                    }
                }

                try
                {
                    string lastFolderName = Path.GetFileName(c.Name.TrimEnd(Path.DirectorySeparatorChar));

                    Directory.Delete(Environment.CurrentDirectory + @"\theDropFiles\" + lastFolderName, recursive: true);
                }
                catch (UnauthorizedAccessException ua)
                {

                }
                catch (IOException ioe)
                {

                }
            }
            return;
        }


        //save new theme still doesn't work...
        /*SAVE ALL ADJUSTMENTS TO a text file... and create a folder with it's name under a folder named themes.  */
        private void saveANEWThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNewTheme snt = new SaveNewTheme();
            snt.Show();
        }



        //ADD DIRECTORIES FOLDERS
        private void addFolderDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    isFolder = true;
                    Environment.SpecialFolder rootFolder = folderDialog.RootFolder;
                    string folderPath = folderDialog.SelectedPath;
                    string lastFolderName = Path.GetFileName(folderPath.TrimEnd(Path.DirectorySeparatorChar));

                    DirectoryCopy(folderPath, Environment.CurrentDirectory + @"\theDropFiles\" + lastFolderName, true);

                    string fName = folderDialog.SelectedPath;
                    //Use this to get the small Icon
                    // var hImgSmall = Win32.SHGetFileInfo(fName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                    //Use this to get the large Icon
                    var hImgLarge = Win32.SHGetFileInfo(fName, 0,
                    ref shinfo, (uint)Marshal.SizeOf(shinfo),
                    Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);

                    //The icon is returned in the hIcon member of the shinfo struct
                    System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);

                    PictureBox pic = new PictureBox();
                    Label lb = new Label();



                    pic.AllowDrop = true;
                    pic.MouseHover += new EventHandler(this.Pic_MouseHover);
                    pic.MouseLeave += new EventHandler(this.Pic_MouseLeave);
                    pic.DoubleClick += new EventHandler(this.Pic_DoubleClick);
                    pic.MouseEnter += new EventHandler(this.Pic_MouseEnter);
                    pic.MouseDown += new MouseEventHandler(this.Pic_MouseDown);
                    pic.MouseUp += new MouseEventHandler(this.Pic_MouseUp);
                    pic.DragOver += new DragEventHandler(this.Pic_DragOver);
                    //path_app is a string for the filename.  
                    path_app = String.Format("{0}", folderDialog.SelectedPath);
                    // Add tag to each picturebox created with filename as the tag
                    string newpath_app = lastFolderName;
                    pic.Tag = path_app;

                    //MODIFY the PICTUREBOX
                    if (fixedsingleborder == true)
                    {
                        pic.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else if (fixed3dborder == true)
                    {
                        pic.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else if (noborder == true)
                    {
                        pic.BorderStyle = BorderStyle.None;
                    }
                    pic.SizeMode = PictureBoxSizeMode.CenterImage;
                    pic.BackColor = Color.Transparent;
                    pic.Height = height;
                    pic.Width = width;
                    Point p = new Point(0, 65);
                    pic.ContextMenuStrip = contextMenuStrip1;
                    lb.Text = newpath_app;
                    lb.Parent = pic;
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
                    flowLayoutPanel1.Controls.Add(pic);

                    try
                    {
                        pic.Image = myIcon.ToBitmap();

                        string newFileName = folderDialog.SelectedPath;
                        if (Directory.Exists(newPath))
                        {
                            string filePath = newPath + @"\" + System.IO.Path.GetFileName(folderDialog.SelectedPath);
                            try
                            {
                                File.Copy(newFileName, filePath, true);
                            }
                            catch (UnauthorizedAccessException ua)
                            {

                            }
                            catch (IOException ioe)
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Folder path does not exist", "ERROR WITH FOLDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        MessageBox.Show("Error: " + ae.Message, "Couldn't find file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (folderDialog.ShowDialog() == DialogResult.Cancel)
                {
                    folderDialog.Dispose();
                    return;
                }
                else folderDialog.Dispose();
                return;

            }
        }

        private void hideLeftPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }

        private void showLeftPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
            this.Dispose();
            timer1.Stop();
            Application.Exit();
        }

        private void saveThemeForStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.piBoxLabelForeColor = flowLayoutPanel1.ForeColor;
            Properties.Settings.Default.lbClockBColor = lblClock.BackColor;
            Properties.Settings.Default.lblClockFColor = lblClock.ForeColor;
            Properties.Settings.Default.label1 = label1.ForeColor;
            Properties.Settings.Default.label1BColor = label1.BackColor;
            Properties.Settings.Default.flowLayoutPanel1 = flowLayoutPanel1.BackColor;
            Properties.Settings.Default.menuStrip1 = menuStrip1.BackColor;
            Properties.Settings.Default.msFColor = menuStrip1.ForeColor;
            Properties.Settings.Default.programsToolStripDropFColor = programsToolStripMenuItem.ForeColor;
            Properties.Settings.Default.programsToolStripMenuItem = programsToolStripMenuItem.BackColor;
            Properties.Settings.Default.editToolStripDropFColor = editToolStripMenuItem.ForeColor;
            Properties.Settings.Default.editToolStripMenuItem = editToolStripMenuItem.BackColor;
            Properties.Settings.Default.splitContainer1 = splitContainer1.BackColor;
            Properties.Settings.Default.fileToolStripDropFColor = fileToolStripMenuItem.ForeColor;
            Properties.Settings.Default.fileToolStripMenuItem = fileToolStripMenuItem.BackColor;
            Properties.Settings.Default.treeView1 = treeView1.BackColor;
            Properties.Settings.Default.treeView1FColor = treeView1.ForeColor;
            Properties.Settings.Default.themeDropBColor = themeToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.themeDropFColor = themeToolStripMenuItem.DropDown.ForeColor;
            Properties.Settings.Default.iconPBColor = iconPreferencesToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.iconPFColor = iconPreferencesToolStripMenuItem.DropDown.ForeColor;
            Properties.Settings.Default.iconDBColor = changeIconDirectionToolStripMenuItem.DropDown.BackColor;
            Properties.Settings.Default.iconDFColor = changeIconDirectionToolStripMenuItem.DropDown.ForeColor;
            if (lastBackImg == null)
            {
                Properties.Settings.Default.lastImgPath = Environment.CurrentDirectory + @"\theDropBackgrounds\theDropOriginalBackground.JPG";
            }
            else
            {
                Properties.Settings.Default.lastImgPath = lastBackImg;
            }
            Properties.Settings.Default.splitContainerSize = splitContainer1.Panel2.Width;




            Properties.Settings.Default.Save();
        }



    }
}

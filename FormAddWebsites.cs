using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace TheDrop
{
    public partial class FormAddWebsites : Form
    {
        public StreamReader sr;
        public StreamWriter sw;
        public string websitesFile = @".\websites\";
        public string compareitem;
        Process p = new Process();
        
        

        public FormAddWebsites()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(txtBoxSites.Text))
            {
                //Create text file
                File.Create(websitesFile + txtBoxSites.Text + ".txt");
                listBox1.Items.Add(txtBoxSites.Text);
                txtBoxSites.Text = string.Empty;
                return;
            }
            else
            {
                MessageBox.Show("This site already exists...", "Site Already Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        
           
        }



        private void FormAddWebsites_Load(object sender, EventArgs e)
        {
     
          
            string[] allfiles = Directory.GetFiles(websitesFile);
            foreach (string file in allfiles)
            {

                string file1 = Path.GetFileNameWithoutExtension(file);

                listBox1.Items.Add(file1);
              
            }
            Form1 fm1 = new Form1();
            fm1.addWebsiteToolStripMenuItem.Enabled = false;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.addWebsiteToolStripMenuItem.Enabled = true;
            fm1.websitesAreOpen = false;
            this.Dispose();
            this.Close();
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedlistitem = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(selectedlistitem);
            string curdir = Environment.CurrentDirectory;

            foreach (string item in listBox1.Items)
            {
                try
                {
                    File.Delete(curdir + @"\websites\" + selectedlistitem + ".txt");
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            return;

        }
        //OPEN WEBSITE
        private void button3_Click(object sender, EventArgs e)
        {
            string selectedlistitem = listBox1.SelectedItem.ToString();
            Process.Start(selectedlistitem);
            return;

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedlistitem = listBox1.SelectedItem.ToString();
            Process.Start(selectedlistitem);
            return;
        }

        private void FormAddWebsites_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.addWebsiteToolStripMenuItem.Enabled = true;
        }

        private void FormAddWebsites_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.addWebsiteToolStripMenuItem.Enabled = true;
            MessageBox.Show(e.CloseReason.ToString());
        }
    }
}


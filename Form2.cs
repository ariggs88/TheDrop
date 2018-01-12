using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDrop;


namespace TheDrop
{
    public partial class Form2 : Form
    {
        
        public string regname;
        public string fullpath;

        public Form2() => InitializeComponent();

        private void Form2_Load(object sender, EventArgs e)
        {
            var currentdir = Environment.CurrentDirectory;
            string activeDir = currentdir;
            string newPath = System.IO.Path.Combine(activeDir, "theDropFiles");
            string[] fileEntries = Directory.GetFiles(newPath);

            foreach (string file in fileEntries)
            {
                regname = Path.GetFileNameWithoutExtension(file);
                fullpath = Path.GetFullPath(file);
                listBox1.Items.Add(regname + "     -      " + fullpath);
            }
        }

        public string secondFullPath;

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            
            var currentdir = Environment.CurrentDirectory;
            string activeDir = currentdir;
            string newPath = System.IO.Path.Combine(activeDir, "theDropFiles");
            string[] fileEntries = Directory.GetFiles(newPath);
            

            foreach (string file in fileEntries)
            {
                fullpath = Path.GetFullPath(file);
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                string[] filepath3 = listBox1.Items[listBox1.SelectedIndex].ToString().Split('-');
                if (listBox1.SelectedIndex != -1)
                {
                    File.Delete(filepath3[1]);
                }
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }

            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {

                fm1.SuspendLayout();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).DeleteAllControls();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Refresh();
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).LoadFiles();
                fm1.ResumeLayout();
                fm1.Refresh();
            }
            return;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Dispose(); this.Close(); secondFullPath = null; 
        }
    }
}

// use this Control c = contextMenuStrip1.SourceControl as Control; to delete program selected
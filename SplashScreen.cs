using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TheDrop
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
     
            InitializeComponent();
            timer1.Start();
        }

     

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
            }
          
            
       
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

         

        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }
    }
}

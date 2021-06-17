using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTestApp
{
    public partial class TimerApp : Form
    { 
        private bool stopProcess = false; // Boolean flag used to stop the process

        public TimerApp()
        {
            InitializeComponent();
            this.btn_Timer.BackColor = Color.LightBlue;
        }
        private void btn_Timer_Click(object sender, EventArgs e)
        {
            if (stopProcess != true)
            {
                this.btn_Timer.BackColor = Color.Green;
                this.btn_Timer.ForeColor = Color.White;
                stopProcess = true; // Flag to indicate the button event has been started
                timer1.Tick += new EventHandler(timer1_Tick); //New handler is created to print the date + time
                timer1.Interval = 2000; // in miliseconds
                timer1.Start(); 
            }
            else
            {
                this.btn_Timer.BackColor = Color.LightBlue;
                this.btn_Timer.ForeColor = Color.Black;
                stopProcess = false; // Flag to indicate the button event has been stopped
                timer1.Stop();
                timer1.Tick -= new EventHandler(timer1_Tick);  //existing handler is Removed so that multiple events are not created
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_Timer.Text = DateTime.UtcNow.ToString("dd MMM yyyy hh:mm:ss") + Environment.NewLine + txt_Timer.Text; //Prints the date with time on top of earlier text.
        }
    }
}

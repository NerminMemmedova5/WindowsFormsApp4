using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
               bt.Dispose();
            }
            this.label1.Dispose();
            this.bakubtn.Dispose();
            this.BackgroundImage = Properties.Resources.London;
            

            Label londonlb = new Label();
            londonlb.Location = new Point(320, 30);
            londonlb.ForeColor = Color.Red;
            londonlb.Text = DateTime.Now.AddHours(-3).ToLongTimeString();

            londonlb.Font = new Font("Monotype Corsiva", 25, FontStyle.Bold);
            londonlb.AutoSize = true;

            this.Controls.Add(londonlb);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                bt.Dispose();
            }
            this.label1.Dispose();
            this.londonbtn.Dispose();
            this.BackgroundImage = Properties.Resources.Baki;

            Label bakulb = new Label();
            bakulb.Location = new Point(320, 30);
            bakulb.ForeColor = Color.Red;
            bakulb.Text = DateTime.Now.ToLongTimeString();
            bakulb.Font = new Font("Monotype Corsiva", 25, FontStyle.Bold);
            bakulb.AutoSize = true;

            this.Controls.Add(bakulb);


        }
    }
}

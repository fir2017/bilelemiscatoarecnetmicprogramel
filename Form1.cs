using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace bilelemiscatoare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int N = 25;
        public bila[] bilele = new bila[N];
        public Random rnd = new Random(400);
        public Random rnd2 = new Random(8);


        public void colisiondetection()
        { 
        

        
        }

        public void animate()
        {
            

            for (int i = 0; i < N; i++)
            {
                if (bilele[i].Left <= 0 || bilele[i].Left >= 500)
                {
                    bilele[i].directionx *= -1;
                }
                if (bilele[i].Top <= 0 || bilele[i].Top >= 500)
                {
                    bilele[i].directiony *= -1;
                }
                bilele[i].Left += 1 * bilele[i].directionx;
                bilele[i].Top += 1 * bilele[i].directiony;
                //bilele[i].Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Width = 1024;
            this.Height = 768;
            this.Left = 0;

            for(int i = 0 ; i< N; i++){
                bilele[i] = new bila();
                bilele[i].Left = rnd.Next(400);
                bilele[i].Top = rnd.Next(400);
                Controls.Add(bilele[i]);
                bilele[i].Visible = true;
            }

        }

        public void makeanimation()
        {

            float i = 0.0f;
            while (i < 100)
            {
                animate();
                i+=0.01f;
                Thread.Sleep(1);
            };

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeanimation();
        }

    }
}

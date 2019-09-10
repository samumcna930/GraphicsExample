using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            g.DrawArc(drawPen, 20, 20, 50, 50, 20, 300);
            g.DrawArc(drawPen, 20, 20, 50, 50, 30, -70);
            

            Font drawFont = new Font("Arial", 32, FontStyle.Bold);
            SolidBrush drawBrush1 = new SolidBrush(Color.Red);
            g.DrawString("Hello how was your day", drawFont, drawBrush1, 60, 80);


            
        }
    }
}

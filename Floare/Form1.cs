using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21._11._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double t = 0, n;
            int x_v, y_v, x, y, x0, y0;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Desen.Clear(this.BackColor);
            x0 = (this.Width - 50) / 2;//jumatatea formularului
            y0 = (this.Height - 50) / 2;
            n = System.Convert.ToDouble(this.numericUpDown1.Value);//numar spirale
            x_v = System.Convert.ToInt16(x0 + x0 * System.Math.Cos(n * t) * System.Math.Cos(t));
            y_v = System.Convert.ToInt16(y0 + y0 * System.Math.Cos(n * t) * System.Math.Sin(t));
            do
            {
                x = System.Convert.ToInt16(x0 + x0 * System.Math.Cos(n * t) * System.Math.Cos(t));
                y = System.Convert.ToInt16(y0 + y0 * System.Math.Cos(n * t) * System.Math.Sin(t));
                //Desen.DrawLine(Creion_albastru, x_v, y_v, x, y);
                x_v = x;
                y_v = y;
                t += 0.001;//Rotunjimea 
                do
                {
                    x = System.Convert.ToInt16(x0 + x0 * System.Math.Cos(n * t) * System.Math.Cos(t));
                    y = System.Convert.ToInt16(y0 + y0 * System.Math.Cos(n * t) * System.Math.Sin(t));
                    Desen.DrawLine(Creion_albastru, x_v, y_v, x, y);
                    x_v = x;
                    y_v = y;
                    t += 0.001;//Rotunjimea 
                }
                while (t <= 6.3);
            }
            while (t <= 6.3);
        }
    }
}

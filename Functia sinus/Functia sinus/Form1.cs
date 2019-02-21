using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Functia_sinus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_blue;
            Creion_blue = new System.Drawing.Pen(System.Drawing.Color.DeepSkyBlue);
            Desen.Clear(this.BackColor);
            do
            {
                int factor_s = this.Height / 2 - 22;
                int y = System.Convert.ToInt16(5 + factor_s * (1 - System.Math.Sin(0.0314 * i)));
                Desen.DrawLine(Creion_blue, i, this.Height, i, y);
                i += 2;
            }
            while (i <= this.Width);
        }
    }
}

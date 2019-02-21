using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i=0;
	System.Drawing.Graphics Desen;
	Desen = this.CreateGraphics();
	System.Drawing.Pen Creion_gri;
	Creion_gri= new System.Drawing.Pen(System.Drawing.Color.LightGray);
	Desen.Clear(this.BackColor);
	// linii verticale
	while (i<=this.Width){
	Desen.DrawLine(Creion_gri, i, 0, i,this.Height);
	i+=10;
	}
	// linii orizontale
	i=0;
	while (i<=this.Height)
    {
	Desen.DrawLine(Creion_gri, 0, i,this.Width,i);
	i+=10;
	}
        }
    }
}

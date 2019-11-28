using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Redondo r = new Redondo();

        private void Button1_Click_1(object sender, EventArgs e)
        {
            r.Raio = textBox1.Text;
            if (radioButton1.Checked) label1.Text = r.Area;
            else if (radioButton2.Checked) label1.Text = r.Perimetro;
            else if (radioButton3.Checked) label1.Text = r.Diametro;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(PyramidA.Text);
            double h = Convert.ToDouble(PyramidH.Text);
            double r = Convert.ToDouble(SphereR.Text);
           
            Solid pyramid = new Pyramid(a, h);
            Solid sphere = new Sphere(r);

            // Виводимо результати
            lblPyramidVolume.Text = "Об'єм піраміди: " + pyramid.GetVolume().ToString("F2");
            lblSphereVolume.Text = "Об'єм кулі: " + sphere.GetVolume().ToString("F2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    

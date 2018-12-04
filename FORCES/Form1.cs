using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }
        double sin(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Sin(rad);
        }
        double cos(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Cos(rad);
        }
        double tan(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Tan(rad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Angle = double.Parse(textBox1.Text);
                double ans = sin(Angle);
                label1.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("enter a number ");
            }
        }
    }
}

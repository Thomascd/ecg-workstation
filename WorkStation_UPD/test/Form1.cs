using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text);
            textBox2.Text = value1.ToString();

            Double value2 = Double.Parse(textBox1.Text);
            textBox3.Text = value2.ToString();
        }
    }
}

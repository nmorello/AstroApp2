using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rev_B_App
{
    public partial class AmpForm : Form
    {
        public AmpForm()
        {
            InitializeComponent();
        }

        public static string amplitude;
        public static string unit, volt;

        public void button1_Click(object sender, EventArgs e)
        {
            amplitude = textBox1.Text;
            if(ampdrop.Text == "mV")
            {
                volt = "mV";
                unit = ampdrop.Text;
            }
            else if(ampdrop.Text == "V")
            {
                volt = "V";
                unit = ampdrop.Text;

            }
            

            this.Close();
        }

        public static int amp = Int32.Parse(amplitude) / 1000;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }
    }
}

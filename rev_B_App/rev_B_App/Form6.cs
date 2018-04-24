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
    public partial class FreqForm : Form
    {
        public FreqForm()
        {
            InitializeComponent();
        }


        public static string frequency;
        public static string unit;

        public void button1_Click(object sender, EventArgs e)
        {
            frequency = textBox1.Text;
            unit = freqdrop.Text;
            
            
            this.Close();
        }

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

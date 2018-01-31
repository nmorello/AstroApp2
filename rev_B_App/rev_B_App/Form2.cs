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
    public partial class Form2 : Form
    {
        public static string selectedWave = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedWave = button3.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedWave = button1.Text;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedWave = button2.Text;
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedWave = button9.Text;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedWave = button5.Text;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedWave = button8.Text;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedWave = button7.Text;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedWave = button10.Text;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedWave = button6.Text;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedWave = button4.Text;
            this.Close();
        }
    }
}

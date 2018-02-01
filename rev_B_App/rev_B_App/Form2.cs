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
        public static string prevWave = "Start";

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedWave = button3.Text;
            prevWave = button3.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedWave = button1.Text;
            prevWave = button1.Text;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedWave = button2.Text;
            prevWave = button2.Text;
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if( selectedWave == prevWave)
            {
               
                this.Close();
            }
            else
            {
                selectedWave = "Start";
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedWave = button9.Text;
            prevWave = button9.Text;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedWave = button5.Text;
            prevWave = button5.Text;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedWave = button8.Text;
            prevWave = button8.Text;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedWave = button7.Text;
            prevWave = button7.Text;
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedWave = button10.Text;
            prevWave = button10.Text;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedWave = button6.Text;
            prevWave = button6.Text;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedWave = button4.Text;
            prevWave = button4.Text;
            this.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.Text == "D")
            {
                freqbox.Enabled = false;
                freqdrop.Enabled = false;
                ampbox.Enabled = false;
                ampdrop.Enabled = false;
            }
           
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 waveList = new Form2();
            waveList.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
        }
    }
}

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
        public static string selectedWave;
        public static string prevWave = "Sine";

        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button3.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button1.Text;
            //MessageBox.Show(prevWave, selectedWave);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button2.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button9.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button5.Text;
            //MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button8.Text;
            //MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button7.Text;
            //MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button10.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button6.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prevWave = selectedWave;
            selectedWave = button4.Text;
           // MessageBox.Show(prevWave, selectedWave);
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (selectedWave != prevWave)
            {

                this.Close();
            }
            else
            {
                selectedWave = prevWave;
                this.Close();
            }

        }
    }
}

﻿using System;
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
            comboBox3.SelectedIndex = 0;
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
           else
            {
                freqbox.Enabled = true;
                freqdrop.Enabled = true;
                ampbox.Enabled = true;
                ampdrop.Enabled = true;
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();

            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":
                     
                     waveList.ShowDialog();
                     label5.Text = Form2.selectedWave;
                    break;

                case "B":
                    
                    waveList.ShowDialog();
                    label5.Text = Form2.selectedWave;
                    break;

                case "C":
                    
                    waveList.ShowDialog();
                    label5.Text = Form2.selectedWave;
                    break;

                case "D":
                    Form3 setup = new Form3();
                    setup.ShowDialog();
                    break;

            }
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label6.Text = Form2.selectedWave;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label7.Text = Form2.selectedWave;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label8.Text = Form2.selectedWave;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label9.Text = Form2.selectedWave;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label10.Text = Form2.selectedWave;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label11.Text = Form2.selectedWave;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 waveList = new Form2();
            waveList.ShowDialog();
            label12.Text = Form2.selectedWave;
        }

     

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void freqbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void freqbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }

            
        }

        private void ampbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
         

            
            status.Text = "Connected";
        }
    }
}

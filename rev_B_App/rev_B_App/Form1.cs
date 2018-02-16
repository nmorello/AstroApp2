using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace rev_B_App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            //Launch Screen Timer
            Thread l = new Thread(new ThreadStart(LaunchScreen));
            l.Start();
            Thread.Sleep(5000);

            
            //Initializing dropdown menus
            InitializeComponent();
            comboBox3.SelectedIndex = 0;
            freqdrop.SelectedIndex = 0;
            ampdrop.SelectedIndex = 0;
            //close Launch Screen
            l.Abort();
            //Allows main form to pop up in front of any other open windows
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        public void LaunchScreen()
        {
            //Luanch Screen physical form
            Application.Run(new Form4());
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disbale master freq and amp if bank d selected
            if(comboBox3.Text == "D")
            {
                freqbox.Enabled = false;
                freqdrop.Enabled = false;
                ampbox.Enabled = false;
                ampdrop.Enabled = false;
                desbut1.Enabled = true;
                desbut2.Enabled = true;
                desbut3.Enabled = true;
                desbut4.Enabled = true;
                desbut5.Enabled = true;
                desbut6.Enabled = true;
                desbut7.Enabled = true;
                desbut8.Enabled = true;
                label5.Text = "Sine";
                label6.Text = "Sine";
                label7.Text = "Sine";
                label8.Text = "Sine";
                label9.Text = "Sine";
                label10.Text = "Sine";
                label11.Text = "Sine";
                label12.Text = "Sine";


            }
           else
            {
                freqbox.Enabled = true;
                freqdrop.Enabled = true;
                ampbox.Enabled = true;
                ampdrop.Enabled = true;
                desbut1.Enabled = false;
                desbut2.Enabled = false;
                desbut3.Enabled = false;
                desbut4.Enabled = false;
                desbut5.Enabled = false;
                desbut6.Enabled = false;
                desbut7.Enabled = false;
                desbut8.Enabled = false;
                label5.Text = "Sine";
                label6.Text = "Sine";
                label7.Text = "Sine";
                label8.Text = "Sine";
                label9.Text = "Sine";
                label10.Text = "Sine";
                label11.Text = "Sine";
                label12.Text = "Sine";
            }
     
        }

    
        public void button1_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();
        

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
                    
                    setup.ShowDialog();
                    label5.Text = Form3.customWave;
                    break;

            }
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label6.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label6.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label6.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label6.Text = Form3.customWave;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label7.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label7.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label7.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label7.Text = Form3.customWave;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label8.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label8.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label8.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label8.Text = Form3.customWave;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label9.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label9.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label9.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label9.Text = Form3.customWave;
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label10.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label10.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label10.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label10.Text = Form3.customWave;
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label11.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label11.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label11.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label11.Text = Form3.customWave;
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString())
            {

                case "A":

                    waveList.ShowDialog();
                    label12.Text = Form2.selectedWave;
                    break;

                case "B":

                    waveList.ShowDialog();
                    label12.Text = Form2.selectedWave;
                    break;

                case "C":

                    waveList.ShowDialog();
                    label12.Text = Form2.selectedWave;
                    break;

                case "D":

                    setup.ShowDialog();
                    label12.Text = Form3.customWave;
                    break;
            }
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

        private void desbut1_Click(object sender, EventArgs e)
        {
            Form5 parameters = new Form5();
            parameters.ShowDialog();
        }

        public class BankList
        {
            

        }

        private void desbut2_Click(object sender, EventArgs e)
        {
            Form5 parameters = new Form5();
            parameters.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = "Sine";
            label6.Text = "Sine";
            label7.Text = "Sine";
            label8.Text = "Sine";
            label9.Text = "Sine";
            label10.Text = "Sine";
            label11.Text = "Sine";
            label12.Text = "Sine";
        }
    }
}

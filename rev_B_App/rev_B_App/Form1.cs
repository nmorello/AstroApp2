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
        public static string wave1, wave2, wave3, wave4, wave5, wave6, wave7, wave8;

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
            if (comboBox3.Text == "D")
            {
                freqbox.Enabled = false;
                freqdrop.Enabled = false;
                ampbox.Enabled = false;
                ampdrop.Enabled = false;
                desbut1.Enabled = true;
                button11.Enabled = false;
                saveBank.Enabled = false;
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
                button11.Enabled = true;
                saveBank.Enabled = true;
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
                    wave1 = label5.Text;
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
                    wave2 = label6.Text;
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
                    wave3 = label7.Text;
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
                    wave4 = label8.Text;
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
                    wave5 = label9.Text;
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
                    wave6 = label10.Text;
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
                    wave7 = label11.Text;
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //variables for wave select and custom wave
            Form2 waveList = new Form2();
            Form3 setup = new Form3();


            switch (comboBox3.SelectedItem.ToString()) //switch case for banks
            {

                case "A":

                    waveList.ShowDialog();//show possible selections
                    label12.Text = Form2.selectedWave;//write selection text to main form
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
                    wave8 = label12.Text;
                    break;
            }
        }

     
        private void freqbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
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


        private void button9_Click(object sender, EventArgs e)
        {

            status.Text = "Connected";
        }

        private void desbut1_Click(object sender, EventArgs e)
        {
            Form5 parameters = new Form5();
            parameters.ShowDialog();
        }

        private void desbut2_Click(object sender, EventArgs e)
        {
            Form5 parameters = new Form5();
            parameters.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                //restores selected bank to default values
                case "A":
                    label5.Text = "Sine";
                    label6.Text = "Sine";
                    label7.Text = "Sine";
                    label8.Text = "Sine";
                    label9.Text = "Sine";
                    label10.Text = "Sine";
                    label11.Text = "Sine";
                    label12.Text = "Sine";
                    break;

                case "B":
                    label5.Text = "Sine";
                    label6.Text = "Sine";
                    label7.Text = "Sine";
                    label8.Text = "Sine";
                    label9.Text = "Sine";
                    label10.Text = "Sine";
                    label11.Text = "Sine";
                    label12.Text = "Sine";

                    break;

                case "C":
                    label5.Text = "Sine";
                    label6.Text = "Sine";
                    label7.Text = "Sine";
                    label8.Text = "Sine";
                    label9.Text = "Sine";
                    label10.Text = "Sine";
                    label11.Text = "Sine";
                    label12.Text = "Sine";

                    break;

                case "D":
                    label5.Text = "Sine";
                    label6.Text = "Sine";
                    label7.Text = "Sine";
                    label8.Text = "Sine";
                    label9.Text = "Sine";
                    label10.Text = "Sine";
                    label11.Text = "Sine";
                    label12.Text = "Sine";

                    break;
            }
        }

        string save = "";
        string[] saved = new string[8];

        public void saveBank_Click(object sender, EventArgs e)
        {
          
            saved[0] = label5.Text;
            saved[1] = label6.Text;
            saved[2] = label7.Text;
            saved[3] = label8.Text;
            saved[4] = label9.Text;
            saved[5] = label10.Text;
            saved[6] = label11.Text;
            saved[7] = label12.Text;
                foreach (var item in saved)
                 {
                    save += item + "\n";
                 }

            MessageBox.Show(save);



        }

        

        private void button11_Click(object sender, EventArgs e)
        { 


            label5.Text = saved[0];
            label6.Text = saved[1];
            label7.Text = saved[2];
            label8.Text = saved[3];
            label9.Text = saved[4];
            label10.Text = saved[5];
            label11.Text = saved[6];
            label12.Text = saved[7];

        }
    }
}

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
using System.IO.Ports;

namespace rev_B_App
{
    public partial class Form1 : Form
    {
        public static string wave1, wave2, wave3, wave4, wave5, wave6, wave7, wave8;
        public static int[] channel1 = new int[6];
        public static int[] channel2 = new int[6];
        public static int[] channel3 = new int[6];
        public static int[] channel4 = new int[6];
        public static int[] channel5 = new int[6];
        public static int[] channel6 = new int[6];
        public static int[] channel7 = new int[6];
        public static int[] channel8 = new int[6];

       
        public SerialPort myport; //Initialize Serial port
        public bool isconnected; //bool for seial port connection

        public static string a1, a2, a3, a4, a5, a6, a7, a8;

        public Form1()
        {
            //Launch Screen Timer
            Thread l = new Thread(new ThreadStart(LaunchScreen));
            l.Start();
            Thread.Sleep(3000);


            //Initializing dropdown menus
            InitializeComponent();
            comboBox3.SelectedIndex = 0;
            
       
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
            Application.Run(new AstroNova());

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(isconnected == true) //check if serial port is connected
            {
                string bank = comboBox3.Text;
                myport.WriteLine("BANK " + bank);//change bank when drop down changes
            }

            
            //Disbale master freq and amp if bank d selected
            if (comboBox3.Text == "D")
            {
                
               

                freqBtn.Enabled = false;
                ampBtn.Enabled = false;
                desbut1.Enabled = true;
                

            }
            else //enable if bank D is not selected
            {               

                freqBtn.Enabled = true;
                ampBtn.Enabled = true;
                desbut1.Enabled = false;
            
               
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
                    label5.Text = Form2.selectedWave; //changes label to selected wave
                    
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

     
   

       public async void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your COM Port!");
            }
            else
            {
                if (button9.Text == "Disconnect")
                {
                    myport.WriteLine("KILL ");
                    status.Text = "Disconnected";
                    button9.Text = "Connect to WG-800";
                    myport.Close();
                }
                else
                {
                    connhost();
                    if (isconnected == true)
                    {

                        myport.WriteLine("HOST ");
                        status.Text = "Connected";
                        button9.Text = "Disconnect";

                        //myport.WriteLine("STAT?");
                        //await Task.Delay(1000);
                        //string stat = myport.ReadExisting();

                        myport.WriteLine("\n");
                        await Task.Delay(500);

                        myport.WriteLine("BANK?");
                        await Task.Delay(500);
                        string bankcheck = myport.ReadExisting();
                        comboBox3.Text = bankcheck;
                        

                    }
                    else
                    {
                        status.Text = "Disconnected";
                    }
                }
            }
        }

        public void connhost()
        {
            string commport = textBox1.Text;

            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM" + commport;
                myport.Open();
                isconnected = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Error in Connection!");
                isconnected = false;

            }
        }

        private void statcheck()
        {
           //this will check if connected once later implemented on board
        }
      

        private void ampbox_TextChanged(object sender, EventArgs e)
        {
            string changeamp = ampBtn.Text;
            int v = int.Parse(ampBtn.Text);
            int mv = v * 1000;

            if (isconnected == true)
            {
                if (ampBtn.Text == "mV")
                {
                    myport.WriteLine("AMPL " + v);
                }
                else
                {
                    myport.WriteLine("AMPL " + mv);
                }
            }
        }



        public void label5_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 1;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label5.Text == "Sine")
                    {
                        x = 0;

                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label5.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
        
        }

        public void label6_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 2;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label6.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label6.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
            
        }


//SINE
//SINE90
//SINE120
//SINE240
//SQUARE
//PULS25+
//PULS75+
//PULS25-
//PULS75-
//TRI
//SAWUP
//SAWDOWN


     

        private async void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            
            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?1," + comboBox3.Text);
            await Task.Delay(2000);
            string c1 = myport.ReadExisting();

            // MessageBox.Show(c1); //for debugging, returns number corresponding to wave documentation

            if (c1 == "0\0\0\0")
            {
                label5.Text = "Sine";
            }
            else if (c1 == "1\0\0\0")
            {
                label5.Text = "Sine 90";
            }
            else if (c1 == "2\0\0\0")
            {
                label5.Text = "Sine 120";
            }
            else if (c1 == "3\0\0\0")
            {
                label5.Text = "Sine 240";
            }
            else if (c1 == "4\0\0\0")
            {
                label5.Text = "Square";
            }
            else if (c1 == "5\0\0\0")
            {
                label5.Text = "Pulse +25% Duty";
            }
            else if (c1 == "6\0\0\0")
            {
                label5.Text = "Pulse +75% Duty";
            }
            else if (c1 == "7\0\0\0")
            {
                label5.Text = "Pulse -25% Duty";
            }
            else if (c1 == "8\0\0\0")
            {
                label5.Text = "Pulse -75% Duty";
            }
            else if (c1 == "9\0\0\0")
            {
                label5.Text = "Triangle";
            }
            else if (c1 == "10\0\0\0")
            {
                label5.Text = "Saw Up";
            }
            else if (c1 == "11\0\0\0")
            {
                label5.Text = "Saw Down";
            }
            else if (c1 == "12\0\0\0")
            {
                label5.Text = "Arbitrary Sine";
            }
            else if (c1 == "13\0\0\0")
            {
                label5.Text = "Arbitrary Pulse";
            }

            ////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?2," + comboBox3.Text);
            await Task.Delay(2000);
            string c2 = myport.ReadExisting();

            // MessageBox.Show(c2); //for debugging, returns number corresponding to wave documentation

            if (c2 == "0\0\0\0")
            {
                label6.Text = "Sine";
            }
            else if (c2 == "1\0\0\0")
            {
                label6.Text = "Sine 90";
            }
            else if (c2 == "2\0\0\0")
            {
                label6.Text = "Sine 120";
            }
            else if (c2 == "3\0\0\0")
            {
                label6.Text = "Sine 240";
            }
            else if (c2 == "4\0\0\0")
            {
                label5.Text = "Square";
            }
            else if (c2 == "5\0\0\0")
            {
                label6.Text = "Pulse +25% Duty";
            }
            else if (c2 == "6\0\0\0")
            {
                label6.Text = "Pulse +75% Duty";
            }
            else if (c2 == "7\0\0\0")
            {
                label6.Text = "Pulse -25% Duty";
            }
            else if (c2 == "8\0\0\0")
            {
                label6.Text = "Pulse -75% Duty";
            }
            else if (c2 == "9\0\0\0")
            {
                label6.Text = "Triangle";
            }
            else if (c2 == "10\0\0\0")
            {
                label6.Text = "Saw Up";
            }
            else if (c2 == "11\0\0\0")
            {
                label6.Text = "Saw Down";
            }
            else if (c2 == "12\0\0\0")
            {
                label6.Text = "Arbitrary Sine";
            }
            else if (c2 == "13\0\0\0")
            {
                label6.Text = "Arbitrary Pulse";
            }

            //////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?3," + comboBox3.Text);
            await Task.Delay(2000);
            string c3 = myport.ReadExisting();

            // MessageBox.Show(c3); //for debugging, returns number corresponding to wave documentation

            if (c3 == "0\0\0\0")
            {
                label7.Text = "Sine";
            }
            else if (c3 == "1\0\0\0")
            {
                label7.Text = "Sine 90";
            }
            else if (c3 == "2\0\0\0")
            {
                label7.Text = "Sine 120";
            }
            else if (c3 == "3\0\0\0")
            {
                label7.Text = "Sine 240";
            }
            else if (c3 == "4\0\0\0")
            {
                label7.Text = "Square";
            }
            else if (c3 == "5\0\0\0")
            {
                label7.Text = "Pulse +25% Duty";
            }
            else if (c3 == "6\0\0\0")
            {
                label7.Text = "Pulse +75% Duty";
            }
            else if (c3 == "7\0\0\0")
            {
                label7.Text = "Pulse -25% Duty";
            }
            else if (c3 == "8\0\0\0")
            {
                label7.Text = "Pulse -75% Duty";
            }
            else if (c3 == "9\0\0\0")
            {
                label7.Text = "Triangle";
            }
            else if (c3 == "10\0\0\0")
            {
                label7.Text = "Saw Up";
            }
            else if (c3 == "11\0\0\0")
            {
                label7.Text = "Saw Down";
            }
            else if (c3 == "12\0\0\0")
            {
                label7.Text = "Arbitrary Sine";
            }
            else if (c3 == "13\0\0\0")
            {
                label7.Text = "Arbitrary Pulse";
            }

            ///////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?4," + comboBox3.Text);
            await Task.Delay(2000);
            string c4 = myport.ReadExisting();

            // MessageBox.Show(c4); //for debugging, returns number corresponding to wave documentation

            if (c4 == "0\0\0\0")
            {
                label8.Text = "Sine";
            }
            else if (c4 == "1\0\0\0")
            {
                label8.Text = "Sine 90";
            }
            else if (c4 == "2\0\0\0")
            {
                label8.Text = "Sine 120";
            }
            else if (c4 == "3\0\0\0")
            {
                label8.Text = "Sine 240";
            }
            else if (c4 == "4\0\0\0")
            {
                label8.Text = "Square";
            }
            else if (c4 == "5\0\0\0")
            {
                label8.Text = "Pulse +25% Duty";
            }
            else if (c4 == "6\0\0\0")
            {
                label8.Text = "Pulse +75% Duty";
            }
            else if (c4 == "7\0\0\0")
            {
                label8.Text = "Pulse -25% Duty";
            }
            else if (c4 == "8\0\0\0")
            {
                label8.Text = "Pulse -75% Duty";
            }
            else if (c4 == "9\0\0\0")
            {
                label8.Text = "Triangle";
            }
            else if (c4 == "10\0\0\0")
            {
                label8.Text = "Saw Up";
            }
            else if (c4 == "11\0\0\0")
            {
                label8.Text = "Saw Down";
            }
            else if (c4 == "12\0\0\0")
            {
                label8.Text = "Arbitrary Sine";
            }
            else if (c4 == "13\0\0\0")
            {
                label8.Text = "Arbitrary Pulse";
            }

            /////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?5," + comboBox3.Text);
            await Task.Delay(2000);
            string c5 = myport.ReadExisting();

           // MessageBox.Show(c5); //for debugging, returns number corresponding to wave documentation

            if (c5 == "0\0\0\0")
            {
                label9.Text = "Sine";
            }
            else if (c5 == "1\0\0\0")
            {
                label9.Text = "Sine 90";
            }
            else if (c5 == "2\0\0\0")
            {
                label9.Text = "Sine 120";
            }
            else if (c5 == "3\0\0\0")
            {
                label9.Text = "Sine 240";
            }
            else if (c5 == "4\0\0\0")
            {
                label9.Text = "Square";
            }
            else if (c5 == "5\0\0\0")
            {
                label9.Text = "Pulse +25% Duty";
            }
            else if (c5 == "6\0\0\0")
            {
                label9.Text = "Pulse +75% Duty";
            }
            else if (c5 == "7\0\0\0")
            {
                label9.Text = "Pulse -25% Duty";
            }
            else if (c5 == "8\0\0\0")
            {
                label9.Text = "Pulse -75% Duty";
            }
            else if (c5 == "9\0\0\0")
            {
                label9.Text = "Triangle";
            }
            else if (c5 == "10\0\0\0")
            {
                label9.Text = "Saw Up";
            }
            else if (c5 == "11\0\0\0")
            {
                label9.Text = "Saw Down";
            }
            else if (c5 == "12\0\0\0")
            {
                label9.Text = "Arbitrary Sine";
            }
            else if (c5 == "13\0\0\0")
            {
                label9.Text = "Arbitrary Pulse";
            }

            ////////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?6," + comboBox3.Text);
            await Task.Delay(2000);
            string c6 = myport.ReadExisting();

            // MessageBox.Show(c6); //for debugging, returns number corresponding to wave documentation

            if (c6 == "0\0\0\0")
            {
                label10.Text = "Sine";
            }
            else if (c6 == "1\0\0\0")
            {
                label10.Text = "Sine 90";
            }
            else if (c6 == "2\0\0\0")
            {
                label10.Text = "Sine 120";
            }
            else if (c6 == "3\0\0\0")
            {
                label10.Text = "Sine 240";
            }
            else if (c6 == "4\0\0\0")
            {
                label10.Text = "Square";
            }
            else if (c6 == "5\0\0\0")
            {
                label10.Text = "Pulse +25% Duty";
            }
            else if (c6 == "6\0\0\0")
            {
                label10.Text = "Pulse +75% Duty";
            }
            else if (c6 == "7\0\0\0")
            {
                label10.Text = "Pulse -25% Duty";
            }
            else if (c6 == "8\0\0\0")
            {
                label10.Text = "Pulse -75% Duty";
            }
            else if (c6 == "9\0\0\0")
            {
                label10.Text = "Triangle";
            }
            else if (c6 == "10\0\0\0")
            {
                label10.Text = "Saw Up";
            }
            else if (c6 == "11\0\0\0")
            {
                label10.Text = "Saw Down";
            }
            else if (c6 == "12\0\0\0")
            {
                label10.Text = "Arbitrary Sine";
            }
            else if (c6 == "13\0\0\0")
            {
                label10.Text = "Arbitrary Pulse";
            }

            ///////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?7," + comboBox3.Text);
            await Task.Delay(2000);
            string c7 = myport.ReadExisting();

            // MessageBox.Show(c7); //for debugging, returns number corresponding to wave documentation

            if (c7 == "0\0\0\0")
            {
                label11.Text = "Sine";
            }
            else if (c7 == "1\0\0\0")
            {
                label11.Text = "Sine 90";
            }
            else if (c7 == "2\0\0\0")
            {
                label11.Text = "Sine 120";
            }
            else if (c7 == "3\0\0\0")
            {
                label11.Text = "Sine 240";
            }
            else if (c7 == "4\0\0\0")
            {
                label11.Text = "Square";
            }
            else if (c7 == "5\0\0\0")
            {
                label11.Text = "Pulse +25% Duty";
            }
            else if (c7 == "6\0\0\0")
            {
                label11.Text = "Pulse +75% Duty";
            }
            else if (c7 == "7\0\0\0")
            {
                label11.Text = "Pulse -25% Duty";
            }
            else if (c7 == "8\0\0\0")
            {
                label11.Text = "Pulse -75% Duty";
            }
            else if (c7 == "9\0\0\0")
            {
                label11.Text = "Triangle";
            }
            else if (c7 == "10\0\0\0")
            {
                label11.Text = "Saw Up";
            }
            else if (c7 == "11\0\0\0")
            {
                label11.Text = "Saw Down";
            }
            else if (c7 == "12\0\0\0")
            {
                label11.Text = "Arbitrary Sine";
            }
            else if (c7 == "13\0\0\0")
            {
                label11.Text = "Arbitrary Pulse";
            }

            /////////////////////////////////////

            myport.WriteLine("\n");
            await Task.Delay(600);

            myport.WriteLine("WAVE?8," + comboBox3.Text);
            await Task.Delay(2000);
            string c8 = myport.ReadExisting();

           // MessageBox.Show(c8); //for debugging, returns number corresponding to wave documentation

            if (c8 == "0\0\0\0")
            {
                label12.Text = "Sine";
            }
            else if (c8 == "1\0\0\0")
            {
                label12.Text = "Sine 90";
            }
            else if (c8 == "2\0\0\0")
            {
                label12.Text = "Sine 120";
            }
            else if (c8 == "3\0\0\0")
            {
                label12.Text = "Sine 240";
            }
            else if (c8 == "4\0\0\0")
            {
                label12.Text = "Square";
            }
            else if (c8 == "5\0\0\0")
            {
                label12.Text = "Pulse +25% Duty";
            }
            else if (c8 == "6\0\0\0")
            {
                label12.Text = "Pulse +75% Duty";
            }
            else if (c8 == "7\0\0\0")
            {
                label12.Text = "Pulse -25% Duty";
            }
            else if (c8 == "8\0\0\0")
            {
                label12.Text = "Pulse -75% Duty";
            }
            else if (c8 == "9\0\0\0")
            {
                label12.Text = "Triangle";
            }
            else if (c8 == "10\0\0\0")
            {
                label12.Text = "Saw Up";
            }
            else if (c8 == "11\0\0\0")
            {
                label12.Text = "Saw Down";
            }
            else if (c8 == "12\0\0\0")
            {
                label12.Text = "Arbitrary Sine";
            }
            else if (c8 == "13\0\0\0")
            {
                label12.Text = "Arbitrary Pulse";
            }


        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 3;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label7.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label7.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
           
        }

        public void ampBtn_Click(object sender, EventArgs e)
        {
            AmpForm frm = new AmpForm();
            {
                frm.ShowDialog();

                ampBtn.Text = AmpForm.amplitude + " " + AmpForm.unit;
            }
        }

        private void ampBtn_TextChanged_1(object sender, EventArgs e)
        {
            if (isconnected == true)
            {
                if (AmpForm.volt == "V")
                {
                    myport.WriteLine("AMPL " + AmpForm.amp);
                }
                else if (AmpForm.volt == "mV")
                {
                    myport.WriteLine("AMPL " + AmpForm.amplitude);
                }
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 4;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label8.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label8.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
           
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 5;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label9.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label9.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }

                }
            }
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 6;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label10.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label10.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
            
        }

        private void label11_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 7;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label11.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label11.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
        }

        public void freqBtn_TextChanged(object sender, EventArgs e)
        {
            if (isconnected)
            {
                if (FreqForm.unit == "Hz")
                { 

                myport.WriteLine("FREQ " + FreqForm.frequency);

                }
                else if(FreqForm.unit == "kHz")
                {

                    myport.WriteLine("FREQ " + FreqForm.frequency + "000");
                }
            }
        }


        public void button11_Click(object sender, EventArgs e)
        {

           
            FreqForm frm = new FreqForm();
            {
                frm.ShowDialog();

                freqBtn.Text = FreqForm.frequency + " " + FreqForm.unit;
            }
            
        }

      






        public void ampBtn_TextChanged(object sender, EventArgs e)
        {
            //myport.WriteLine("AMPL " + amp);
        }


        private void label12_TextChanged(object sender, EventArgs e)
        {
            string b = comboBox3.Text;
            int i = 8;
            int x;
            if (isconnected == true)
            {
                if (comboBox3.Text != "D")
                {
                    if (label12.Text == "Sine")
                    {
                        x = 0;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Sin @ 90")
                    {
                        x = 1;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Sin @ 120")
                    {
                        x = 2;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Sin @ 240")
                    {
                        x = 3;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Square")
                    {
                        x = 4;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Pulse 25% Duty")
                    {
                        x = 5;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Pulse 75% Duty")
                    {
                        x = 6;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Pulse -25% Duty")
                    {
                        x = 7;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Pulse -75% Duty")
                    {
                        x = 8;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Triangle")
                    {
                        x = 9;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Saw Up")
                    {
                        x = 10;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Saw Down")
                    {
                        x = 11;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Arbitrary Sine")
                    {
                        x = 12;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else if (label12.Text == "Arbitrary Pulse")
                    {
                        x = 13;
                        if (isconnected == true)
                        {
                            myport.WriteLine("WAVE " + i + "," + b + "," + x);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Error! No Wave Selected!");
                    }
                }
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string commport = textBox1.Text;
        }

 

        private void desbut1_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters();
            parameters.ShowDialog();
        }


        private async void button10_Click(object sender, EventArgs e)
        {
            freqBtn.Text = "1 Hz";
            ampBtn.Text = "1 V";

            if(isconnected)
            {
                myport.WriteLine("FREQ 1");
                myport.WriteLine("AMPL 1000");
            }

            switch (comboBox3.SelectedItem.ToString())
            {
                //restores selected bank to default values
                case "A":
                    label5.Text = "Sine";
                    label6.Text = "Square";
                    label7.Text = "Triangle";
                    label8.Text = "Pulse 25% Duty";
                    label9.Text = "Saw Down";
                    label10.Text = "Sine 90";
                    label11.Text = "Saw Up";
                    label12.Text = "Pulse -75% Duty";


                    await Task.Delay(1000);

                    break;

                case "B":
                    label5.Text = "Pulse 75% Duty";
                    label6.Text = "Sine 90";
                    label7.Text = "Pulse -25% Duty";
                    label8.Text = "Saw Down";
                    label9.Text = "Triangle";
                    label10.Text = "Sine";
                    label11.Text = "Square";
                    label12.Text = "Saw Up";

                    break;

                case "C":
                    label5.Text = "Sine";
                    label6.Text = "Sine 90";
                    label7.Text = "Sine 120";
                    label8.Text = "Sine 240";
                    label9.Text = "Pulse 25% Duty";
                    label10.Text = "Pulse 75% Duty";
                    label11.Text = "Pulse -25% Duty";
                    label12.Text = "Pulse -75% Duty";

                    break;

                case "D":
                    label5.Text = "Sine";
                    label6.Text = "Square";
                    label7.Text = "Pulse";
                    label8.Text = "Triangle";
                    label9.Text = "Saw Up";
                    label10.Text = "DC";
                    label11.Text = "Sine";
                    label12.Text = "Arb";

                    break;
            }
        }
    }
}

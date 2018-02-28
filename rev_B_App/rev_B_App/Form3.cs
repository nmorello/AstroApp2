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
    

    public partial class Form3 : Form
    {
        public static string customWave, freq, amp, offs, phaset, rampt, volt, dutyt, loopc, timed;

     

        public Form3()
        {
            InitializeComponent();
            modeSelect.SelectedIndex = 0;
            posOrNeg.SelectedIndex = 0;

        }

        private void freqIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void ampIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void voltageIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void timeDIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void offsetIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void dutyIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void phaseIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void rampTimeIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void loopIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Numbers Only");
            }
        }


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (modeSelect.SelectedItem.ToString())

            {
                case "DC":
                    frequency.Visible = false;
                    phase.Visible = false;
                    offset.Visible = false;
                    amplitude.Visible = false;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = true;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = true;
                    timeDIn.Visible = false;
                    freqIn.Visible = false;
                    phaseIn.Visible = false;
                    ampIn.Visible = false;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = false;
                    loopIn.Visible = false;
                    customWave = "DC";
                    break;

                case "Sine":
                    frequency.Visible = true;
                    phase.Visible = true;
                    offset.Visible = true;
                    amplitude.Visible = true;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = true;
                    phaseIn.Visible = true;
                    ampIn.Visible = true;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = true;
                    loopIn.Visible = false;
                    customWave = "Sine";
                    break;

                case "Square":
                    frequency.Visible = true;
                    phase.Visible = true;
                    offset.Visible = true;
                    amplitude.Visible = true;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = true;
                    phaseIn.Visible = true;
                    ampIn.Visible = true;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = true;
                    loopIn.Visible = false;
                    customWave = "Square";
                    break;

                case "Pulse":
                    frequency.Visible = true;
                    phase.Visible = false;
                    offset.Visible = true;
                    amplitude.Visible = true;
                    duty.Visible = true;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = true;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = true;
                    phaseIn.Visible = false;
                    ampIn.Visible = true;
                    dutyIn.Visible = true;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = true;
                    loopIn.Visible = false;
                    customWave = "Pulse";
                    break;

                case "Triangle":
                    frequency.Visible = true;
                    phase.Visible = false;
                    offset.Visible = true;
                    amplitude.Visible = true;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = true;
                    phaseIn.Visible = false;
                    ampIn.Visible = true;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = true;
                    loopIn.Visible = false;
                    customWave = "Triangle";
                    break;

                case "Sawtooth":
                    frequency.Visible = true;
                    phase.Visible = false;
                    offset.Visible = true;
                    amplitude.Visible = true;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = true;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = true;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = true;
                    phaseIn.Visible = false;
                    ampIn.Visible = true;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = true;
                    offsetIn.Visible = true;
                    loopIn.Visible = false;
                    customWave = "Sawtooth";
                    break;

                case "Arb":
                    frequency.Visible = false;
                    phase.Visible = false;
                    offset.Visible = false;
                    amplitude.Visible = false;
                    duty.Visible = false;
                    loopCount.Visible = true;
                    rampTime.Visible = false;
                    timeDelta.Visible = true;
                    voltage.Visible = false;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = false;
                    timeDIn.Visible = true;
                    freqIn.Visible = false;
                    phaseIn.Visible = false;
                    ampIn.Visible = false;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = false;
                    loopIn.Visible = true;
                    customWave = "Arbitrary";
                    break;

                case "Select":
                    frequency.Visible = false;
                    phase.Visible = false;
                    offset.Visible = false;
                    amplitude.Visible = false;
                    duty.Visible = false;
                    loopCount.Visible = false;
                    rampTime.Visible = false;
                    timeDelta.Visible = false;
                    voltage.Visible = false;
                    posOrNeg.Visible = false;
                    voltageIn.Visible = false;
                    timeDIn.Visible = false;
                    freqIn.Visible = false;
                    phaseIn.Visible = false;
                    ampIn.Visible = false;
                    dutyIn.Visible = false;
                    rampTimeIn.Visible = false;
                    offsetIn.Visible = false;
                    loopIn.Visible = false;
                    customWave = "";
                    break;

            }
        }


        public void selectbut_Click(object sender, EventArgs e)
        {
            switch (modeSelect.SelectedItem.ToString())
            {
                case "DC":

                    volt = voltageIn.Text;
                    break;

                case "Sine":

                    freq = freqIn.Text;
                    amp = ampIn.Text;
                    offs = offsetIn.Text;
                    phaset = phaseIn.Text;
                    break;

                case "Square":

                    freq = freqIn.Text;
                    amp = ampIn.Text;
                    offs = offsetIn.Text;
                    phaset = phaseIn.Text;
                    break;
                case "Pulse":

                    freq = freqIn.Text;
                    amp = ampIn.Text;
                    offs = offsetIn.Text;
                    dutyt = dutyIn.Text;
                    break;
                case "Triangle":
                    freq = freqIn.Text;
                    amp = ampIn.Text;
                    offs = offsetIn.Text;
                    break;

                case "Sawtooth":
                    freq = freqIn.Text;
                    amp = ampIn.Text;
                    offs = offsetIn.Text;
                    rampt = rampTimeIn.Text;
                    break;

                case "Arb":
                    loopc = loopIn.Text;
                    timed = timeDIn.Text;
                    break;

            }

            this.Close();
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   }

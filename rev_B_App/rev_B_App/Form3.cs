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
        public static int freq1, amp1, offs1, phaset1, rampt, volt, dutyt, loopc, timed;
        public static int freq2, freq3, freq4, freq5;
        public static int amp2, amp3, amp4, amp5;
        public static int offs2, offs3, offs4, offs5;
        public static int phaset2, phaset3, phaset4;
        public static string customWave;


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

                    int v;
                    int.TryParse(voltageIn.Text, out v);
                    volt = v;
                    break;

                case "Sine":

                    int f1, a1, o1, p1;
                    //NOTE TO SELf: try to make f for every channel, i.e. f1 f2 f3 f4 etc.
                    int.TryParse(freqIn.Text, out f1);
                    int.TryParse(ampIn.Text, out a1);
                    int.TryParse(offsetIn.Text, out o1);
                    int.TryParse(phaseIn.Text, out p1);
                    freq1 = f1;
                    amp1 = a1;
                    offs1 = o1;
                    phaset1 = p1;
                    break;

                case "Square":

                    int f2, a2, o2, p2;
                    int.TryParse(freqIn.Text, out f2);
                    int.TryParse(ampIn.Text, out a2);
                    int.TryParse(offsetIn.Text, out o2);
                    int.TryParse(phaseIn.Text, out p2);
                    freq2 = f2;
                    amp2 = a2;
                    offs2 = o2;
                    phaset2 = p2;
                    break;
                case "Pulse":

                    int f3, a3, o3, d3;
                    int.TryParse(freqIn.Text, out f3);
                    int.TryParse(ampIn.Text, out a3);
                    int.TryParse(offsetIn.Text, out o3);
                    int.TryParse(dutyIn.Text, out d3);
                    freq3 = f3;
                    amp3 = a3;
                    offs3 = o3;
                    dutyt = d3;
                    break;

                case "Triangle":

                    int f4, a4, o4;
                    int.TryParse(freqIn.Text, out f4);
                    int.TryParse(ampIn.Text, out a4);
                    int.TryParse(offsetIn.Text, out o4);
                    freq4 = f4;
                    amp4 = a4;
                    offs4 = o4;
                    break;

                case "Sawtooth":

                    int f5, a5, o5, r5;
                    int.TryParse(freqIn.Text, out f5);
                    int.TryParse(ampIn.Text, out a5);
                    int.TryParse(offsetIn.Text, out o5);
                    int.TryParse(rampTimeIn.Text, out r5);
                    freq5 = f5;
                    amp5 = a5;
                    offs5 = o5;
                    rampt = r5;
                    break;

                case "Arb":
                    int lc, td;
                    int.TryParse(loopIn.Text, out lc);
                    int.TryParse(timeDIn.Text, out td);
                    loopc = lc;
                    timed = td;
                    
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

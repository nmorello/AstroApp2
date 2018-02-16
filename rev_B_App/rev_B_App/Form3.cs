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
        public static string customWave;
        public static string freq;
        public static string amp;
        public static string offs;
        public static string phaset;
        public static string rampt;
        public static string volt;
        
        public static string wave;

        public Form3()
        {
            InitializeComponent();
            modeSelect.SelectedIndex = 0;
            posOrNeg.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    wave = "DC";
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
                    wave = "Sine";
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
                    wave = "Square";
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
                    wave = "Pulse";
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
                    wave = "Triangle";
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
                    wave = "Sawtooth";
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
                    wave = "Arbitrary";
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
                    wave = "";
                    break;

            }
        }

        private void posOrNeg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void voltageIn_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form3_Load(object sender, EventArgs e)
        { 

        }

        public void selectbut_Click(object sender, EventArgs e)
        {
            customWave = modeSelect.Text;
            freq = freqIn.Text;
            amp = ampIn.Text;
            offs = offsetIn.Text;
            phaset = phaseIn.Text;

            this.Close();
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void freqIn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
   }

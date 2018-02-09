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
                    break;

                case "SINE":
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
                    break;

                case "SQUARE":
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
                    freqIn.Visible = false;
                    break;

                case "PULSE":
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
                    freqIn.Visible = false;
                    break;

                case "TRIANGLE":
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
                    freqIn.Visible = false;
                    break;

                case "SAWTOOTH":
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
                    freqIn.Visible = false;
                    break;

                case "ARB":
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
                    break;

            }
        }

        private void posOrNeg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void voltageIn_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
   }

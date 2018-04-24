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
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();

            //////////////////////////////////////////////////////////////////////////////
            //channel 1 wave/////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////

            //switch (Form1.wave1)
            //{
            //    case "DC":
            if (Form1.wave1 == "DC")
             {
                
                Form1.channel1[0] = Form3.volt;
                p11.Text = Form1.channel1[0] + " V";
                p12.Visible = false;
                p13.Visible = false;
                p14.Visible = false;
            }
                //    case "Sine":
                else if(Form1.wave1 == "Sine")

            {
                Form1.channel1[1] = Form3.freq1;
                Form1.channel1[2] = Form3.amp1;
                Form1.channel1[3] = Form3.offs1;
                Form1.channel1[4] = Form3.phaset1;
                p11.Text = Form1.channel1[1] + " Hz";
                p12.Text = Form1.channel1[2] + " V";
                p13.Text = Form1.channel1[3] + " ";
                p14.Text = Form1.channel1[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave1 == "Square")
            {
                Form1.channel1[1] = Form3.freq2;
                Form1.channel1[2] = Form3.amp2;
                Form1.channel1[3] = Form3.offs2;
                Form1.channel1[4] = Form3.phaset2;
                p11.Text = Form1.channel1[1] + " Hz";
                p12.Text = Form1.channel1[2] + " V";
                p13.Text = Form1.channel1[3] + " ";
                p14.Text = Form1.channel1[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave1 == "Pulse")
            {
                Form1.channel1[1] = Form3.freq3;
                Form1.channel1[2] = Form3.amp3;
                Form1.channel1[3] = Form3.offs3;
                Form1.channel1[5] = Form3.dutyt;
                p11.Text = Form1.channel1[1] + " Hz";
                p12.Text = Form1.channel1[2] + " V";
                p13.Text = Form1.channel1[3] + " ";
                p14.Text = Form1.channel1[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave1 == "Triangle")
            {
                Form1.channel1[1] = Form3.freq4;
                Form1.channel1[2] = Form3.amp4;
                Form1.channel1[3] = Form3.offs4;
                p11.Text = Form1.channel1[1] + " Hz";
                p12.Text = Form1.channel1[2] + " V";
                p13.Text = Form1.channel1[3] + " ";
                p14.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave1 == "Sawtooth")
            {
                Form1.channel1[1] = Form3.freq5;
                Form1.channel1[2] = Form3.amp5;
                Form1.channel1[3] = Form3.offs5;
                Form1.channel1[6] = Form3.rampt;
                p11.Text = Form1.channel1[1] + " Hz";
                p12.Text = Form1.channel1[2] + " V";
                p13.Text = Form1.channel1[3] + " ";
                p14.Text = Form1.channel1[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave1 == "Arb")
            //{
            //    p11.Text = Form3.timed;
            //    p12.Text = Form3.loopc;
            //    p13.Visible = false;
            //    p14.Visible = false;

            //}
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //channel 2 wave
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave2)
            //{


            //    case "DC":
            if (Form1.wave2 == "DC")
            {

                Form1.channel2[0] = Form3.volt;
                p21.Text = Form1.channel2[0] + " V";
                p22.Visible = false;
                p23.Visible = false;
                p24.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave2 == "Sine")

            {
                Form1.channel2[1] = Form3.freq1;
                Form1.channel2[2] = Form3.amp1;
                Form1.channel2[3] = Form3.offs1;
                Form1.channel2[4] = Form3.phaset1;
                p21.Text = Form1.channel2[1] + " Hz";
                p22.Text = Form1.channel2[2] + " V";
                p23.Text = Form1.channel2[3] + " ";
                p24.Text = Form1.channel2[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave2 == "Square")
            {
                Form1.channel2[1] = Form3.freq2;
                Form1.channel2[2] = Form3.amp2;
                Form1.channel2[3] = Form3.offs2;
                Form1.channel2[4] = Form3.phaset2;
                p21.Text = Form1.channel2[1] + " Hz";
                p22.Text = Form1.channel2[2] + " V";
                p23.Text = Form1.channel2[3] + " ";
                p24.Text = Form1.channel2[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave2 == "Pulse")
            {
                Form1.channel2[1] = Form3.freq3;
                Form1.channel2[2] = Form3.amp3;
                Form1.channel2[3] = Form3.offs3;
                Form1.channel2[5] = Form3.dutyt;
                p21.Text = Form1.channel2[1] + " Hz";
                p22.Text = Form1.channel2[2] + " V";
                p23.Text = Form1.channel2[3] + " ";
                p24.Text = Form1.channel2[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave1 == "Triangle")
            {
                Form1.channel2[1] = Form3.freq4;
                Form1.channel2[2] = Form3.amp4;
                Form1.channel2[3] = Form3.offs4;
                p21.Text = Form1.channel2[1] + " Hz";
                p22.Text = Form1.channel2[2] + " V";
                p23.Text = Form1.channel2[3] + " ";
                p24.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave2 == "Sawtooth")
            {
                Form1.channel2[1] = Form3.freq5;
                Form1.channel2[2] = Form3.amp5;
                Form1.channel2[3] = Form3.offs5;
                Form1.channel2[6] = Form3.rampt;
                p21.Text = Form1.channel2[1] + " Hz";
                p22.Text = Form1.channel2[2] + " V";
                p23.Text = Form1.channel2[3] + " ";
                p24.Text = Form1.channel2[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave2 == "Arb")
            //{
            //    p21.Text = Form3.timed;
            //    p22.Text = Form3.loopc;
            //    p23.Visible = false;
            //    p24.Visible = false;

            //}
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 3 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            if (Form1.wave3 == "DC")
            {

                Form1.channel3[0] = Form3.volt;
                p31.Text = Form1.channel3[0] + " V";
                p32.Visible = false;
                p33.Visible = false;
                p34.Visible = false;
            }
            //    
            else if (Form1.wave3 == "Sine")

            {
                Form1.channel3[1] = Form3.freq1;
                Form1.channel3[2] = Form3.amp1;
                Form1.channel3[3] = Form3.offs1;
                Form1.channel3[4] = Form3.phaset1;
                p31.Text = Form1.channel3[1] + " Hz";
                p32.Text = Form1.channel3[2] + " V";
                p33.Text = Form1.channel3[3] + " ";
                p34.Text = Form1.channel3[4] + " ";
            }
            //    
            else if (Form1.wave3 == "Square")
            {
                Form1.channel3[1] = Form3.freq2;
                Form1.channel3[2] = Form3.amp2;
                Form1.channel3[3] = Form3.offs2;
                Form1.channel3[4] = Form3.phaset2;
                p31.Text = Form1.channel3[1] + " Hz";
                p32.Text = Form1.channel3[2] + " V";
                p33.Text = Form1.channel3[3] + " ";
                p34.Text = Form1.channel3[4] + " ";

            }
            //    
            else if (Form1.wave3 == "Pulse")
            {
                Form1.channel3[1] = Form3.freq3;
                Form1.channel3[2] = Form3.amp3;
                Form1.channel3[3] = Form3.offs3;
                Form1.channel3[5] = Form3.dutyt;
                p31.Text = Form1.channel3[1] + " Hz";
                p32.Text = Form1.channel3[2] + " V";
                p33.Text = Form1.channel3[3] + " ";
                p34.Text = Form1.channel3[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave3 == "Triangle")
            {
                Form1.channel3[1] = Form3.freq4;
                Form1.channel3[2] = Form3.amp4;
                Form1.channel3[3] = Form3.offs4;
                p31.Text = Form1.channel3[1] + " Hz";
                p32.Text = Form1.channel3[2] + " V";
                p33.Text = Form1.channel3[3] + " ";
                p34.Visible = false;
            }
            //   
            else if (Form1.wave3 == "Sawtooth")
            {
                Form1.channel3[1] = Form3.freq5;
                Form1.channel3[2] = Form3.amp5;
                Form1.channel3[3] = Form3.offs5;
                Form1.channel3[6] = Form3.rampt;
                p31.Text = Form1.channel3[1] + " Hz";
                p32.Text = Form1.channel3[2] + " V";
                p33.Text = Form1.channel3[3] + " ";
                p34.Text = Form1.channel3[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave3 == "Arb")
            //{
            //    p31.Text = Form3.timed;
            //    p32.Text = Form3.loopc;
            //    p33.Visible = false;
            //    p34.Visible = false;

            //}
         

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 4 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave4)
            if (Form1.wave4 == "DC")
            {

                Form1.channel4[0] = Form3.volt;
                p41.Text = Form1.channel4[0] + " V";
                p42.Visible = false;
                p43.Visible = false;
                p44.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave4 == "Sine")

            {
                Form1.channel4[1] = Form3.freq1;
                Form1.channel4[2] = Form3.amp1;
                Form1.channel4[3] = Form3.offs1;
                Form1.channel4[4] = Form3.phaset1;
                p41.Text = Form1.channel4[1] + " Hz";
                p42.Text = Form1.channel4[2] + " V";
                p43.Text = Form1.channel4[3] + " ";
                p44.Text = Form1.channel4[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave4 == "Square")
            {
                Form1.channel4[1] = Form3.freq2;
                Form1.channel4[2] = Form3.amp2;
                Form1.channel4[3] = Form3.offs2;
                Form1.channel4[4] = Form3.phaset2;
                p41.Text = Form1.channel4[1] + " Hz";
                p42.Text = Form1.channel4[2] + " V";
                p43.Text = Form1.channel4[3] + " ";
                p44.Text = Form1.channel4[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave4 == "Pulse")
            {
                Form1.channel4[1] = Form3.freq3;
                Form1.channel4[2] = Form3.amp3;
                Form1.channel4[3] = Form3.offs3;
                Form1.channel4[5] = Form3.dutyt;
                p41.Text = Form1.channel4[1] + " Hz";
                p42.Text = Form1.channel4[2] + " V";
                p43.Text = Form1.channel4[3] + " ";
                p44.Text = Form1.channel4[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave4 == "Triangle")
            {
                Form1.channel4[1] = Form3.freq4;
                Form1.channel4[2] = Form3.amp4;
                Form1.channel4[3] = Form3.offs4;
                p41.Text = Form1.channel4[1] + " Hz";
                p42.Text = Form1.channel4[2] + " V";
                p43.Text = Form1.channel4[3] + " ";
                p44.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave4 == "Sawtooth")
            {
                Form1.channel4[1] = Form3.freq5;
                Form1.channel4[2] = Form3.amp5;
                Form1.channel4[3] = Form3.offs5;
                Form1.channel4[6] = Form3.rampt;
                p41.Text = Form1.channel4[1] + " Hz";
                p42.Text = Form1.channel4[2] + " V";
                p43.Text = Form1.channel4[3] + " ";
                p44.Text = Form1.channel4[6] + " ";

            }
            //    case "Arb":
            else if (Form1.wave4 == "Arb")
            //{
            //    p41.Text = Form3.timed;
            //    p42.Text = Form3.loopc;
            //    p43.Visible = false;
            //    p44.Visible = false;
            //}
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 5 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave5)
            if (Form1.wave5 == "DC")
            {

                Form1.channel5[0] = Form3.volt;
                p51.Text = Form1.channel5[0] + " V";
                p52.Visible = false;
                p53.Visible = false;
                p54.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave5 == "Sine")

            {
                Form1.channel5[1] = Form3.freq1;
                Form1.channel5[2] = Form3.amp1;
                Form1.channel5[3] = Form3.offs1;
                Form1.channel5[4] = Form3.phaset1;
                p51.Text = Form1.channel5[1] + " Hz";
                p52.Text = Form1.channel5[2] + " V";
                p53.Text = Form1.channel5[3] + " ";
                p54.Text = Form1.channel5[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave5 == "Square")
            {
                Form1.channel5[1] = Form3.freq2;
                Form1.channel5[2] = Form3.amp2;
                Form1.channel5[3] = Form3.offs2;
                Form1.channel5[4] = Form3.phaset2;
                p51.Text = Form1.channel5[1] + " Hz";
                p52.Text = Form1.channel5[2] + " V";
                p53.Text = Form1.channel5[3] + " ";
                p54.Text = Form1.channel5[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave5 == "Pulse")
            {
                Form1.channel5[1] = Form3.freq3;
                Form1.channel5[2] = Form3.amp3;
                Form1.channel5[3] = Form3.offs3;
                Form1.channel5[5] = Form3.dutyt;
                p51.Text = Form1.channel5[1] + " Hz";
                p52.Text = Form1.channel5[2] + " V";
                p53.Text = Form1.channel5[3] + " ";
                p54.Text = Form1.channel5[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave5 == "Triangle")
            {
                Form1.channel5[1] = Form3.freq4;
                Form1.channel5[2] = Form3.amp4;
                Form1.channel5[3] = Form3.offs4;
                p51.Text = Form1.channel5[1] + " Hz";
                p52.Text = Form1.channel5[2] + " V";
                p53.Text = Form1.channel5[3] + " ";
                p54.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave5 == "Sawtooth")
            {
                Form1.channel5[1] = Form3.freq5;
                Form1.channel5[2] = Form3.amp5;
                Form1.channel5[3] = Form3.offs5;
                Form1.channel5[6] = Form3.rampt;
                p51.Text = Form1.channel5[1] + " Hz";
                p52.Text = Form1.channel5[2] + " V";
                p53.Text = Form1.channel5[3] + " ";
                p54.Text = Form1.channel5[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave5 == "Arb")
            //{
            //    p51.Text = Form3.timed;
            //    p52.Text = Form3.loopc;
            //    p53.Visible = false;
            //    p54.Visible = false;

            //}
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 6 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave6)
            if (Form1.wave6 == "DC")
            {

                Form1.channel6[0] = Form3.volt;
                p61.Text = Form1.channel6[0] + " V";
                p62.Visible = false;
                p63.Visible = false;
                p64.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave6 == "Sine")

            {
                Form1.channel6[1] = Form3.freq1;
                Form1.channel6[2] = Form3.amp1;
                Form1.channel6[3] = Form3.offs1;
                Form1.channel6[4] = Form3.phaset1;
                p61.Text = Form1.channel6[1] + " Hz";
                p62.Text = Form1.channel6[2] + " V";
                p63.Text = Form1.channel6[3] + " ";
                p64.Text = Form1.channel6[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave6 == "Square")
            {
                Form1.channel6[1] = Form3.freq2;
                Form1.channel6[2] = Form3.amp2;
                Form1.channel6[3] = Form3.offs2;
                Form1.channel6[4] = Form3.phaset2;
                p61.Text = Form1.channel6[1] + " Hz";
                p62.Text = Form1.channel6[2] + " V";
                p63.Text = Form1.channel6[3] + " ";
                p64.Text = Form1.channel6[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave6 == "Pulse")
            {
                Form1.channel6[1] = Form3.freq3;
                Form1.channel6[2] = Form3.amp3;
                Form1.channel6[3] = Form3.offs3;
                Form1.channel6[5] = Form3.dutyt;
                p61.Text = Form1.channel6[1] + " Hz";
                p62.Text = Form1.channel6[2] + " V";
                p63.Text = Form1.channel6[3] + " ";
                p64.Text = Form1.channel6[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave6 == "Triangle")
            {
                Form1.channel6[1] = Form3.freq4;
                Form1.channel6[2] = Form3.amp4;
                Form1.channel6[3] = Form3.offs4;
                p61.Text = Form1.channel6[1] + " Hz";
                p62.Text = Form1.channel6[2] + " V";
                p63.Text = Form1.channel6[3] + " ";
                p64.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave2 == "Sawtooth")
            {
                Form1.channel6[1] = Form3.freq5;
                Form1.channel6[2] = Form3.amp5;
                Form1.channel6[3] = Form3.offs5;
                Form1.channel6[6] = Form3.rampt;
                p61.Text = Form1.channel6[1] + " Hz";
                p62.Text = Form1.channel6[2] + " V";
                p63.Text = Form1.channel6[3] + " ";
                p64.Text = Form1.channel6[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave6 == "Arb")
            //{
            //    p61.Text = Form3.timed;
            //    p62.Text = Form3.loopc;
            //    p63.Visible = false;
            //    p64.Visible = false;
            //}
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 7 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave7)
            //{


            //    case "DC":
            if (Form1.wave7 == "DC")
            {

                Form1.channel7[0] = Form3.volt;
                p71.Text = Form1.channel7[0] + " V";
                p72.Visible = false;
                p73.Visible = false;
                p74.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave7 == "Sine")

            {
                Form1.channel7[1] = Form3.freq1;
                Form1.channel7[2] = Form3.amp1;
                Form1.channel7[3] = Form3.offs1;
                Form1.channel7[4] = Form3.phaset1;
                p71.Text = Form1.channel7[1] + " Hz";
                p72.Text = Form1.channel7[2] + " V";
                p73.Text = Form1.channel7[3] + " ";
                p74.Text = Form1.channel7[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave7 == "Square")
            {
                Form1.channel7[1] = Form3.freq2;
                Form1.channel7[2] = Form3.amp2;
                Form1.channel7[3] = Form3.offs2;
                Form1.channel7[4] = Form3.phaset2;
                p71.Text = Form1.channel7[1] + " Hz";
                p72.Text = Form1.channel7[2] + " V";
                p73.Text = Form1.channel7[3] + " ";
                p74.Text = Form1.channel7[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave7 == "Pulse")
            {
                Form1.channel7[1] = Form3.freq3;
                Form1.channel7[2] = Form3.amp3;
                Form1.channel7[3] = Form3.offs3;
                Form1.channel7[5] = Form3.dutyt;
                p71.Text = Form1.channel7[1] + " Hz";
                p72.Text = Form1.channel7[2] + " V";
                p73.Text = Form1.channel7[3] + " ";
                p74.Text = Form1.channel7[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave7 == "Triangle")
            {
                Form1.channel7[1] = Form3.freq4;
                Form1.channel7[2] = Form3.amp4;
                Form1.channel7[3] = Form3.offs4;
                p71.Text = Form1.channel7[1] + " Hz";
                p72.Text = Form1.channel7[2] + " V";
                p73.Text = Form1.channel7[3] + " ";
                p74.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave7 == "Sawtooth")
            {
                Form1.channel7[1] = Form3.freq5;
                Form1.channel7[2] = Form3.amp5;
                Form1.channel7[3] = Form3.offs5;
                Form1.channel7[6] = Form3.rampt;
                p71.Text = Form1.channel7[1] + " Hz";
                p72.Text = Form1.channel7[2] + " V";
                p73.Text = Form1.channel7[3] + " ";
                p74.Text = Form1.channel7[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave7 == "Arb")
            //{
            //    p71.Text = Form3.timed;
            //    p72.Text = Form3.loopc;
            //    p73.Visible = false;
            //    p74.Visible = false;

            //}
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ////channel 8 wave
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //switch (Form1.wave8)
            //{


            //    case "DC":
            if (Form1.wave8 == "DC")
            {

                Form1.channel8[0] = Form3.volt;
                p81.Text = Form1.channel8[0] + " V";
                p82.Visible = false;
                p83.Visible = false;
                p84.Visible = false;
            }
            //    case "Sine":
            else if (Form1.wave8 == "Sine")

            {
                Form1.channel8[1] = Form3.freq1;
                Form1.channel8[2] = Form3.amp1;
                Form1.channel8[3] = Form3.offs1;
                Form1.channel8[4] = Form3.phaset1;
                p81.Text = Form1.channel8[1] + " Hz";
                p82.Text = Form1.channel8[2] + " V";
                p83.Text = Form1.channel8[3] + " ";
                p84.Text = Form1.channel8[4] + " ";
            }
            //    case "Square":
            else if (Form1.wave8 == "Square")
            {
                Form1.channel8[1] = Form3.freq2;
                Form1.channel8[2] = Form3.amp2;
                Form1.channel8[3] = Form3.offs2;
                Form1.channel8[4] = Form3.phaset2;
                p81.Text = Form1.channel8[1] + " Hz";
                p82.Text = Form1.channel8[2] + " V";
                p83.Text = Form1.channel8[3] + " ";
                p84.Text = Form1.channel8[4] + " ";

            }
            //    case "Pulse":
            else if (Form1.wave8 == "Pulse")
            {
                Form1.channel8[1] = Form3.freq3;
                Form1.channel8[2] = Form3.amp3;
                Form1.channel8[3] = Form3.offs3;
                Form1.channel8[5] = Form3.dutyt;
                p81.Text = Form1.channel8[1] + " Hz";
                p82.Text = Form1.channel8[2] + " V";
                p83.Text = Form1.channel8[3] + " ";
                p84.Text = Form1.channel8[5] + " ";

            }
            //    case "Triangle":
            else if (Form1.wave8 == "Triangle")
            {
                Form1.channel8[1] = Form3.freq4;
                Form1.channel8[2] = Form3.amp4;
                Form1.channel8[3] = Form3.offs4;
                p81.Text = Form1.channel8[1] + " Hz";
                p82.Text = Form1.channel8[2] + " V";
                p83.Text = Form1.channel8[3] + " ";
                p84.Visible = false;
            }
            //    case "Sawtooth":
            else if (Form1.wave8 == "Sawtooth")
            {
                Form1.channel8[1] = Form3.freq5;
                Form1.channel8[2] = Form3.amp5;
                Form1.channel8[3] = Form3.offs5;
                Form1.channel8[6] = Form3.rampt;
                p81.Text = Form1.channel8[1] + " Hz";
                p82.Text = Form1.channel8[2] + " V";
                p83.Text = Form1.channel8[3] + " ";
                p84.Text = Form1.channel8[6] + " ";

            }
            //    case "Arb":
            //else if (Form1.wave8 == "Arb")
            //{
            //    p81.Text = Form3.timed;
            //    p82.Text = Form3.loopc;
            //    p83.Visible = false;
            //    p84.Visible = false;

            //}
            //}






            //This form will be reserved for parameters of waves.
        }
    }
}

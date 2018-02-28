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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //////////////////////////////////////////////////////////////////////////////
            //channel 1 wave/////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////
            if (Form1.wave1 == "DC")
                {
                p11.Text = Form3.volt + " V";
                p12.Visible = false;
                p13.Visible = false;
                p14.Visible = false;

                }
            else if(Form1.wave1 == "Sine")
            {
                p11.Text = Form3.freq; 
                p12.Text = Form3.amp;
                p13.Text = Form3.offs;
                p14.Text = Form3.phaset;
            }
            else if(Form1.wave1 == "Square")
            {
                p11.Text = Form3.freq;
                p12.Text = Form3.amp;
                p13.Text = Form3.offs;
                p14.Text = Form3.phaset;
            }
            else if(Form1.wave1 == "Pulse")
            {
                p11.Text = Form3.freq;
                p12.Text = Form3.amp;
                p13.Text = Form3.offs;
                p14.Text = Form3.dutyt;
            }
            else if(Form1.wave1 == "Triangle")
            {
                p11.Text = Form3.freq;
                p12.Text = Form3.amp;
                p13.Text = Form3.offs;
                p14.Visible = false;
            
            }
            else if(Form1.wave1 == "Sawtooth")
            {
                p11.Text = Form3.freq;
                p12.Text = Form3.amp;
                p13.Text = Form3.offs;
                p14.Text = Form3.rampt;

            }
            else if(Form1.wave1 == "Arb")
            {
                p11.Text = Form3.timed;
                p12.Text = Form3.loopc;
                p13.Visible = false;
                p14.Visible = false;

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //channel 2 wave
            //////////////////////////////////////////////////////////////////////////////////////////////////
            if (Form1.wave2 == "DC")
            {
                p21.Text = Form3.volt + " V";
                p22.Visible = false;
                p23.Visible = false;
                p24.Visible = false;

            }
            else if (Form1.wave2 == "Sine")
            {
                p21.Text = Form3.freq;
                p22.Text = Form3.amp;
                p23.Text = Form3.offs;
                p24.Text = Form3.phaset;
            }
            else if (Form1.wave2 == "Square")
            {
                p21.Text = Form3.freq;
                p22.Text = Form3.amp;
                p23.Text = Form3.offs;
                p24.Text = Form3.phaset;
            }
            else if (Form1.wave2 == "Pulse")
            {
                p21.Text = Form3.freq;
                p22.Text = Form3.amp;
                p23.Text = Form3.offs;
                p24.Text = Form3.dutyt;
            }
            else if (Form1.wave2 == "Triangle")
            {
                p21.Text = Form3.freq;
                p22.Text = Form3.amp;
                p23.Text = Form3.offs;
                p24.Visible = false;

            }
            else if (Form1.wave2 == "Sawtooth")
            {
                p21.Text = Form3.freq;
                p22.Text = Form3.amp;
                p23.Text = Form3.offs;
                p24.Text = Form3.rampt;

            }
            else if (Form1.wave2 == "Arb")
            {
                p21.Text = Form3.timed;
                p22.Text = Form3.loopc;
                p23.Visible = false;
                p24.Visible = false;

            }
            /////////////////////////////////////////////////////////////////////////////////////
            //channel 3 wave
            /////////////////////////////////////////////////////////////////////////////////////
            if (Form1.wave3 == "DC")
            {
                p31.Text = Form3.volt + " V";
                p32.Visible = false;
                p33.Visible = false;
                p34.Visible = false;

            }
            else if (Form1.wave3 == "Sine")
            {
                p31.Text = Form3.freq;
                p32.Text = Form3.amp;
                p33.Text = Form3.offs;
                p34.Text = Form3.phaset;
            }
            else if (Form1.wave3 == "Square")
            {
                p31.Text = Form3.freq;
                p32.Text = Form3.amp;
                p33.Text = Form3.offs;
                p34.Text = Form3.phaset;
            }
            else if (Form1.wave3 == "Pulse")
            {
                p31.Text = Form3.freq;
                p32.Text = Form3.amp;
                p33.Text = Form3.offs;
                p34.Text = Form3.dutyt;
            }
            else if (Form1.wave3 == "Triangle")
            {
                p31.Text = Form3.freq;
                p32.Text = Form3.amp;
                p33.Text = Form3.offs;
                p34.Visible = false;

            }
            else if (Form1.wave3 == "Sawtooth")
            {
                p31.Text = Form3.freq;
                p32.Text = Form3.amp;
                p33.Text = Form3.offs;
                p34.Text = Form3.rampt;

            }
            else if (Form1.wave3 == "Arb")
            {
                p31.Text = Form3.timed;
                p32.Text = Form3.loopc;
                p33.Visible = false;
                p34.Visible = false;

            }
            //////////////////////////////////////////////////////////////////////////////////////
            //channel 4 wave
            //////////////////////////////////////////////////////////////////////////////////////
            if (Form1.wave4 == "DC")
            {
                p41.Text = Form3.volt + " V";
                p42.Visible = false;
                p43.Visible = false;
                p44.Visible = false;

            }
            else if (Form1.wave4 == "Sine")
            {
                p41.Text = Form3.freq;
                p42.Text = Form3.amp;
                p43.Text = Form3.offs;
                p44.Text = Form3.phaset;
            }
            else if (Form1.wave4 == "Square")
            {
                p41.Text = Form3.freq;
                p42.Text = Form3.amp;
                p43.Text = Form3.offs;
                p44.Text = Form3.phaset;
            }
            else if (Form1.wave4 == "Pulse")
            {
                p41.Text = Form3.freq;
                p42.Text = Form3.amp;
                p43.Text = Form3.offs;
                p44.Text = Form3.dutyt;
            }
            else if (Form1.wave4 == "Triangle")
            {
                p41.Text = Form3.freq;
                p42.Text = Form3.amp;
                p43.Text = Form3.offs;
                p44.Visible = false;

            }
            else if (Form1.wave4 == "Sawtooth")
            {
                p41.Text = Form3.freq;
                p42.Text = Form3.amp;
                p43.Text = Form3.offs;
                p44.Text = Form3.rampt;

            }
            else if (Form1.wave4 == "Arb")
            {
                p41.Text = Form3.timed;
                p42.Text = Form3.loopc;
                p43.Visible = false;
                p44.Visible = false;

            }
            /////////////////////////////////////////////////////////////////////////////
            //channel 5 wave
            /////////////////////////////////////////////////////////////////////////////
            if (Form1.wave5 == "DC")
            {
                p51.Text = Form3.volt + " V";
                p52.Visible = false;
                p53.Visible = false;
                p54.Visible = false;

            }
            else if (Form1.wave5 == "Sine")
            {
                p51.Text = Form3.freq;
                p52.Text = Form3.amp;
                p53.Text = Form3.offs;
                p54.Text = Form3.phaset;
            }
            else if (Form1.wave5 == "Square")
            {
                p51.Text = Form3.freq;
                p52.Text = Form3.amp;
                p53.Text = Form3.offs;
                p54.Text = Form3.phaset;
            }
            else if (Form1.wave5 == "Pulse")
            {
                p51.Text = Form3.freq;
                p52.Text = Form3.amp;
                p53.Text = Form3.offs;
                p54.Text = Form3.dutyt;
            }
            else if (Form1.wave5 == "Triangle")
            {
                p51.Text = Form3.freq;
                p52.Text = Form3.amp;
                p53.Text = Form3.offs;
                p54.Visible = false;

            }
            else if (Form1.wave5 == "Sawtooth")
            {
                p51.Text = Form3.freq;
                p52.Text = Form3.amp;
                p53.Text = Form3.offs;
                p54.Text = Form3.rampt;

            }
            else if (Form1.wave5 == "Arb")
            {
                p51.Text = Form3.timed;
                p52.Text = Form3.loopc;
                p53.Visible = false;
                p54.Visible = false;

            }
            ///////////////////////////////////////////////////////////////////////
            //channel 6 wave
            ///////////////////////////////////////////////////////////////////////
            if (Form1.wave6 == "DC")
            {
                p61.Text = Form3.volt + " V";
                p62.Visible = false;
                p63.Visible = false;
                p64.Visible = false;

            }
            else if (Form1.wave6 == "Sine")
            {
                p61.Text = Form3.freq;
                p62.Text = Form3.amp;
                p63.Text = Form3.offs;
                p64.Text = Form3.phaset;
            }
            else if (Form1.wave6 == "Square")
            {
                p61.Text = Form3.freq;
                p62.Text = Form3.amp;
                p63.Text = Form3.offs;
                p64.Text = Form3.phaset;
            }
            else if (Form1.wave6 == "Pulse")
            {
                p61.Text = Form3.freq;
                p62.Text = Form3.amp;
                p63.Text = Form3.offs;
                p64.Text = Form3.dutyt;
            }
            else if (Form1.wave6 == "Triangle")
            {
                p61.Text = Form3.freq;
                p62.Text = Form3.amp;
                p63.Text = Form3.offs;
                p64.Visible = false;

            }
            else if (Form1.wave6 == "Sawtooth")
            {
                p61.Text = Form3.freq;
                p62.Text = Form3.amp;
                p63.Text = Form3.offs;
                p64.Text = Form3.rampt;

            }
            else if (Form1.wave6 == "Arb")
            {
                p61.Text = Form3.timed;
                p62.Text = Form3.loopc;
                p63.Visible = false;
                p64.Visible = false;

            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            //channel 7 wave
            //////////////////////////////////////////////////////////////////////////////////////////////
            if (Form1.wave7 == "DC")
            {
                p71.Text = Form3.volt + " V";
                p72.Visible = false;
                p73.Visible = false;
                p74.Visible = false;

            }
            else if (Form1.wave7 == "Sine")
            {
                p71.Text = Form3.freq;
                p72.Text = Form3.amp;
                p73.Text = Form3.offs;
                p74.Text = Form3.phaset;
            }
            else if (Form1.wave7 == "Square")
            {
                p71.Text = Form3.freq;
                p72.Text = Form3.amp;
                p73.Text = Form3.offs;
                p74.Text = Form3.phaset;
            }
            else if (Form1.wave7 == "Pulse")
            {
                p71.Text = Form3.freq;
                p72.Text = Form3.amp;
                p73.Text = Form3.offs;
                p74.Text = Form3.dutyt;
            }
            else if (Form1.wave7 == "Triangle")
            {
                p71.Text = Form3.freq;
                p72.Text = Form3.amp;
                p73.Text = Form3.offs;
                p74.Visible = false;

            }
            else if (Form1.wave7 == "Sawtooth")
            {
                p71.Text = Form3.freq;
                p72.Text = Form3.amp;
                p73.Text = Form3.offs;
                p74.Text = Form3.rampt;

            }
            else if (Form1.wave7 == "Arb")
            {
                p71.Text = Form3.timed;
                p72.Text = Form3.loopc;
                p73.Visible = false;
                p74.Visible = false;

            }
            ///////////////////////////////////////////////////////////////////////////////////////
            //channel 8 wave
            ///////////////////////////////////////////////////////////////////////////////////////
            if (Form1.wave8 == "DC")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.volt + " V";
                p82.Visible = false;
                p83.Visible = false;
                p84.Visible = false;

            }
            else if (Form1.wave8 == "Sine")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.freq;
                p82.Text = Form3.amp;
                p83.Text = Form3.offs;
                p84.Text = Form3.phaset;
            }
            else if (Form1.wave8 == "Square")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.freq;
                p82.Text = Form3.amp;
                p83.Text = Form3.offs;
                p84.Text = Form3.phaset;
            }
            else if (Form1.wave8 == "Pulse")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.freq;
                p82.Text = Form3.amp;
                p83.Text = Form3.offs;
                p84.Text = Form3.dutyt;
            }
            else if (Form1.wave8 == "Triangle")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.freq;
                p82.Text = Form3.amp;
                p83.Text = Form3.offs;
                p84.Visible = false;

            }
            else if (Form1.wave8 == "Sawtooth")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.freq;
                p82.Text = Form3.amp;
                p83.Text = Form3.offs;
                p84.Text = Form3.rampt;

            }
            else if (Form1.wave8 == "Arb")
            {
                w8.Text = Form1.wave8;
                p81.Text = Form3.timed;
                p82.Text = Form3.loopc;
                p83.Visible = false;
                p84.Visible = false;

            }
        }

     

        //This form will be reserved for parameters of waves.
    }
}

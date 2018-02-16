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
            wave.Text = Form3.wave;
            freqtext.Text = Form3.freq;
            amptext.Text = Form3.amp;
            offsettext.Text = Form3.offs;
            phasetext.Text = Form3.phaset;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
          
        }

      

        private void wave_Click(object sender, EventArgs e)
        {
            
        }

        //This form will be reserved for parameters of waves.
    }
}

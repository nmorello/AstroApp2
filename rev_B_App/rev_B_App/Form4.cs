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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Application.Exit();
            }
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

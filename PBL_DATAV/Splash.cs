using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_DATAV
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        Timer tmr;

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 2000; // 2 seconds
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}

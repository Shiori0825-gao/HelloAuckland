using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloAuckland
{
    public partial class Taxi1 : Form
    {
        PriceComp priceComp;
        Taxi taxi;
        public Taxi1()
        {
            InitializeComponent();
            priceComp = new PriceComp();
            taxi = new Taxi();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            priceComp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            taxi.Show();
        }
    }
}

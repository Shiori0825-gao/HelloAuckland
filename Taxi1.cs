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
        Taxi taxi;
        PriceComp priceComparison;
        public Taxi1()
        {
            InitializeComponent();
            taxi = new Taxi();
            priceComparison = new PriceComp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            priceComparison.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            taxi.Show();
            this.Hide();
        }
    }
}

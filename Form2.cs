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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Taxi_Click(object sender, EventArgs e)
        {
            Taxi taxi = new Taxi();
            taxi.Show();            
        }

        private void Train_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
        }

        private void Bus_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            bus.Show();
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
        }
    }
}

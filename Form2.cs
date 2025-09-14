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
        Bus bus;
        Train train;
        Taxi taxi;
        Rent rent;
        public Form2()
        {
            InitializeComponent();
            bus = new Bus();
            train = new Train();
            taxi = new Taxi();
            rent = new Rent();
        }

        private void Taxi_Click(object sender, EventArgs e)
        {          
            taxi.Show();            
        }

        private void Train_Click(object sender, EventArgs e)
        {
            bus.Show();
        }

        private void Bus_Click(object sender, EventArgs e)
        {
            train.Show();
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            rent.Show();
        }
    }
}

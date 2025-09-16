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
        bus1 bus1;
        Train1 train1;
        Taxi1 taxi1;
        Rent rent;
        public Form2()
        {
            InitializeComponent();
            bus1 = new bus1();
            train1 = new Train1();
            taxi1 = new Taxi1();
            rent = new Rent();
        }

        private void pictureBoxTaxi_Click(object sender, EventArgs e)
        {
            taxi1.Show();
        }

        private void pictureBoxTrain_Click(object sender, EventArgs e)
        {
            train1.Show();
        }

        private void pictureBoxBus_Click(object sender, EventArgs e)
        {
            bus1.Show();
        }

        private void pictureBoxCar_Click(object sender, EventArgs e)
        {
            rent.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

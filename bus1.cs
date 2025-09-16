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
    public partial class bus1 : Form
    {
        Payment payment;
        Bus bus;
        public bus1()
        {
            InitializeComponent();
            payment = new Payment();
            bus = new Bus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            payment.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bus.Show();
            this.Hide();
        }
    }
}

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
    public partial class Train1 : Form
    {
        Payment payment;
        Train train;
        public Train1()
        {
            InitializeComponent();
            payment = new Payment();
            train = new Train();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            payment.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            train.Show();
            this.Hide();
        }
    }
}

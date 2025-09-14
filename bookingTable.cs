using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HelloAuckland
{
    public partial class bookingTable : Form
    {
        public bookingTable()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string time = dateTimePicker2.Value.ToShortTimeString();

            MessageBox.Show($"Booking Confirmed!\n\nName: {name}\nDate: {date}\nTime: {time}", "Success");
            this.Close(); // Close the booking form
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

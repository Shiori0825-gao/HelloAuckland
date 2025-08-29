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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Done");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hotel;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Google Maps search URL for the address
            string address = "4 Bay Road, Waiheke Island";
            string mapsUrl = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(address);

            // Open in default browser
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = mapsUrl,
                UseShellExecute = true
            });

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
//BindingManagerDataErrorEventArgs[]
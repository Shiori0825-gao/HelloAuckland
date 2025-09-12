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
            HotelDetailsForm detailsForm = new HotelDetailsForm();
            detailsForm.ShowDialog(); // opens the new form as a pop-up

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.google.com/maps/search/?api=1&query=Marina+Bay+Sands,+Singapore",
                UseShellExecute = true
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
//BindingManagerDataErrorEventArgs[]
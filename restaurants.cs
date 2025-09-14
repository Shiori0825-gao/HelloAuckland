using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloAuckland
{
    public partial class restaurants : Form
    {
        public restaurants()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void restaurants_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }


        // Add a link to the LinkLabel (start index 0, length 13 for "Visit Example")

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/maps/place/Prego+Restaurant/@-36.852697,174.744828,16z/data=!3m1!4b1!4m6!3m5!1s0x6d0d47911e847c43:0xc79e13247819af91!8m2!3d-36.852697!4d174.744828!16s%2Fg%2F1v27vp9t?entry=ttu&g_ep=EgoyMDI1MDkxMC4wIKXMDSoASAFQAw%3D%3D";
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

            

        private void label14_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/maps/place/Origine+Bistro/@-36.8434055,174.7630167,17z/data=!3m1!5s0x6d0d47f08e4d2a67:0xef8dbba5ca11fa31!4m6!3m5!1s0x6d0d4753350cffd9:0x6c9bbbf68f70aa95!8m2!3d-36.8439762!4d174.7661423!16s%2Fg%2F11t4xxp6bg?entry=ttu&g_ep=EgoyMDI1MDkwOC4wIKXMDSoASAFQAw%3D%3D";
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bookingTable bookingForm = new bookingTable();
            bookingForm.ShowDialog(); // modal
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bookingTable bookingForm = new bookingTable();
            bookingForm.ShowDialog(); // modal
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bookingTable bookingForm = new bookingTable();
            bookingForm.ShowDialog(); // modal
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/maps/place/Soul+Bar+%26+Bistro/@-36.8434012,174.7604418,17z/data=!3m1!4b1!4m6!3m5!1s0x6d0d47f9ddb9f84b:0xf9553168111f7fe8!8m2!3d-36.8434055!4d174.7630167!16s%2Fg%2F1tg2dp7s?entry=ttu&g_ep=EgoyMDI1MDkxMC4wIKXMDSoASAFQAw%3D%3D";
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }
    }
}

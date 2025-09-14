using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HelloAuckland
{
    public partial class HotelDetailsForm : Form
    {
        public HotelDetailsForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Successful!");

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("mandeep839093@gmail.com");
                mail.To.Add(textBox4.Text); // User's email input
                mail.Subject = "Hotel Booking Confirmation";

                mail.Body = $"Hi {textBox2.Text},\n\n" +
                            "Thank you for your booking. Your request has been received and we will contact you shortly.\n\n" +
                            $"Phone: {textBox3.Text}\nMessage: {textBox5.Text}\n\n" +
                            "Regards,\nAuckland Travel Assistant";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("mandeep839093@gmail.com", "pjfczqovwokvptpc"); // 🔐 Your App Password
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Booking confirmation sent to your email.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email:\n" + ex.Message, "Error");
            }

            
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            AcceptButton = button1;               // Press Enter to submit
            textBox2.UseSystemPasswordChar = true; // Hide password as you type

            // Start with no error text.
            label1.Text = "";
            label1.ForeColor = Color.Red;         // Use red only when showing an error
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Dummy login check – replace with real logic later
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!", "Success");

                // Optionally open another form here
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Hide();
            }
            else
            {
                label1.Text = "Invalid username or password.";
                label1.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }


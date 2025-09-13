using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloAuckland
{
    public partial class Form3 : Form
    {

        private string connectionString = @"Data Source=C:\Users\User067\Desktop\users.db;Version=3;";

        public Form3()
        {
            InitializeComponent();
            AcceptButton = button1;               // Press Enter to submit
            TxtPassword.UseSystemPasswordChar = true; // Hide password as you type                     
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = TxtUsername.Text.Trim();
            string password = TxtPassword.Text;

            // 1. Проверяем поля
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill in all fields.");
                return;
            }


            // 2. Подключение к БД и вставка
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Проверка уникальности email
                    string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQueryEmail, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        long countEmail = (long)await checkCmd.ExecuteScalarAsync();
                        if (countEmail == 0)
                        {
                            MessageBox.Show("The email is not registered!");
                            return;
                        }
                    }

                    // Вставка данных
                    string checkQueryPassword = "SELECT password FROM users WHERE email = @Email";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkQueryPassword, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        object result = await cmd.ExecuteScalarAsync();
                        string storedPasswordHash = result.ToString();
                        bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);

                        if (isPasswordCorrect)
                        {
                            MessageBox.Show("Welcome!");
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


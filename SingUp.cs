using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HelloAuckland
{
    public partial class SingUp : Form
    {
        private string connectionString = @"Data Source=C:\Users\User067\Desktop\users.db;Version=3;";
        
        public SingUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // 1. Проверяем поля
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))                
            {
                MessageBox.Show("Все поля обязательны.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // 2. Подключение к БД и вставка
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Проверка уникальности email
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        long count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Email уже зарегистрирован!");
                            return;
                        }
                    }

                    // Вставка данных
                    string insertQuery = "INSERT INTO users (username, email, password) VALUES (@Username, @Email, @Password)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Пока в чистом виде (позже сделаем хэш)
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Регистрация прошла успешно!");
                        else
                            MessageBox.Show("Ошибка при регистрации.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}

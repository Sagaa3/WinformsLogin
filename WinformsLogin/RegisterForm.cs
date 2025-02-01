using Microsoft.VisualBasic.Logging;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsLogin.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinformsLogin
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passwordFiels.Text;

            string connectionString = "host=localhost; port=5432; database=winformdb; user id=postgres; password=root";
            //string query = String.Format("SELECT COUNT(*) FROM public.\"Users\" WHERE \"Name\" = {0}", loginUser);
            string query = "SELECT COUNT(*) FROM public.\"Users\" WHERE \"Name\" = @username";

            using (var connect = new NpgsqlConnection(connectionString))
            {
                connect.Open();
                using (var command = new NpgsqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("username", loginUser);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует. Регистрация невозможна.");
                    }
                    else
                    {
                        string insertUserQuery = "INSERT INTO public.\"Users\" (\"Name\", \"Password\") VALUES (@login, @password)";
                        using (var insertCmd = new NpgsqlCommand(insertUserQuery, connect))
                        {
                            insertCmd.Parameters.AddWithValue("login", loginUser);
                            insertCmd.Parameters.AddWithValue("password", passUser); // Не забудьте хэшировать пароль перед сохранением
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Пользователь зарегистрирован, можно авторизоваться");

                        }
                        connect.Close();
                    }
                }
            }
        }
    }
}

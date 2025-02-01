using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Web;
using System.Windows.Forms;
using WinformsLogin.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using User = WinformsLogin.Model.User;

namespace WinformsLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passwordFiels.Size = new Size(passwordFiels.Size.Width, 67);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Авторизация_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseAppButton_MouseEnter(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.Red;
        }

        private void CloseAppButton_MouseLeave(object sender, EventArgs e)
        {
            CloseAppButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                        // Здесь можно добавить логику для регистрации нового пользователя
                        MessageBox.Show("Пользователь с таким именем не найден. Можно зарегистрироваться.");
                    }
                }

                connect.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

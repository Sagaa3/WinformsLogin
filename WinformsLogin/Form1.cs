using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using WinformsLogin.Model;
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

        private bool dragging = false;
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newLocation = this.Location;
                newLocation.X = e.X;
                newLocation.Y = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passwordFiels.Text;

            using (var contex = new contex())
            {
                User user = new User(loginUser, passUser);

                contex.Users.Add(user);
                contex.SaveChanges();

                string connection = "host=localhost; port=5432; database=winformdb; user id=postgres; password=root";
                string query = "SELECT * FROM Users WHERE Name = @Name";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", userNameToCheck);

                    var count = (long)command.ExecuteScalar();

                    if (count > 0)
                    {
                        Console.WriteLine($"Пользователь {userNameToCheck} существует в базе данных.");
                    }
                    else
                    {
                        Console.WriteLine($"Пользователь {userNameToCheck} не найден в базе данных.");
                    }

                }
        }
    }
}

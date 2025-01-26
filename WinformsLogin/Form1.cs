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

            string connection = "host=localhost; port=5432; database=winformdb; user id=postgres; password=root";
            string query = "SELECT * FROM public.\"Users\" ";
            List<string> UserList = new List<string>();

            using (var contex = new contex())
            {
                User user = new User(loginUser, passUser);

                //contex.Users.Add(user);
                //contex.SaveChanges();


                using (var connect = new NpgsqlConnection(connection))
                {
                    connect.Open();

                    string sql = "SELECT * FROM information_schema.tables WHERE table_name = 'users'";
                    using (var command = new NpgsqlCommand(sql, connect))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var text = reader.GetString(0);
                                MessageBox.Show(text);
                                // Добавляем имя в список
                                //UserList.Add(reader.GetString(0));
                            }
                        }

                    }
                    string info = " ";
                    foreach (var name in UserList)
                    {
                        info += name;
                    }
                    MessageBox.Show(info);

                }
            }
        }
    }
}

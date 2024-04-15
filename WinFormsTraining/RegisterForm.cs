using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTraining
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point lastpoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.ForeColor = Color.Black;
                userNameField.Text = "";
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.ForeColor = Color.Black;
                loginField.Text = "";
            }

        }
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.ForeColor = Color.Gray;
                passField.Text = "Введите password";
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите password")
            {
                passField.ForeColor = Color.Black;
                passField.Text = "";
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurNameField.Text == "")
            {
                userSurNameField.ForeColor = Color.Gray;
                userSurNameField.Text = "Введите фамилию";

            }
        }

        private void userSurNameField_Enter(object sender, EventArgs e)
        {
            if (userSurNameField.Text == "Введите фамилию")
            {
                userSurNameField.Text = "";
                userSurNameField.ForeColor = Color.Black;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(userNameField.Text=="Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurNameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if(passField.Text=="Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;

            }

            if (isUserExists()) { return; }

            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`) VALUES ( null,@login, @pass,@name,@surname);",dB.getConnection());
            command.Parameters.Add("@login",MySqlDbType.VarChar).Value=loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurNameField.Text;

            dB.openConnection();
            if (command.ExecuteNonQuery()==1) {
                MessageBox.Show("Аккаунт был создан");

            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            dB.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
           

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь зарегистрирован");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

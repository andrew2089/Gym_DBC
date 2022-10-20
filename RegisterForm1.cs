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

namespace Gym_DBC
{
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();

            userIdField.Text = "Enter client age";
            userIdField.ForeColor = Color.Gray;

            userSurnameField.Text = "Enter Surname";
            userSurnameField.ForeColor = Color.Gray;


            loginField1.Text = "Enter client name";
            loginField1.ForeColor = Color.Gray;

            passField1.Text = "Enter password";
            passField1.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeButton_MouseEnter_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Aqua;

        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void userIdField_Enter(object sender, EventArgs e)
        {
            if (userIdField.Text == "Enter client age")
            {
              userIdField.Text = "";
                userIdField.ForeColor = Color.Black;
            }
        }

        private void userIdField_Leave(object sender, EventArgs e)
        {
            if (userIdField.Text == "")
            {
                userIdField.Text = "Enter client age";
                userIdField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Enter Surname")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }

        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Enter Surname";
                userSurnameField.ForeColor = Color.Gray;
            }

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField1.Text == "Enter client name")
            {
                loginField1.Text = "";
                loginField1.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField1.Text == "")
            {
                loginField1.Text = "Enter client name";
                loginField1.ForeColor = Color.Gray;
            }
        }

        private void passField1_Enter(object sender, EventArgs e)
        {
            if (passField1.Text == "Enter password")
            {
                passField1.Text = "";
                passField1.ForeColor = Color.Black;
            }
        }

        private void passField1_Leave(object sender, EventArgs e)
        {
            if (passField1.Text == "")
            {
                passField1.Text = "Enter password";
                passField1.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Enter Surname")
            {
                MessageBox.Show("You should enter client surname");
                return;
            }
            if (passField1.Text == "Enter password")
            {
                MessageBox.Show("You should enter client password");
                return;
            }
            if (userIdField.Text == "Enter client age")
            { 
                MessageBox.Show("You should enter client age");
            return;
                }

            if (loginField1.Text == "Enter client name")
            {
                MessageBox.Show("You should enter client name");
                return;
            }

            if (ifUserExists())
                return;




            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `client` (`Client_name`, `Client_surname`, `Client_password`, `Client_age`) VALUES (@login, @surname, @pass, @age);",db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField1.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = userIdField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account was created");
            else
                MessageBox.Show("Account wasn't created");

            db.closeConnection();
        }




        public Boolean ifUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM client WHERE `Client_name`= @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField1.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User with such name already exist");
                return true;
            }    
            else
            return false;
        }

        private void userIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginField1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
        }
    }
}

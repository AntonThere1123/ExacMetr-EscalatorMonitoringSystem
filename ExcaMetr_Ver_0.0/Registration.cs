using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ExcaMetr_Ver_0._0
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            LoginField.Text = "(Придумайте Логин)";
            PassField.Text = "(Придумайте пароль)";
            NameField.Text = "(Введите имя)";
            LastName.Text = "(Введите фамилию)";
            PhoneNum.Text = "(Номер телефона)";
            EmailField.Text = "(Введите почту)";

            PassField.ForeColor = Color.Gray;
            NameField.ForeColor = Color.Gray;
            PhoneNum.ForeColor = Color.Gray;
            EmailField.ForeColor = Color.Gray;
            LastName.ForeColor = Color.Gray;
        }

        private void Registration_Load(object sender, EventArgs e) { }

        Point LastPoint;
        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void AutomithationText_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void LoginField_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void EXIT_Registration_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "(Придумайте Логин)" || LoginField.Text == "")
            {
                MessageBox.Show("Надо бы логин ввести");
                return;
            }

            if (PassField.Text == "(Придумайте пароль)" || PassField.Text == "")
            {
                MessageBox.Show("...Пароль где?");
                return;
            }

            if (NameField.Text == "(Введите имя)" || NameField.Text == "")
            {
                MessageBox.Show("Про имя не забыл?");
                return;
            }

            if (LastName.Text == "(Введите фамилию)" || LastName.Text == "")
            {
                MessageBox.Show("Фамилию в студию");
                return;
            }

            if (EmailField.Text == "(Введите почту)" || EmailField.Text == "")
            {
                MessageBox.Show("ПОЧТА!");
                return;
            }

            if (PhoneNum.Text == "(Номер телефона)" || PhoneNum.Text == "")
            {
                MessageBox.Show("Номер телефона-это значит надо указать номер телефона");
                return;
            }


            if (IsUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `Password`, `Name`, `Last Name`, `Role`, `Email`, `Phone_Number`, `IsActive`) VALUES (@login, @pass, @name, @lastname, @role, @email, @phonenum, @Active)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = LastName.Text;
            command.Parameters.Add("@role", MySqlDbType.Enum).Value = "User";
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailField.Text;
            command.Parameters.Add("@phonenum", MySqlDbType.VarChar).Value = PhoneNum.Text;
            command.Parameters.Add("@Active", MySqlDbType.Int32).Value = 1;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы зарегестрировались, выполните повторный вход");
                this.Close();
                AutoEnter UserW = new AutoEnter();
                UserW.Show();
            }
            else
            {
                MessageBox.Show("Не создан");
            }

            db.closeConnection();

        }

        public Boolean IsUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть");
                return true;
            }
            else
            {

                return false;

            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "(Придумайте Логин)")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "(Придумайте Логин)";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "(Придумайте пароль)")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "(Придумайте пароль)";
                PassField.ForeColor = Color.Gray;
            }
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "(Введите имя)")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "(Введите имя)";
                NameField.ForeColor = Color.Gray;
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "(Введите фамилию)")
            {
                LastName.Text = "";
                LastName.ForeColor = Color.Black;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                LastName.Text = "(Введите фамилию)";
                LastName.ForeColor = Color.Gray;
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "(Введите почту)")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "(Введите почту)";
                EmailField.ForeColor = Color.Gray;
            }
        }

        private void PhoneNum_Enter(object sender, EventArgs e)
        {
            if (PhoneNum.Text == "(Номер телефона)")
            {
                PhoneNum.Text = "";
                PhoneNum.ForeColor = Color.Black;
            }
        }

        private void PhoneNum_Leave(object sender, EventArgs e)
        {
            if (PhoneNum.Text == "")
            {
                PhoneNum.Text = "(Номер телефона)";
                PhoneNum.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AutoEnter autoEnter = new AutoEnter();

            autoEnter.Show();

            this.Close();
        }

        private void EXIT_Registration_MouseEnter(object sender, EventArgs e)
        {
            EXIT_Registration.ForeColor = Color.Red;
        }

        private void EXIT_Registration_MouseLeave(object sender, EventArgs e)
        {
            EXIT_Registration.ForeColor = Color.Black;
        }
    }
}
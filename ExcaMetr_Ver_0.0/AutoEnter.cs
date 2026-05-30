using MySql.Data.MySqlClient;
using System.Data;

namespace ExcaMetr_Ver_0._0
{
    public partial class AutoEnter : Form
    {
        public AutoEnter()
        {
            InitializeComponent();

            LoginField.Text = "(Введите Логин)";
            PassField.Text = "(Введите Пароль)";

            LoginField.ForeColor = Color.Gray;
            PassField.ForeColor = Color.Gray;

            PassField.UseSystemPasswordChar = false;

            


            this.PassField.Size = new Size(this.PassField.Size.Width, 46);

        }

        Point LastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Enter_Button_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text;
            String PassUser = PassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `Password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                CurrentUser.Id = Convert.ToInt32(table.Rows[0]["id"]);
                CurrentUser.Login = table.Rows[0]["login"].ToString();
                CurrentUser.FirstName = table.Rows[0]["Name"].ToString();
                CurrentUser.LastName = table.Rows[0]["Last Name"].ToString();
                CurrentUser.Role = table.Rows[0]["Role"].ToString();
                CurrentUser.Email = table.Rows[0]["Email"].ToString();
                CurrentUser.PhoneNumber = table.Rows[0]["Phone_Number"].ToString();
                CurrentUser.IsActive = Convert.ToInt32(table.Rows[0]["IsActive"]);



                MySqlCommand activateCommand = new MySqlCommand("UPDATE `users` SET `IsActive` = 1 WHERE `id` = @id", db.getConnection());
                activateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = CurrentUser.Id;
                db.openConnection();
                activateCommand.ExecuteNonQuery();

                MySqlCommand blockOthersCommand = new MySqlCommand("UPDATE `users` SET `IsActive` = 0 WHERE `id` != @id", db.getConnection());
                blockOthersCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = CurrentUser.Id;
                blockOthersCommand.ExecuteNonQuery();
                db.closeConnection();

                if (CurrentUser.Role == "User")
                {
                    User_Window userForm = new User_Window();
                    this.Hide();
                    userForm.Show();
                }
                else if (CurrentUser.Role == "Manager")
                {
                    ManagerMainForm managerForm = new ManagerMainForm();
                    this.Hide();
                    managerForm.Show();
                }
                else if (CurrentUser.Role == "Master")
                {
                    MasterMainForm masterForm = new MasterMainForm();
                    this.Hide();
                    masterForm.Show();
                }


                LoginField.Text = "(Введите Логин)";
                PassField.Text = "(Введите Пароль)";
                PassField.UseSystemPasswordChar = false;
                LoginField.ForeColor = Color.Gray;
                PassField.ForeColor = Color.Gray;
            }
            else
            {
                WrongData wrong = new WrongData();
                wrong.Show();
            }
        }

        private void EXIT_MouseEnter(object sender, EventArgs e)
        {
            EXIT.ForeColor = Color.Red;
        }

        private void EXIT_MouseLeave(object sender, EventArgs e)
        {
            EXIT.ForeColor = Color.Black;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "(Введите Логин)")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Orange;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "(Введите Логин)";
                LoginField.ForeColor = Color.Gray;

            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "(Введите Пароль)")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
                PassField.UseSystemPasswordChar = true;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "(Введите Пароль)";
                PassField.ForeColor = Color.Gray;
                PassField.UseSystemPasswordChar = false;
            }
        }

        private void Registration_As_User_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();

            registrationForm.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (PassField.Text == "(Введите Пароль)")
                return;

            if (PassField.UseSystemPasswordChar == true)
            {
                PassField.UseSystemPasswordChar = false;
            }
            else
            {
                PassField.UseSystemPasswordChar = true;
            }
        }
    }

}

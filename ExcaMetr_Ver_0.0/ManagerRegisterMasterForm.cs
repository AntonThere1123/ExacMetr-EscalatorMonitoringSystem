using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class ManagerRegisterMasterForm : Form
    {
        private Point LastPoint;

        public ManagerRegisterMasterForm()
        {
            InitializeComponent();
            SetupForm();

            this.MouseDown += ManagerRegisterMasterForm_MouseDown;
            this.MouseMove += ManagerRegisterMasterForm_MouseMove;
        }

        private void SetupForm()
        {
            this.Text = "Регистрация нового мастера";
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.Size = new Size(450, 610);
            this.MinimumSize = new Size(450, 610);
            this.MaximumSize = new Size(450, 610);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;

            txtLogin.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void ManagerRegisterMasterForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ManagerRegisterMasterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB db = new DB();

            MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE login = @login", db.getConnection());
            checkCmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLogin.Text;

            db.openConnection();
            int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (exists > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.closeConnection();
                return;
            }

            string query = @"INSERT INTO users (login, Password, Name, `Last Name`, Role, Email, Phone_Number, IsActive) 
                            VALUES (@login, @pass, @name, @lastname, 'Master', @email, @phone, 1)";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLogin.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtName.Text;
            cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = txtLastName.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtPhone.Text;

            int result = cmd.ExecuteNonQuery();
            db.closeConnection();

            if (result == 1)
            {
                MessageBox.Show($"Мастер {txtName.Text} {txtLastName.Text} успешно зарегистрирован!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка регистрации мастера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class UserComplaintForm : Form
    {
        private int selectedEscalatorId;

        public UserComplaintForm()
        {
            InitializeComponent();
            SetupForm();
            LoadEscalators();
        }

        private void SetupForm()
        {
            // Настройки формы
            this.Text = "📝 Новая жалоба";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void LoadEscalators()
        {
            try
            {
                DB db = new DB();
                string query = @"SELECT 
                                    e.id, 
                                    CONCAT(e.id, '. ', e.location, ' [', 
                                        CASE e.status
                                            WHEN 'Working' THEN '✅ Работает'
                                            WHEN 'Maintenance' THEN '⚠️ На ремонте'
                                            WHEN 'Broken' THEN '❌ Сломан'
                                        END, ']') AS display_text
                                FROM escalators e
                                ORDER BY e.id";

                DataTable table = db.ExecuteQuery(query);

                cmbEscalator.DisplayMember = "display_text";
                cmbEscalator.ValueMember = "id";
                cmbEscalator.DataSource = table;

                if (cmbEscalator.Items.Count > 0)
                    cmbEscalator.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки эскалаторов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCurrentUserId()
        {
            try
            {
                if (string.IsNullOrEmpty(CurrentUser.Login))
                {
                    MessageBox.Show("CurrentUser.Login пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                DB db = new DB();

                // Пробуем найти по логину
                string query = $"SELECT id FROM users WHERE login = '{CurrentUser.Login}'";
                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    return Convert.ToInt32(table.Rows[0]["id"]);
                }

                // Если не нашли по логину, пробуем найти по email
                if (!string.IsNullOrEmpty(CurrentUser.Email))
                {
                    query = $"SELECT id FROM users WHERE Email = '{CurrentUser.Email}'";
                    table = db.ExecuteQuery(query);

                    if (table.Rows.Count > 0)
                    {
                        return Convert.ToInt32(table.Rows[0]["id"]);
                    }
                }

                MessageBox.Show($"Пользователь с логином '{CurrentUser.Login}' не найден в БД!\nПроверьте таблицу users в phpMyAdmin.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения ID: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Проверка на пустой текст жалобы
            if (string.IsNullOrWhiteSpace(txtComplaint.Text))
            {
                MessageBox.Show("Введите текст жалобы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем ID пользователя из БД
            int userId = GetCurrentUserId();

            if (userId == -1)
            {
                MessageBox.Show("Ошибка авторизации! Пожалуйста, войдите заново.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedEscalatorId = (int)cmbEscalator.SelectedValue;
            string complaintText = txtComplaint.Text;

            DB db = new DB();
            string query = @"INSERT INTO complaints (user_id, escalator_id, complaint_text, status) 
                             VALUES (@uid, @eid, @text, 'New')";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@uid", MySqlDbType.Int32).Value = userId;
            cmd.Parameters.Add("@eid", MySqlDbType.Int32).Value = selectedEscalatorId;
            cmd.Parameters.Add("@text", MySqlDbType.Text).Value = complaintText;

            db.openConnection();

            try
            {
                int result = cmd.ExecuteNonQuery();
                db.closeConnection();

                if (result == 1)
                {
                    MessageBox.Show("Жалоба успешно отправлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при отправке жалобы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                db.closeConnection();
                MessageBox.Show($"MySQL ошибка: {ex.Message}\n\nПередаваемый user_id: {userId}", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                db.closeConnection();
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProsmotrJalob_Click(object sender, EventArgs e)
        {
            MyClaims myClaims = new MyClaims();
            myClaims.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            User_Window US = new User_Window();
            US.ShowDialog();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class ManagerReplyForm : Form
    {
        private int complaintId;
        private Point LastPoint;

        public ManagerReplyForm(int id, string userName, string complaintText, string currentStatus)
        {
            InitializeComponent();
            complaintId = id;

            SetupForm();
            LoadData(userName, complaintText, currentStatus);

            // События для перемещения окна
            this.MouseDown += ManagerReplyForm_MouseDown;
            this.MouseMove += ManagerReplyForm_MouseMove;
        }

        private void SetupForm()
        {
            this.Text = "Ответ на жалобу";
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.Size = new Size(500, 480);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadData(string userName, string complaintText, string currentStatus)
        {
            lblUser.Text = $"Пользователь: {userName}";
            lblComplaintText.Text = complaintText;

            // Заполняем ComboBox статусами
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "New", "InProgress", "Resolved" });
            cmbStatus.SelectedItem = currentStatus;
        }

        // Перемещение окна
        private void ManagerReplyForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ManagerReplyForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string response = txtResponse.Text;
            string newStatus = cmbStatus.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(response))
            {
                MessageBox.Show("Введите ответ на жалобу!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Выберите статус!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB db = new DB();
            string query = @"UPDATE complaints 
                            SET manager_response = @response, status = @status 
                            WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@response", MySqlDbType.Text).Value = response;
            cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = newStatus;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = complaintId;

            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            db.closeConnection();

            if (result == 1)
            {
                MessageBox.Show("Ответ успешно отправлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при отправке ответа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExcaMetr_Ver_0._0
{
    public partial class ManagerEscalatorForm : Form
    {
        private int escalatorId;
        private Point LastPoint;

        public ManagerEscalatorForm(int id, string location)
        {
            InitializeComponent();
            escalatorId = id;

            SetupForm();
            LoadData(location);

            this.MouseDown += ManagerEscalatorForm_MouseDown;
            this.MouseMove += ManagerEscalatorForm_MouseMove;
        }

        private void SetupForm()
        {
            this.Text = "Изменение статуса эскалатора";
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadData(string location)
        {
            lblLocation.Text = $"Эскалатор: {location}";

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Working", "Maintenance", "Broken" });
            cmbStatus.SelectedIndex = 0;
        }

        private void ManagerEscalatorForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ManagerEscalatorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newStatus = cmbStatus.SelectedItem?.ToString();
            string reason = txtReason.Text;

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Выберите новый статус!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB db = new DB();

            string getOldStatusQuery = $"SELECT status FROM escalators WHERE id = {escalatorId}";
            DataTable table = db.ExecuteQuery(getOldStatusQuery);
            string oldStatus = table.Rows[0]["status"].ToString();

            string updateQuery = "UPDATE escalators SET status = @status WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(updateQuery, db.getConnection());
            cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = newStatus;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = escalatorId;

            db.openConnection();
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                string logQuery = @"INSERT INTO status_changes (escalator_id, changed_by_manager_id, old_status, new_status, change_reason) 
                                    VALUES (@escId, @managerId, @oldStatus, @newStatus, @reason)";

                MySqlCommand logCmd = new MySqlCommand(logQuery, db.getConnection());
                logCmd.Parameters.Add("@escId", MySqlDbType.Int32).Value = escalatorId;
                logCmd.Parameters.Add("@managerId", MySqlDbType.Int32).Value = CurrentUser.Id;
                logCmd.Parameters.Add("@oldStatus", MySqlDbType.Enum).Value = oldStatus;
                logCmd.Parameters.Add("@newStatus", MySqlDbType.Enum).Value = newStatus;
                logCmd.Parameters.Add("@reason", MySqlDbType.VarChar).Value = reason;
                logCmd.ExecuteNonQuery();

                db.closeConnection();

                MessageBox.Show($"Статус эскалатора изменён с '{oldStatus}' на '{newStatus}'!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Ошибка при изменении статуса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
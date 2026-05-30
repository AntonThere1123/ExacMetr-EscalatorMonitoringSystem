using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class MasterMainForm : Form
    {
        private Point LastPoint;

        public MasterMainForm()
        {
            InitializeComponent();
            SetupForm();
            LoadMyEscalators();
            LoadMyTasks();

            this.MouseDown += MasterMainForm_MouseDown;
            this.MouseMove += MasterMainForm_MouseMove;
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(900, 600);
            this.Text = $" Панель мастера - {CurrentUser.FirstName} {CurrentUser.LastName}";
        }

        private void MasterMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void MasterMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoadMyEscalators()
        {
            try
            {
                DB db = new DB();
                string query = $@"SELECT 
                                    id,
                                    location,
                                    CASE status
                                        WHEN 'Working' THEN 'Работает'
                                        WHEN 'Maintenance' THEN 'На ремонте'
                                        WHEN 'Broken' THEN 'Сломан'
                                        ELSE status
                                    END AS status,
                                    last_maintenance_date
                                FROM escalators
                                WHERE assigned_master_id = {CurrentUser.Id}
                                ORDER BY id";

                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    dataGridViewEscalators.DataSource = table;
                }
                else
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("id");
                    emptyTable.Columns.Add("location");
                    emptyTable.Columns.Add("status");
                    emptyTable.Columns.Add("last_maintenance_date");
                    emptyTable.Rows.Add(0, "Нет закреплённых эскалаторов", "", "");
                    dataGridViewEscalators.DataSource = emptyTable;
                    dataGridViewEscalators.Columns["id"].Visible = false;
                    dataGridViewEscalators.Columns["last_maintenance_date"].Visible = false;
                }

                dataGridViewEscalators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewEscalators.BackgroundColor = Color.FromArgb(45, 41, 38);
                dataGridViewEscalators.AllowUserToAddRows = false;
                dataGridViewEscalators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки эскалаторов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMyTasks()
        {
            try
            {
                DB db = new DB();
                string query = $@"SELECT 
                                    t.id,
                                    e.location,
                                    t.task_text,
                                    t.status,
                                    DATE_FORMAT(t.created_at, '%d.%m.%Y %H:%i') AS created_date
                                FROM tasks t
                                JOIN escalators e ON t.escalator_id = e.id
                                WHERE t.master_id = {CurrentUser.Id}
                                ORDER BY 
                                    CASE t.status
                                        WHEN 'Pending' THEN 1
                                        WHEN 'InProgress' THEN 2
                                        WHEN 'Completed' THEN 3
                                        ELSE 4
                                    END, t.created_at DESC";

                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    dataGridViewTasks.DataSource = table;

                    foreach (DataGridViewRow row in dataGridViewTasks.Rows)
                    {
                        if (row.Cells["status"] != null && row.Cells["status"].Value != null)
                        {
                            string status = row.Cells["status"].Value.ToString();
                            if (status == "Pending")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                            else if (status == "InProgress")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                            else if (status == "Completed")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
                        }
                    }
                }
                else
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("id");
                    emptyTable.Columns.Add("location");
                    emptyTable.Columns.Add("task_text");
                    emptyTable.Columns.Add("status");
                    emptyTable.Columns.Add("created_date");
                    emptyTable.Rows.Add(0, "Нет заданий", "", "", "");
                    dataGridViewTasks.DataSource = emptyTable;
                    dataGridViewTasks.Columns["id"].Visible = false;
                }

                dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTasks.BackgroundColor = Color.FromArgb(45, 41, 38);
                dataGridViewTasks.AllowUserToAddRows = false;
                dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заданий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTaskStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0 || dataGridViewTasks.SelectedRows[0].Cells["id"].Value == null)
            {
                MessageBox.Show("Выберите задание!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewTasks.SelectedRows[0].Cells["location"].Value.ToString() == "Нет заданий")
            {
                MessageBox.Show("Нет заданий для изменения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["id"].Value);
            string currentStatus = dataGridViewTasks.SelectedRows[0].Cells["status"].Value.ToString();

            string newStatus = "";
            if (currentStatus == "Pending")
                newStatus = "InProgress";
            else if (currentStatus == "InProgress")
                newStatus = "Completed";
            else
            {
                MessageBox.Show("Задание уже выполнено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DB db = new DB();
            string query = "UPDATE tasks SET status = @status WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@status", MySqlDbType.Enum).Value = newStatus;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = taskId;

            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            db.closeConnection();

            if (result == 1)
            {
                MessageBox.Show($"Статус задания изменён на '{newStatus}'!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyTasks();
            }
            else
            {
                MessageBox.Show("Ошибка изменения статуса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewComplaint_Click(object sender, EventArgs e)
        {
            UserComplaintForm complaintForm = new UserComplaintForm();
            complaintForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Logout();
            this.Close();

            AutoEnter loginForm = new AutoEnter();
            loginForm.Show();
        }

        private void Leave_button_Click(object sender, EventArgs e)
        {
            CurrentUser.Logout();
            this.Close();

            AutoEnter loginForm = new AutoEnter();
            loginForm.Show();
        }
    }
}
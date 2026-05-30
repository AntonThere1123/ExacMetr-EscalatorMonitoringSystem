using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class ManagerMainForm : Form
    {
        private Point LastPoint;

        public ManagerMainForm()
        {
            InitializeComponent();
            SetupForm();
            LoadComplaints();
            LoadEscalators();
            LoadMasters();

            this.MouseDown += ManagerMainForm_MouseDown;
            this.MouseMove += ManagerMainForm_MouseMove;
        }

        private void SetupForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            this.MinimumSize = new Size(900, 600);
            this.Text = $"Панель менеджера - {CurrentUser.FirstName} {CurrentUser.LastName}";
        }

        private void ManagerMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ManagerMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoadComplaints()
        {
            try
            {
                DB db = new DB();

                string query = @"SELECT 
                                    c.id,
                                    u.Name AS user_name,
                                    u.`Last Name` AS user_lastname,
                                    e.location,
                                    c.complaint_text,
                                    c.status,
                                    c.manager_response,
                                    DATE_FORMAT(c.created_at, '%d.%m.%Y %H:%i') AS created_date
                                FROM complaints c
                                LEFT JOIN users u ON c.user_id = u.id
                                LEFT JOIN escalators e ON c.escalator_id = e.id
                                ORDER BY 
                                    CASE c.status
                                        WHEN 'New' THEN 1
                                        WHEN 'InProgress' THEN 2
                                        WHEN 'Resolved' THEN 3
                                        ELSE 4
                                    END, c.created_at DESC";

                DataTable table = db.ExecuteQuery(query);
                dataGridViewComplaints.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    dataGridViewComplaints.DataSource = null;
                    dataGridViewComplaints.Rows.Clear();
                    dataGridViewComplaints.Rows.Add("Нет жалоб");
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridViewComplaints.Rows)
                    {
                        if (row.Cells["status"] != null && row.Cells["status"].Value != null)
                        {
                            string status = row.Cells["status"].Value.ToString();
                            if (status == "New")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                            else if (status == "InProgress")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200);
                            else if (status == "Resolved")
                                row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки жалоб: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEscalators()
        {
            try
            {
                DB db = new DB();
                string query = @"SELECT 
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
                                ORDER BY id";

                DataTable table = db.ExecuteQuery(query);
                dataGridViewEscalators.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    dataGridViewEscalators.DataSource = null;
                    dataGridViewEscalators.Rows.Clear();
                    dataGridViewEscalators.Rows.Add("Нет эскалаторов");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки эскалаторов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMasters()
        {
            try
            {
                DB db = new DB();
                string query = @"SELECT 
                                    id,
                                    login,
                                    Name,
                                    `Last Name`,
                                    Email,
                                    Phone_Number
                                FROM users
                                WHERE Role = 'Master'
                                ORDER BY id";

                DataTable table = db.ExecuteQuery(query);
                dataGridViewMasters.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    dataGridViewMasters.DataSource = null;
                    dataGridViewMasters.Rows.Clear();
                    dataGridViewMasters.Rows.Add("Нет мастеров");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки мастеров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (dataGridViewComplaints.SelectedRows.Count == 0 || dataGridViewComplaints.SelectedRows[0].Cells["id"] == null)
            {
                MessageBox.Show("Выберите жалобу для ответа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int complaintId = Convert.ToInt32(dataGridViewComplaints.SelectedRows[0].Cells["id"].Value);
            string userName = dataGridViewComplaints.SelectedRows[0].Cells["user_name"].Value.ToString();
            string complaintText = dataGridViewComplaints.SelectedRows[0].Cells["complaint_text"].Value.ToString();
            string currentStatus = dataGridViewComplaints.SelectedRows[0].Cells["status"].Value.ToString();

            ManagerReplyForm replyForm = new ManagerReplyForm(complaintId, userName, complaintText, currentStatus);
            if (replyForm.ShowDialog() == DialogResult.OK)
            {
                LoadComplaints();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewEscalators.SelectedRows.Count == 0 || dataGridViewEscalators.SelectedRows[0].Cells["id"] == null)
            {
                MessageBox.Show("Выберите эскалатор!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int escalatorId = Convert.ToInt32(dataGridViewEscalators.SelectedRows[0].Cells["id"].Value);
            string location = dataGridViewEscalators.SelectedRows[0].Cells["location"].Value.ToString();

            ManagerEscalatorForm escalatorForm = new ManagerEscalatorForm(escalatorId, location);
            if (escalatorForm.ShowDialog() == DialogResult.OK)
            {
                LoadEscalators();
            }
        }

        private void btnRegisterMaster_Click(object sender, EventArgs e)
        {
            ManagerRegisterMasterForm registerForm = new ManagerRegisterMasterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                LoadMasters();
                LoadEscalators();
            }
        }

        private void btnAssignMaster_Click(object sender, EventArgs e)
        {
            ManagerAssignMasterForm assignForm = new ManagerAssignMasterForm();
            if (assignForm.ShowDialog() == DialogResult.OK)
            {
                LoadEscalators();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Logout();
            this.Close();

            foreach (Form form in Application.OpenForms)
            {
                if (form is AutoEnter)
                {
                    form.Show();
                    break;
                }
            }
        }
    }
}
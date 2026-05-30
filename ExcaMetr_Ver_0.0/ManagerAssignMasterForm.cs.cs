using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExcaMetr_Ver_0._0
{
    public partial class ManagerAssignMasterForm : Form
    {
        private Point LastPoint;

        public ManagerAssignMasterForm()
        {
            InitializeComponent();
            SetupForm();
            LoadData();

            this.MouseDown += ManagerAssignMasterForm_MouseDown;
            this.MouseMove += ManagerAssignMasterForm_MouseMove;
        }

        private void SetupForm()
        {
            this.Text = " Назначение мастера на эскалатор";
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.Size = new Size(450, 320);
            this.MinimumSize = new Size(450, 320);
            this.MaximumSize = new Size(450, 320);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadData()
        {
            try
            {
                DB db = new DB();

                string escalatorQuery = @"SELECT id, location FROM escalators 
                                         WHERE assigned_master_id IS NULL OR assigned_master_id = 0
                                         ORDER BY id";
                DataTable escalators = db.ExecuteQuery(escalatorQuery);

                if (escalators.Rows.Count > 0)
                {
                    cmbEscalator.DataSource = escalators;
                    cmbEscalator.DisplayMember = "location";
                    cmbEscalator.ValueMember = "id";
                    cmbEscalator.Enabled = true;
                }
                else
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("id");
                    emptyTable.Columns.Add("location");
                    emptyTable.Rows.Add(0, "Нет свободных эскалаторов");
                    cmbEscalator.DataSource = emptyTable;
                    cmbEscalator.DisplayMember = "location";
                    cmbEscalator.ValueMember = "id";
                    cmbEscalator.Enabled = false;
                }

                string masterQuery = @"SELECT id, CONCAT(Name, ' ', `Last Name`, ' (', login, ')') AS fullname 
                                      FROM users 
                                      WHERE Role = 'Master' AND IsActive = 1
                                      ORDER BY Name";
                DataTable masters = db.ExecuteQuery(masterQuery);

                if (masters.Rows.Count > 0)
                {
                    cmbMaster.DataSource = masters;
                    cmbMaster.DisplayMember = "fullname";
                    cmbMaster.ValueMember = "id";
                    cmbMaster.Enabled = true;
                }
                else
                {
                    DataTable emptyMasters = new DataTable();
                    emptyMasters.Columns.Add("id");
                    emptyMasters.Columns.Add("fullname");
                    emptyMasters.Rows.Add(0, "Нет активных мастеров");
                    cmbMaster.DataSource = emptyMasters;
                    cmbMaster.DisplayMember = "fullname";
                    cmbMaster.ValueMember = "id";
                    cmbMaster.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManagerAssignMasterForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void ManagerAssignMasterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbEscalator.SelectedValue == null || cmbMaster.SelectedValue == null)
            {
                MessageBox.Show("Выберите эскалатор и мастера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int escalatorId = (int)cmbEscalator.SelectedValue;
            int masterId = (int)cmbMaster.SelectedValue;

            if (escalatorId == 0 || masterId == 0)
            {
                MessageBox.Show("Нет доступных эскалаторов или мастеров!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB db = new DB();
            string query = "UPDATE escalators SET assigned_master_id = @masterId WHERE id = @escalatorId";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            cmd.Parameters.Add("@masterId", MySqlDbType.Int32).Value = masterId;
            cmd.Parameters.Add("@escalatorId", MySqlDbType.Int32).Value = escalatorId;

            db.openConnection();
            int result = cmd.ExecuteNonQuery();
            db.closeConnection();

            if (result == 1)
            {
                MessageBox.Show("Мастер успешно назначен на эскалатор!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при назначении мастера!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
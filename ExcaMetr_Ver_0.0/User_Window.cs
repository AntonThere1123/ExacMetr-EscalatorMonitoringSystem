using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ExcaMetr_Ver_0._0
{
    public partial class User_Window : Form
    {
        public User_Window()
        {
            InitializeComponent();

            // Настройка ListBox под тёмную тему
            SetupListBox();

            EXIT.ForeColor = Color.Black;
            Greetengs.Text = $"Добро пожаловать в режим зрителя {CurrentUser.FirstName}!";

            // Меняем цвет Greetengs на основной
            Greetengs.ForeColor = Color.FromArgb(204, 119, 34);

            ProsmotrJalob.ForeColor = Color.FromArgb(204, 119, 34);
            JalobandZametok.ForeColor = Color.FromArgb(204, 119, 34);
            EXIT_TO_REG.ForeColor = Color.FromArgb(204, 119, 34);

            // Загрузка списка эскалаторов
            LoadEscalators();
        }

        // ========== НАСТРОЙКА LISTBOX ПОД ТЁМНУЮ ТЕМУ ==========
        private void SetupListBox()
        {
            // Основные настройки
            listBoxEscalators.Font = new Font("Segoe UI", 11);
            listBoxEscalators.BackColor = Color.FromArgb(45, 41, 38);
            listBoxEscalators.ForeColor = Color.FromArgb(204, 119, 34);
            listBoxEscalators.BorderStyle = BorderStyle.None;

            listBoxEscalators.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxEscalators.ItemHeight = 35;
            listBoxEscalators.DrawItem += listBoxEscalators_DrawItem;
            listBoxEscalators.Paint += listBoxEscalators_Paint;
        }

        private void listBoxEscalators_Paint(object sender, PaintEventArgs e)
        {
            ListBox lb = sender as ListBox;
            ControlPaint.DrawBorder(e.Graphics, lb.ClientRectangle,
                Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid);
        }

        private void listBoxEscalators_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 41, 38)), e.Bounds);

            string item = listBoxEscalators.Items[e.Index].ToString();

            Color textColor;
            if (item.Contains("✅"))
                textColor = Color.LightGreen;
            else if (item.Contains("❌"))
                textColor = Color.Salmon;
            else if (item.Contains("⚠️"))
                textColor = Color.Orange;
            else
                textColor = Color.FromArgb(204, 119, 34);

            using (Brush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(item, listBoxEscalators.Font, brush, e.Bounds.X + 5, e.Bounds.Y + 5);
            }

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                using (Pen pen = new Pen(Color.FromArgb(204, 119, 34), 2))
                {
                    e.Graphics.DrawRectangle(pen, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
                }
            }

            e.DrawFocusRectangle();
        }

        private void LoadEscalators()
        {
            try
            {
                DB db = new DB();
                string query = @"SELECT 
                                    e.id,
                                    e.location,
                                    CASE e.status
                                        WHEN 'Working' THEN '✅ Работает'
                                        WHEN 'Maintenance' THEN '⚠️ На ремонте'
                                        WHEN 'Broken' THEN '❌ Сломан'
                                    END AS status_text
                                FROM escalators e
                                ORDER BY e.id";

                DataTable table = db.ExecuteQuery(query);

                listBoxEscalators.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    string item = $"{row["id"]}. {row["location"]} [{row["status_text"]}]";
                    listBoxEscalators.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки эскалаторов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JalobandZametok_Click(object sender, EventArgs e)
        {
            UserComplaintForm complaintForm = new UserComplaintForm();
            complaintForm.ShowDialog();
        }

        private void ProsmotrJalob_Click(object sender, EventArgs e)
        {
            UserComplaintForm USCM = new UserComplaintForm();
            USCM.ShowDialog();
        }

        private void EXIT_TO_REG_Click(object sender, EventArgs e)
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


        Point LastPoint;

        private void User_Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void User_Window_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void User_Window_Load(object sender, EventArgs e) { }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EXIT_MouseEnter(object sender, EventArgs e)
        {
            EXIT.ForeColor = Color.Red;
        }

        private void EXIT_MouseLeave(object sender, EventArgs e)
        {
            EXIT.ForeColor = Color.Black;
        }

        private void Greetengs_Click(object sender, EventArgs e) { }

        private void ProsmotrJalob_MouseEnter(object sender, EventArgs e)
        {
            ProsmotrJalob.ForeColor = Color.DarkOrange;
        }

        private void ProsmotrJalob_MouseLeave(object sender, EventArgs e)
        {
            ProsmotrJalob.ForeColor = Color.FromArgb(204, 119, 34);
        }

        private void JalobandZametok_MouseEnter(object sender, EventArgs e)
        {
            JalobandZametok.ForeColor = Color.DarkOrange;
        }

        private void JalobandZametok_MouseLeave(object sender, EventArgs e)
        {
            JalobandZametok.ForeColor = Color.FromArgb(204, 119, 34);
        }

        private void EXIT_TO_REG_MouseEnter(object sender, EventArgs e)
        {
            EXIT_TO_REG.ForeColor = Color.DarkRed;
        }

        private void EXIT_TO_REG_MouseLeave(object sender, EventArgs e)
        {
            EXIT_TO_REG.ForeColor = Color.FromArgb(204, 119, 34);
        }

        private void JalobandZametok_Click_1(object sender, EventArgs e)
        {
            MyClaims myclaims = new MyClaims();
            myclaims.ShowDialog();
        }

        private void EXIT_TO_REG_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AutoEnter AU = new AutoEnter();
            AU.Show();
        }
    }
}
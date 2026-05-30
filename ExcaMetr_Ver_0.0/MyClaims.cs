using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExcaMetr_Ver_0._0
{
    public partial class MyClaims : Form
    {
        public MyClaims()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            this.Text = "Мои жалобы";
            this.BackColor = Color.FromArgb(45, 41, 38);
            this.StartPosition = FormStartPosition.CenterParent;

            // Настройка ListBox
            SetupListBox();

            // Загрузка жалоб
            LoadMyComplaints();
        }

        Point LastPoint;

        private void MyClaims_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MyClaims_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void SetupListBox()
        {
            listBoxClaims.Font = new Font("Segoe UI", 11);
            listBoxClaims.BackColor = Color.FromArgb(45, 41, 38);
            listBoxClaims.ForeColor = Color.FromArgb(204, 119, 34);
            listBoxClaims.BorderStyle = BorderStyle.None;

            listBoxClaims.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxClaims.ItemHeight = 70;  
            listBoxClaims.DrawItem += listBoxClaims_DrawItem;

            listBoxClaims.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, listBoxClaims.ClientRectangle,
                    Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(204, 119, 34), 2, ButtonBorderStyle.Solid);
            };
        }

        private void listBoxClaims_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Фон
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 41, 38)), e.Bounds);

            string item = listBoxClaims.Items[e.Index].ToString();
            string[] parts = item.Split('|');

            if (parts.Length >= 3)
            {
                string location = parts[0];
                string status = parts[1];
                string complaintText = parts.Length > 2 ? parts[2] : "";

                if (complaintText.Length > 50)
                    complaintText = complaintText.Substring(0, 47) + "...";

                Color statusColor;
                if (status.Contains("Новая"))
                    statusColor = Color.Orange;
                else if (status.Contains("В работе"))
                    statusColor = Color.DodgerBlue;
                else if (status.Contains("Решена"))
                    statusColor = Color.LightGreen;
                else
                    statusColor = Color.Gray;

                using (Brush brush = new SolidBrush(Color.FromArgb(204, 119, 34)))
                {
                    e.Graphics.DrawString(location, new Font("Segoe UI", 11, FontStyle.Bold), brush, e.Bounds.X + 5, e.Bounds.Y + 5);
                }

                using (Brush brush = new SolidBrush(statusColor))
                {
                    e.Graphics.DrawString($"Статус: {status}", new Font("Segoe UI", 9), brush, e.Bounds.X + 5, e.Bounds.Y + 28);
                }
                using (Brush brush = new SolidBrush(Color.LightGray))
                {
                    e.Graphics.DrawString(complaintText, new Font("Segoe UI", 9), brush, e.Bounds.X + 5, e.Bounds.Y + 48);
                }
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

        private void LoadMyComplaints()
        {
            try
            {
                DB db = new DB();
                string query = $@"SELECT 
                            c.id,
                            e.location,
                            c.complaint_text,
                            c.status,
                            c.manager_response,
                            DATE_FORMAT(c.created_at, '%d.%m.%Y %H:%i') AS created_date
                        FROM complaints c
                        JOIN escalators e ON c.escalator_id = e.id
                        WHERE c.user_id = {CurrentUser.Id}
                        ORDER BY c.created_at DESC";

                DataTable table = db.ExecuteQuery(query);

                listBoxClaims.Items.Clear();

                if (table.Rows.Count == 0)
                {
                    listBoxClaims.Items.Add("|Нет жалоб|У вас пока нет отправленных жалоб");
                    return;
                }

                foreach (DataRow row in table.Rows)
                {
                    string status = row["status"].ToString();
                    string statusText;

                    switch (status)
                    {
                        case "New":
                            statusText = "Новая";
                            break;
                        case "InProgress":
                            statusText = "В работе";
                            break;
                        case "Resolved":
                            statusText = "Решена";
                            break;
                        default:
                            statusText = status;
                            break;
                    }

                    string item = $"{row["location"]}|{statusText}|{row["complaint_text"]}";
                    listBoxClaims.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки жалоб: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBoxClaims_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxClaims.SelectedIndex == -1) return;

            string selectedItem = listBoxClaims.SelectedItem.ToString();
            string[] parts = selectedItem.Split('|');

            if (parts.Length >= 3)
            {
                string location = parts[0];
                string status = parts[1];
                string complaintText = parts[2];

                string managerResponse = GetManagerResponse(location);

                string message = $"Место: {location}\n\n" +
                                 $"Жалоба: {complaintText}\n\n" +
                                 $"Статус: {status}\n\n" +
                                 $"Ответ менеджера:\n{(string.IsNullOrEmpty(managerResponse) ? "⏳ Ожидается ответ" : managerResponse)}";

                MessageBox.Show(message, "Детали жалобы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetManagerResponse(string location)
        {
            try
            {
                DB db = new DB();
                string query = $@"SELECT manager_response 
                                FROM complaints c
                                JOIN escalators e ON c.escalator_id = e.id
                                WHERE e.location = '{location.Replace("'", "''")}' AND c.user_id = {CurrentUser.Id}
                                ORDER BY c.created_at DESC LIMIT 1";

                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0 && table.Rows[0]["manager_response"] != DBNull.Value)
                    return table.Rows[0]["manager_response"].ToString();
            }
            catch { }

            return null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyComplaints();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace ExcaMetr_Ver_0._0
{
    partial class ManagerReplyForm
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.Label lblComplaintText;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.lblComplaintText = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUser
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblUser.Location = new System.Drawing.Point(20, 20);
            this.lblUser.Size = new System.Drawing.Size(80, 25);
            this.lblUser.Text = "Пользователь:";

            // lblComplaint
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblComplaint.Location = new System.Drawing.Point(20, 60);
            this.lblComplaint.Text = "Текст жалобы:";

            // lblComplaintText
            this.lblComplaintText.AutoSize = false;
            this.lblComplaintText.BackColor = System.Drawing.Color.FromArgb(35, 31, 28);
            this.lblComplaintText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComplaintText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblComplaintText.ForeColor = System.Drawing.Color.LightGray;
            this.lblComplaintText.Location = new System.Drawing.Point(20, 90);
            this.lblComplaintText.Size = new System.Drawing.Size(440, 80);
            this.lblComplaintText.Text = "";

            // lblResponse
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResponse.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblResponse.Location = new System.Drawing.Point(20, 185);
            this.lblResponse.Text = "Ваш ответ:";

            // txtResponse
            this.txtResponse.BackColor = System.Drawing.Color.FromArgb(35, 31, 28);
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResponse.ForeColor = System.Drawing.Color.White;
            this.txtResponse.Location = new System.Drawing.Point(20, 215);
            this.txtResponse.Multiline = true;
            this.txtResponse.Size = new System.Drawing.Size(440, 100);
            this.txtResponse.TabIndex = 0;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblStatus.Location = new System.Drawing.Point(20, 330);
            this.lblStatus.Text = "Новый статус:";

            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(20, 360);
            this.cmbStatus.Size = new System.Drawing.Size(150, 31);
            this.cmbStatus.TabIndex = 1;

            // btnSend
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(20, 410);
            this.btnSend.Size = new System.Drawing.Size(120, 40);
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(340, 410);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ManagerReplyForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 470);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblComplaint);
            this.Controls.Add(this.lblComplaintText);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Name = "ManagerReplyForm";
            this.Text = "Ответ на жалобу";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
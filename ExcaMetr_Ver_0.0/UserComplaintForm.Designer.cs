namespace ExcaMetr_Ver_0._0
{
    partial class UserComplaintForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbEscalator;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEscalator;
        private System.Windows.Forms.Label lblComplaint;

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
            cmbEscalator = new ComboBox();
            txtComplaint = new TextBox();
            btnSend = new Button();
            btnCancel = new Button();
            lblEscalator = new Label();
            lblComplaint = new Label();
            SuspendLayout();
            // 
            // cmbEscalator
            // 
            cmbEscalator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEscalator.Font = new Font("Segoe UI", 11F);
            cmbEscalator.Location = new Point(30, 60);
            cmbEscalator.Name = "cmbEscalator";
            cmbEscalator.Size = new Size(370, 28);
            cmbEscalator.TabIndex = 1;
            // 
            // txtComplaint
            // 
            txtComplaint.Font = new Font("Segoe UI", 11F);
            txtComplaint.Location = new Point(30, 140);
            txtComplaint.Multiline = true;
            txtComplaint.Name = "txtComplaint";
            txtComplaint.ScrollBars = ScrollBars.Vertical;
            txtComplaint.Size = new Size(370, 150);
            txtComplaint.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(204, 119, 34);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(140, 310);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 35);
            btnSend.TabIndex = 4;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(80, 80, 80);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(280, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 5;
            btnCancel.Text = " Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblEscalator
            // 
            lblEscalator.AutoSize = true;
            lblEscalator.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEscalator.ForeColor = Color.FromArgb(204, 119, 34);
            lblEscalator.Location = new Point(30, 30);
            lblEscalator.Name = "lblEscalator";
            lblEscalator.Size = new Size(161, 20);
            lblEscalator.TabIndex = 0;
            lblEscalator.Text = "Выберите эскалатор:";
            // 
            // lblComplaint
            // 
            lblComplaint.AutoSize = true;
            lblComplaint.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblComplaint.ForeColor = Color.FromArgb(204, 119, 34);
            lblComplaint.Location = new Point(30, 110);
            lblComplaint.Name = "lblComplaint";
            lblComplaint.Size = new Size(115, 20);
            lblComplaint.TabIndex = 2;
            lblComplaint.Text = "Текст жалобы:";
            // 
            // UserComplaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 38);
            ClientSize = new Size(434, 371);
            Controls.Add(lblEscalator);
            Controls.Add(cmbEscalator);
            Controls.Add(lblComplaint);
            Controls.Add(txtComplaint);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserComplaintForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Новая жалоба";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
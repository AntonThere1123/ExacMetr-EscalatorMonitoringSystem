namespace ExcaMetr_Ver_0._0
{
    partial class MyClaims
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxClaims;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;

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
            listBoxClaims = new ListBox();
            btnClose = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // listBoxClaims
            // 
            listBoxClaims.Location = new Point(20, 60);
            listBoxClaims.Name = "listBoxClaims";
            listBoxClaims.Size = new Size(460, 349);
            listBoxClaims.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(80, 80, 80);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(380, 420);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 3;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(204, 119, 34);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 420);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(204, 119, 34);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " Мои жалобы";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 119, 34);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 17);
            panel1.TabIndex = 4;
            // 
            // MyClaims
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 38);
            ClientSize = new Size(500, 480);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(listBoxClaims);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MyClaims";
            StartPosition = FormStartPosition.CenterParent;
            Text = " Мои жалобы";
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
    }
}
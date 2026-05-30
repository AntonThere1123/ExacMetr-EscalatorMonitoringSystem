namespace ExcaMetr_Ver_0._0
{
    partial class ManagerMainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageComplaints;
        private System.Windows.Forms.TabPage tabPageEscalators;
        private System.Windows.Forms.TabPage tabPageMasters;
        private System.Windows.Forms.DataGridView dataGridViewComplaints;
        private System.Windows.Forms.DataGridView dataGridViewEscalators;
        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnRegisterMaster;
        private System.Windows.Forms.Button btnAssignMaster;
        private System.Windows.Forms.Button btnLogout;

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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageComplaints = new System.Windows.Forms.TabPage();
            this.tabPageEscalators = new System.Windows.Forms.TabPage();
            this.tabPageMasters = new System.Windows.Forms.TabPage();
            this.dataGridViewComplaints = new System.Windows.Forms.DataGridView();
            this.dataGridViewEscalators = new System.Windows.Forms.DataGridView();
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnRegisterMaster = new System.Windows.Forms.Button();
            this.btnAssignMaster = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.tabControlMain.SuspendLayout();
            this.tabPageComplaints.SuspendLayout();
            this.tabPageEscalators.SuspendLayout();
            this.tabPageMasters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewComplaints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewEscalators).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewMasters).BeginInit();
            this.SuspendLayout();

            // tabControlMain
            this.tabControlMain.Controls.Add(this.tabPageComplaints);
            this.tabControlMain.Controls.Add(this.tabPageEscalators);
            this.tabControlMain.Controls.Add(this.tabPageMasters);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Size = new System.Drawing.Size(900, 600);
            this.tabControlMain.TabIndex = 0;

            // tabPageComplaints
            this.tabPageComplaints.BackColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.tabPageComplaints.Controls.Add(this.dataGridViewComplaints);
            this.tabPageComplaints.Controls.Add(this.btnReply);
            this.tabPageComplaints.Location = new System.Drawing.Point(4, 27);
            this.tabPageComplaints.Name = "tabPageComplaints";
            this.tabPageComplaints.Size = new System.Drawing.Size(892, 569);
            this.tabPageComplaints.Text = "Жалобы";

            // tabPageEscalators
            this.tabPageEscalators.BackColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.tabPageEscalators.Controls.Add(this.dataGridViewEscalators);
            this.tabPageEscalators.Controls.Add(this.btnChangeStatus);
            this.tabPageEscalators.Location = new System.Drawing.Point(4, 27);
            this.tabPageEscalators.Name = "tabPageEscalators";
            this.tabPageEscalators.Size = new System.Drawing.Size(892, 569);
            this.tabPageEscalators.Text = "Эскалаторы";

            // tabPageMasters
            this.tabPageMasters.BackColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.tabPageMasters.Controls.Add(this.dataGridViewMasters);
            this.tabPageMasters.Controls.Add(this.btnRegisterMaster);
            this.tabPageMasters.Controls.Add(this.btnAssignMaster);
            this.tabPageMasters.Controls.Add(this.btnLogout);
            this.tabPageMasters.Location = new System.Drawing.Point(4, 27);
            this.tabPageMasters.Name = "tabPageMasters";
            this.tabPageMasters.Size = new System.Drawing.Size(892, 569);
            this.tabPageMasters.Text = "Мастера";

            // dataGridViewComplaints
            this.dataGridViewComplaints.AllowUserToAddRows = false;
            this.dataGridViewComplaints.AllowUserToDeleteRows = false;
            this.dataGridViewComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComplaints.BackgroundColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.dataGridViewComplaints.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewComplaints.Size = new System.Drawing.Size(870, 470);
            this.dataGridViewComplaints.TabIndex = 0;
            this.dataGridViewComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // dataGridViewEscalators
            this.dataGridViewEscalators.AllowUserToAddRows = false;
            this.dataGridViewEscalators.AllowUserToDeleteRows = false;
            this.dataGridViewEscalators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEscalators.BackgroundColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.dataGridViewEscalators.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewEscalators.Size = new System.Drawing.Size(870, 470);
            this.dataGridViewEscalators.TabIndex = 0;
            this.dataGridViewEscalators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // dataGridViewMasters
            this.dataGridViewMasters.AllowUserToAddRows = false;
            this.dataGridViewMasters.AllowUserToDeleteRows = false;
            this.dataGridViewMasters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMasters.BackgroundColor = System.Drawing.Color.FromArgb(45, 41, 38);
            this.dataGridViewMasters.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewMasters.Size = new System.Drawing.Size(870, 470);
            this.dataGridViewMasters.TabIndex = 0;
            this.dataGridViewMasters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // btnReply
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReply.ForeColor = System.Drawing.Color.White;
            this.btnReply.Location = new System.Drawing.Point(10, 490);
            this.btnReply.Size = new System.Drawing.Size(120, 40);
            this.btnReply.Text = "Ответить";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);

            // btnChangeStatus
            this.btnChangeStatus.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Location = new System.Drawing.Point(10, 490);
            this.btnChangeStatus.Size = new System.Drawing.Size(150, 40);
            this.btnChangeStatus.Text = "Изменить статус";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);

            // btnRegisterMaster
            this.btnRegisterMaster.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnRegisterMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterMaster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegisterMaster.ForeColor = System.Drawing.Color.White;
            this.btnRegisterMaster.Location = new System.Drawing.Point(10, 490);
            this.btnRegisterMaster.Size = new System.Drawing.Size(160, 40);
            this.btnRegisterMaster.Text = "Добавить мастера";
            this.btnRegisterMaster.UseVisualStyleBackColor = false;
            this.btnRegisterMaster.Click += new System.EventHandler(this.btnRegisterMaster_Click);

            // btnAssignMaster
            this.btnAssignMaster.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnAssignMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMaster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignMaster.ForeColor = System.Drawing.Color.White;
            this.btnAssignMaster.Location = new System.Drawing.Point(180, 490);
            this.btnAssignMaster.Size = new System.Drawing.Size(160, 40);
            this.btnAssignMaster.Text = "Назначить";
            this.btnAssignMaster.UseVisualStyleBackColor = false;
            this.btnAssignMaster.Click += new System.EventHandler(this.btnAssignMaster_Click);

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(750, 490);
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ManagerMainForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ManagerMainForm";
            this.Text = "Панель менеджера";

            this.tabControlMain.ResumeLayout(false);
            this.tabPageComplaints.ResumeLayout(false);
            this.tabPageEscalators.ResumeLayout(false);
            this.tabPageMasters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewComplaints).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewEscalators).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dataGridViewMasters).EndInit();
            this.ResumeLayout(false);
        }
    }
}
namespace ExcaMetr_Ver_0._0
{
    partial class MasterMainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEscalators;
        private System.Windows.Forms.TabPage tabPageTasks;
        private System.Windows.Forms.TabPage tabPageComplaint;
        private System.Windows.Forms.DataGridView dataGridViewEscalators;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnUpdateTaskStatus;
        private System.Windows.Forms.Button btnNewComplaint;
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
            tabControlMain = new TabControl();
            tabPageEscalators = new TabPage();
            dataGridViewEscalators = new DataGridView();
            tabPageTasks = new TabPage();
            dataGridViewTasks = new DataGridView();
            btnUpdateTaskStatus = new Button();
            tabPageComplaint = new TabPage();
            btnNewComplaint = new Button();
            btnLogout = new Button();
            Leave_button = new Button();
            tabControlMain.SuspendLayout();
            tabPageEscalators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscalators).BeginInit();
            tabPageTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            tabPageComplaint.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageEscalators);
            tabControlMain.Controls.Add(tabPageTasks);
            tabControlMain.Controls.Add(tabPageComplaint);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(900, 600);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageEscalators
            // 
            tabPageEscalators.BackColor = Color.FromArgb(45, 41, 38);
            tabPageEscalators.Controls.Add(Leave_button);
            tabPageEscalators.Controls.Add(dataGridViewEscalators);
            tabPageEscalators.Location = new Point(4, 24);
            tabPageEscalators.Name = "tabPageEscalators";
            tabPageEscalators.Size = new Size(892, 572);
            tabPageEscalators.TabIndex = 0;
            tabPageEscalators.Text = "\U0001f6d7 Мои эскалаторы";
            // 
            // dataGridViewEscalators
            // 
            dataGridViewEscalators.AllowUserToAddRows = false;
            dataGridViewEscalators.AllowUserToDeleteRows = false;
            dataGridViewEscalators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEscalators.BackgroundColor = Color.FromArgb(45, 41, 38);
            dataGridViewEscalators.Location = new Point(10, 10);
            dataGridViewEscalators.Name = "dataGridViewEscalators";
            dataGridViewEscalators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEscalators.Size = new Size(870, 466);
            dataGridViewEscalators.TabIndex = 0;
            // 
            // tabPageTasks
            // 
            tabPageTasks.BackColor = Color.FromArgb(45, 41, 38);
            tabPageTasks.Controls.Add(dataGridViewTasks);
            tabPageTasks.Controls.Add(btnUpdateTaskStatus);
            tabPageTasks.Location = new Point(4, 24);
            tabPageTasks.Name = "tabPageTasks";
            tabPageTasks.Size = new Size(892, 572);
            tabPageTasks.TabIndex = 1;
            tabPageTasks.Text = "Мои задания";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.BackgroundColor = Color.FromArgb(45, 41, 38);
            dataGridViewTasks.Location = new Point(10, 10);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(870, 470);
            dataGridViewTasks.TabIndex = 0;
            // 
            // btnUpdateTaskStatus
            // 
            btnUpdateTaskStatus.BackColor = Color.FromArgb(204, 119, 34);
            btnUpdateTaskStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateTaskStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateTaskStatus.ForeColor = Color.White;
            btnUpdateTaskStatus.Location = new Point(10, 490);
            btnUpdateTaskStatus.Name = "btnUpdateTaskStatus";
            btnUpdateTaskStatus.Size = new Size(200, 40);
            btnUpdateTaskStatus.TabIndex = 1;
            btnUpdateTaskStatus.Text = "Изменить статус задания";
            btnUpdateTaskStatus.UseVisualStyleBackColor = false;
            btnUpdateTaskStatus.Click += btnUpdateTaskStatus_Click;
            // 
            // tabPageComplaint
            // 
            tabPageComplaint.BackColor = Color.FromArgb(45, 41, 38);
            tabPageComplaint.Controls.Add(btnNewComplaint);
            tabPageComplaint.Location = new Point(4, 24);
            tabPageComplaint.Name = "tabPageComplaint";
            tabPageComplaint.Size = new Size(892, 572);
            tabPageComplaint.TabIndex = 2;
            tabPageComplaint.Text = "Написать жалобу";
            // 
            // btnNewComplaint
            // 
            btnNewComplaint.BackColor = Color.FromArgb(204, 119, 34);
            btnNewComplaint.FlatStyle = FlatStyle.Flat;
            btnNewComplaint.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewComplaint.ForeColor = Color.White;
            btnNewComplaint.Location = new Point(10, 10);
            btnNewComplaint.Name = "btnNewComplaint";
            btnNewComplaint.Size = new Size(200, 40);
            btnNewComplaint.TabIndex = 0;
            btnNewComplaint.Text = "Оставить жалобу";
            btnNewComplaint.UseVisualStyleBackColor = false;
            btnNewComplaint.Click += btnNewComplaint_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(80, 80, 80);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(750, 520);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 40);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Leave_button
            // 
            Leave_button.BackColor = Color.FromArgb(80, 80, 80);
            Leave_button.FlatStyle = FlatStyle.Flat;
            Leave_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Leave_button.ForeColor = Color.White;
            Leave_button.Location = new Point(746, 509);
            Leave_button.Name = "Leave_button";
            Leave_button.Size = new Size(120, 40);
            Leave_button.TabIndex = 4;
            Leave_button.Text = "Выйти";
            Leave_button.UseVisualStyleBackColor = false;
            Leave_button.Click += Leave_button_Click;
            // 
            // MasterMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(tabControlMain);
            Controls.Add(btnLogout);
            Name = "MasterMainForm";
            Text = "🔧 Панель мастера";
            tabControlMain.ResumeLayout(false);
            tabPageEscalators.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEscalators).EndInit();
            tabPageTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            tabPageComplaint.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button Leave_button;
    }
}
namespace ExcaMetr_Ver_0._0
{
    partial class ManagerAssignMasterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEscalator;
        private System.Windows.Forms.ComboBox cmbEscalator;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.ComboBox cmbMaster;
        private System.Windows.Forms.Button btnAssign;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEscalator = new System.Windows.Forms.Label();
            this.cmbEscalator = new System.Windows.Forms.ComboBox();
            this.lblMaster = new System.Windows.Forms.Label();
            this.cmbMaster = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Size = new System.Drawing.Size(280, 32);
            this.lblTitle.Text = "🔧 Назначение мастера";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblEscalator
            this.lblEscalator.AutoSize = true;
            this.lblEscalator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEscalator.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblEscalator.Location = new System.Drawing.Point(30, 80);
            this.lblEscalator.Text = "🛗 Выберите эскалатор:";

            // cmbEscalator
            this.cmbEscalator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscalator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEscalator.Location = new System.Drawing.Point(30, 110);
            this.cmbEscalator.Size = new System.Drawing.Size(370, 31);
            this.cmbEscalator.TabIndex = 0;

            // lblMaster
            this.lblMaster.AutoSize = true;
            this.lblMaster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaster.ForeColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.lblMaster.Location = new System.Drawing.Point(30, 160);
            this.lblMaster.Text = "👨‍🔧 Выберите мастера:";

            // cmbMaster
            this.cmbMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaster.Location = new System.Drawing.Point(30, 190);
            this.cmbMaster.Size = new System.Drawing.Size(370, 31);
            this.cmbMaster.TabIndex = 1;

            // btnAssign
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(204, 119, 34);
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(30, 250);
            this.btnAssign.Size = new System.Drawing.Size(180, 40);
            this.btnAssign.Text = "✅ Назначить";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(220, 250);
            this.btnCancel.Size = new System.Drawing.Size(180, 40);
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ManagerAssignMasterForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEscalator);
            this.Controls.Add(this.cmbEscalator);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.cmbMaster);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnCancel);
            this.Name = "ManagerAssignMasterForm";
            this.Text = "🔧 Назначение мастера на эскалатор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
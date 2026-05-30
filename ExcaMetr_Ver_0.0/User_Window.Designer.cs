namespace ExcaMetr_Ver_0._0
{
    partial class User_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ZAGOLOVOK_USER = new Panel();
            panel1 = new Panel();
            EXIT = new Label();
            Greetengs = new Label();
            ProsmotrJalob = new Label();
            JalobandZametok = new Label();
            Instruments = new Panel();
            EXIT_TO_REG = new Label();
            listBoxEscalators = new ListBox();
            ZAGOLOVOK_USER.SuspendLayout();
            Instruments.SuspendLayout();
            SuspendLayout();
            // 
            // ZAGOLOVOK_USER
            // 
            ZAGOLOVOK_USER.BackColor = Color.FromArgb(204, 119, 34);
            ZAGOLOVOK_USER.Controls.Add(panel1);
            ZAGOLOVOK_USER.Controls.Add(EXIT);
            ZAGOLOVOK_USER.Dock = DockStyle.Top;
            ZAGOLOVOK_USER.Location = new Point(0, 0);
            ZAGOLOVOK_USER.Name = "ZAGOLOVOK_USER";
            ZAGOLOVOK_USER.Size = new Size(666, 38);
            ZAGOLOVOK_USER.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(21, 408);
            panel1.TabIndex = 4;
            // 
            // EXIT
            // 
            EXIT.AutoSize = true;
            EXIT.Cursor = Cursors.Hand;
            EXIT.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EXIT.Location = new Point(651, 0);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(15, 15);
            EXIT.TabIndex = 3;
            EXIT.Text = "X";
            EXIT.Click += EXIT_Click;
            EXIT.MouseEnter += EXIT_MouseEnter;
            EXIT.MouseLeave += EXIT_MouseLeave;
            // 
            // Greetengs
            // 
            Greetengs.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Greetengs.ForeColor = Color.FromArgb(204, 119, 34);
            Greetengs.Location = new Point(0, 41);
            Greetengs.Name = "Greetengs";
            Greetengs.Size = new Size(666, 63);
            Greetengs.TabIndex = 1;
            Greetengs.Text = "Добро пожаловать (Тут имя пользователя)!";
            Greetengs.Click += Greetengs_Click;
            // 
            // ProsmotrJalob
            // 
            ProsmotrJalob.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            ProsmotrJalob.ForeColor = Color.FromArgb(204, 119, 34);
            ProsmotrJalob.Location = new Point(4, 439);
            ProsmotrJalob.Name = "ProsmotrJalob";
            ProsmotrJalob.Size = new Size(329, 36);
            ProsmotrJalob.TabIndex = 2;
            ProsmotrJalob.Text = "-Оставить жалобу/замечание";
            ProsmotrJalob.Click += ProsmotrJalob_Click;
            ProsmotrJalob.MouseEnter += ProsmotrJalob_MouseEnter;
            ProsmotrJalob.MouseLeave += ProsmotrJalob_MouseLeave;
            // 
            // JalobandZametok
            // 
            JalobandZametok.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            JalobandZametok.ForeColor = Color.FromArgb(204, 119, 34);
            JalobandZametok.Location = new Point(4, 475);
            JalobandZametok.Name = "JalobandZametok";
            JalobandZametok.Size = new Size(306, 36);
            JalobandZametok.TabIndex = 3;
            JalobandZametok.Text = "-Список жалоб и замечанй";
            JalobandZametok.Click += JalobandZametok_Click_1;
            JalobandZametok.MouseEnter += JalobandZametok_MouseEnter;
            JalobandZametok.MouseLeave += JalobandZametok_MouseLeave;
            // 
            // Instruments
            // 
            Instruments.BorderStyle = BorderStyle.FixedSingle;
            Instruments.Controls.Add(EXIT_TO_REG);
            Instruments.Location = new Point(1, 424);
            Instruments.Name = "Instruments";
            Instruments.Size = new Size(665, 144);
            Instruments.TabIndex = 4;
            // 
            // EXIT_TO_REG
            // 
            EXIT_TO_REG.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            EXIT_TO_REG.ForeColor = Color.FromArgb(204, 119, 34);
            EXIT_TO_REG.Location = new Point(2, 86);
            EXIT_TO_REG.Name = "EXIT_TO_REG";
            EXIT_TO_REG.Size = new Size(226, 36);
            EXIT_TO_REG.TabIndex = 5;
            EXIT_TO_REG.Text = "-Выход из аккаунта";
            EXIT_TO_REG.Click += EXIT_TO_REG_Click_1;
            EXIT_TO_REG.MouseEnter += EXIT_TO_REG_MouseEnter;
            EXIT_TO_REG.MouseLeave += EXIT_TO_REG_MouseLeave;
            // 
            // listBoxEscalators
            // 
            listBoxEscalators.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxEscalators.FormattingEnabled = true;
            listBoxEscalators.Location = new Point(0, 84);
            listBoxEscalators.Name = "listBoxEscalators";
            listBoxEscalators.Size = new Size(666, 334);
            listBoxEscalators.TabIndex = 5;
            // 
            // User_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 38);
            ClientSize = new Size(666, 568);
            Controls.Add(listBoxEscalators);
            Controls.Add(JalobandZametok);
            Controls.Add(ProsmotrJalob);
            Controls.Add(Greetengs);
            Controls.Add(ZAGOLOVOK_USER);
            Controls.Add(Instruments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Window";
            Load += User_Window_Load;
            MouseDown += User_Window_MouseDown;
            MouseMove += User_Window_MouseMove;
            ZAGOLOVOK_USER.ResumeLayout(false);
            ZAGOLOVOK_USER.PerformLayout();
            Instruments.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ZAGOLOVOK_USER;
        private Label EXIT;
        private Panel panel1;
        private Label Greetengs;
        private Label ProsmotrJalob;
        private Label JalobandZametok;
        private Panel Instruments;
        private Label EXIT_TO_REG;
        private ListBox listBoxEscalators;
    }
}
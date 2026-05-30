namespace ExcaMetr_Ver_0._0
{
    partial class WrongData
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
            Zagolovok = new Panel();
            EXIT_ERROR = new Label();
            Error = new Label();
            Answer_Of_Problem = new Label();
            Answer_Of_Registration = new Label();
            Zagolovok.SuspendLayout();
            SuspendLayout();
            // 
            // Zagolovok
            // 
            Zagolovok.BackColor = Color.FromArgb(204, 119, 34);
            Zagolovok.BorderStyle = BorderStyle.FixedSingle;
            Zagolovok.Controls.Add(EXIT_ERROR);
            Zagolovok.Controls.Add(Error);
            Zagolovok.Dock = DockStyle.Top;
            Zagolovok.Location = new Point(0, 0);
            Zagolovok.Name = "Zagolovok";
            Zagolovok.Size = new Size(368, 48);
            Zagolovok.TabIndex = 0;
            // 
            // EXIT_ERROR
            // 
            EXIT_ERROR.Cursor = Cursors.Hand;
            EXIT_ERROR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EXIT_ERROR.Location = new Point(352, 0);
            EXIT_ERROR.Name = "EXIT_ERROR";
            EXIT_ERROR.Size = new Size(16, 20);
            EXIT_ERROR.TabIndex = 4;
            EXIT_ERROR.Text = "X";
            EXIT_ERROR.Click += label1_Click;
            EXIT_ERROR.MouseEnter += EXIT_ERROR_MouseEnter;
            EXIT_ERROR.MouseLeave += EXIT_ERROR_MouseLeave;
            // 
            // Error
            // 
            Error.Dock = DockStyle.Top;
            Error.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Error.Location = new Point(0, 0);
            Error.Name = "Error";
            Error.Size = new Size(366, 45);
            Error.TabIndex = 0;
            Error.Text = "ERROR: HTTP 404 (Not Found)";
            Error.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Answer_Of_Problem
            // 
            Answer_Of_Problem.AllowDrop = true;
            Answer_Of_Problem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Answer_Of_Problem.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Answer_Of_Problem.Location = new Point(12, 63);
            Answer_Of_Problem.Name = "Answer_Of_Problem";
            Answer_Of_Problem.Size = new Size(326, 45);
            Answer_Of_Problem.TabIndex = 1;
            Answer_Of_Problem.Text = "Похоже, ваши данные некоректные, или их нету в базе данных.";
            Answer_Of_Problem.Click += Answer_Of_Problem_Click;
            // 
            // Answer_Of_Registration
            // 
            Answer_Of_Registration.AllowDrop = true;
            Answer_Of_Registration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Answer_Of_Registration.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Answer_Of_Registration.ForeColor = Color.Black;
            Answer_Of_Registration.Location = new Point(12, 126);
            Answer_Of_Registration.Name = "Answer_Of_Registration";
            Answer_Of_Registration.Size = new Size(367, 78);
            Answer_Of_Registration.TabIndex = 2;
            Answer_Of_Registration.Text = "Убедитесь в правильности написания вашего логина и пароля, или зарегистрируйтесь как пользователь";
            // 
            // WrongData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(368, 240);
            Controls.Add(Answer_Of_Registration);
            Controls.Add(Answer_Of_Problem);
            Controls.Add(Zagolovok);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WrongData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WrongData";
            Load += WrongData_Load;
            Zagolovok.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Zagolovok;
        private Label Error;
        private Label Answer_Of_Problem;
        private Label Answer_Of_Registration;
        private Label EXIT_ERROR;
    }
}
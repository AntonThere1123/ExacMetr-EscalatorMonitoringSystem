namespace ExcaMetr_Ver_0._0
{
    partial class Registration
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
            panel1 = new Panel();
            EXIT_Registration = new Label();
            RegistrationText = new Label();
            Enter_Button = new Button();
            PassField = new TextBox();
            LoginField = new TextBox();
            NameField = new TextBox();
            EmailField = new TextBox();
            LastName = new TextBox();
            PhoneNum = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 119, 34);
            panel1.Controls.Add(EXIT_Registration);
            panel1.Controls.Add(RegistrationText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 69);
            panel1.TabIndex = 1;
            // 
            // EXIT_Registration
            // 
            EXIT_Registration.AutoSize = true;
            EXIT_Registration.Cursor = Cursors.Hand;
            EXIT_Registration.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EXIT_Registration.Location = new Point(744, 0);
            EXIT_Registration.Name = "EXIT_Registration";
            EXIT_Registration.Size = new Size(15, 15);
            EXIT_Registration.TabIndex = 2;
            EXIT_Registration.Text = "X";
            EXIT_Registration.Click += EXIT_Registration_Click;
            EXIT_Registration.MouseEnter += EXIT_Registration_MouseEnter;
            EXIT_Registration.MouseLeave += EXIT_Registration_MouseLeave;
            // 
            // RegistrationText
            // 
            RegistrationText.Dock = DockStyle.Top;
            RegistrationText.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrationText.ImageAlign = ContentAlignment.TopCenter;
            RegistrationText.Location = new Point(0, 0);
            RegistrationText.Name = "RegistrationText";
            RegistrationText.Size = new Size(759, 55);
            RegistrationText.TabIndex = 1;
            RegistrationText.Text = "Регистрация";
            RegistrationText.TextAlign = ContentAlignment.TopCenter;
            RegistrationText.Click += AutomithationText_Click;
            // 
            // Enter_Button
            // 
            Enter_Button.Cursor = Cursors.Hand;
            Enter_Button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Enter_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Enter_Button.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Enter_Button.Location = new Point(63, 288);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(248, 60);
            Enter_Button.TabIndex = 11;
            Enter_Button.Text = "Зарегистрироваться";
            Enter_Button.UseVisualStyleBackColor = true;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassField.Location = new Point(29, 204);
            PassField.Name = "PassField";
            PassField.Size = new Size(337, 50);
            PassField.TabIndex = 9;
            PassField.Enter += PassField_Enter;
            PassField.Leave += PassField_Leave;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(29, 119);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(337, 50);
            LoginField.TabIndex = 7;
            LoginField.TextChanged += LoginField_TextChanged;
            LoginField.Enter += LoginField_Enter;
            LoginField.Leave += LoginField_Leave;
            // 
            // NameField
            // 
            NameField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameField.Location = new Point(403, 119);
            NameField.Name = "NameField";
            NameField.Size = new Size(331, 50);
            NameField.TabIndex = 12;
            NameField.TextChanged += textBox2_TextChanged;
            NameField.Enter += NameField_Enter;
            NameField.Leave += NameField_Leave;
            // 
            // EmailField
            // 
            EmailField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmailField.Location = new Point(403, 288);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(331, 50);
            EmailField.TabIndex = 14;
            EmailField.Enter += EmailField_Enter;
            EmailField.Leave += EmailField_Leave;
            // 
            // LastName
            // 
            LastName.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastName.Location = new Point(403, 204);
            LastName.Name = "LastName";
            LastName.Size = new Size(331, 50);
            LastName.TabIndex = 15;
            LastName.Enter += LastName_Enter;
            LastName.Leave += LastName_Leave;
            // 
            // PhoneNum
            // 
            PhoneNum.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneNum.Location = new Point(403, 375);
            PhoneNum.Name = "PhoneNum";
            PhoneNum.Size = new Size(331, 50);
            PhoneNum.TabIndex = 16;
            PhoneNum.Enter += PhoneNum_Enter;
            PhoneNum.Leave += PhoneNum_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(121, 392);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 17;
            label1.Text = "Выполнить вход";
            label1.Click += label1_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 38);
            ClientSize = new Size(759, 450);
            Controls.Add(label1);
            Controls.Add(PhoneNum);
            Controls.Add(LastName);
            Controls.Add(EmailField);
            Controls.Add(NameField);
            Controls.Add(Enter_Button);
            Controls.Add(PassField);
            Controls.Add(LoginField);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            MouseDown += Registration_MouseDown;
            MouseMove += Registration_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label EXIT_Registration;
        private Label RegistrationText;
        private Button Enter_Button;
        private TextBox PassField;
        private TextBox LoginField;
        private TextBox NameField;
        private TextBox PhoneNumberField;
        private TextBox LastNameField;
        private TextBox EmailField;
        private TextBox LastName;
        private TextBox PhoneNum;
        private Label label1;
    }
}
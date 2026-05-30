namespace ExcaMetr_Ver_0._0
{
    partial class AutoEnter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoEnter));
            panel1 = new Panel();
            EXIT = new Label();
            AutomithationText = new Label();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            PassField = new TextBox();
            Registration_As_User = new Label();
            Enter_Button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 119, 34);
            panel1.Controls.Add(EXIT);
            panel1.Controls.Add(AutomithationText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 69);
            panel1.TabIndex = 0;
            // 
            // EXIT
            // 
            EXIT.AutoSize = true;
            EXIT.Cursor = Cursors.Hand;
            EXIT.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EXIT.Location = new Point(406, 0);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(15, 15);
            EXIT.TabIndex = 2;
            EXIT.Text = "X";
            EXIT.Click += EXIT_Click;
            EXIT.MouseEnter += EXIT_MouseEnter;
            EXIT.MouseLeave += EXIT_MouseLeave;
            // 
            // AutomithationText
            // 
            AutomithationText.Anchor = AnchorStyles.Top;
            AutomithationText.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AutomithationText.Location = new Point(61, 0);
            AutomithationText.Name = "AutomithationText";
            AutomithationText.Size = new Size(310, 55);
            AutomithationText.TabIndex = 1;
            AutomithationText.Text = "Авторизация";
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(84, 179);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(314, 50);
            LoginField.TabIndex = 1;
            LoginField.Enter += LoginField_Enter;
            LoginField.Leave += LoginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassField.Location = new Point(84, 264);
            PassField.Name = "PassField";
            PassField.Size = new Size(314, 50);
            PassField.TabIndex = 3;
            PassField.UseSystemPasswordChar = true;
            PassField.Enter += PassField_Enter;
            PassField.Leave += PassField_Leave;
            // 
            // Registration_As_User
            // 
            Registration_As_User.AutoSize = true;
            Registration_As_User.Cursor = Cursors.Hand;
            Registration_As_User.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Registration_As_User.ForeColor = Color.DarkOrange;
            Registration_As_User.Location = new Point(26, 427);
            Registration_As_User.Name = "Registration_As_User";
            Registration_As_User.Size = new Size(372, 24);
            Registration_As_User.TabIndex = 5;
            Registration_As_User.Text = "Зарегистрироваться как пользователь";
            Registration_As_User.Click += Registration_As_User_Click;
            // 
            // Enter_Button
            // 
            Enter_Button.Cursor = Cursors.Hand;
            Enter_Button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Enter_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Enter_Button.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Enter_Button.Location = new Point(116, 348);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(205, 57);
            Enter_Button.TabIndex = 6;
            Enter_Button.Text = "ВХОД";
            Enter_Button.UseVisualStyleBackColor = true;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // AutoEnter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 38);
            ClientSize = new Size(420, 619);
            Controls.Add(Enter_Button);
            Controls.Add(Registration_As_User);
            Controls.Add(pictureBox2);
            Controls.Add(PassField);
            Controls.Add(pictureBox1);
            Controls.Add(LoginField);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AutoEnter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label AutomithationText;
        private TextBox LoginField;
        private Label EXIT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox PassField;
        private Label Registration_As_User;
        private Button Enter_Button;
    }
}

namespace WinformsLogin
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel3 = new Panel();
            buttonRegister = new Button();
            passwordFiels = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            Авторизация = new Label();
            panel1 = new Panel();
            CloseAppButton = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(buttonRegister);
            panel3.Controls.Add(passwordFiels);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(loginField);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 419);
            panel3.TabIndex = 6;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.Lime;
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister.Location = new Point(117, 248);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(200, 56);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "РЕГИСТРАЦИЯ";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passwordFiels
            // 
            passwordFiels.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordFiels.Location = new Point(117, 125);
            passwordFiels.Multiline = true;
            passwordFiels.Name = "passwordFiels";
            passwordFiels.PasswordChar = '"';
            passwordFiels.Size = new Size(234, 67);
            passwordFiels.TabIndex = 3;
            passwordFiels.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginField.Location = new Point(117, 42);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(234, 67);
            loginField.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Авторизация
            // 
            Авторизация.Dock = DockStyle.Fill;
            Авторизация.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Авторизация.ForeColor = SystemColors.MenuText;
            Авторизация.Location = new Point(0, 31);
            Авторизация.Name = "Авторизация";
            Авторизация.Size = new Size(405, 419);
            Авторизация.TabIndex = 4;
            Авторизация.Text = "Авторизация";
            Авторизация.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(CloseAppButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 31);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // CloseAppButton
            // 
            CloseAppButton.AutoSize = true;
            CloseAppButton.Cursor = Cursors.Hand;
            CloseAppButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseAppButton.Location = new Point(383, 7);
            CloseAppButton.Name = "CloseAppButton";
            CloseAppButton.Size = new Size(20, 21);
            CloseAppButton.TabIndex = 0;
            CloseAppButton.Text = "X";
            CloseAppButton.TextAlign = ContentAlignment.TopRight;
            CloseAppButton.Click += CloseAppButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(panel3);
            Controls.Add(Авторизация);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button buttonRegister;
        private TextBox passwordFiels;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Label Авторизация;
        private Panel panel1;
        private Label CloseAppButton;
    }
}
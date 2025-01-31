namespace WinformsLogin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            CloseAppButton = new Label();
            panel2 = new Panel();
            Авторизация = new Label();
            panel3 = new Panel();
            button1 = new Button();
            passwordFiels = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(CloseAppButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 31);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
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
            CloseAppButton.MouseEnter += CloseAppButton_MouseEnter;
            CloseAppButton.MouseLeave += CloseAppButton_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(Авторизация);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 100);
            panel2.TabIndex = 2;
            // 
            // Авторизация
            // 
            Авторизация.Dock = DockStyle.Fill;
            Авторизация.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Авторизация.ForeColor = SystemColors.MenuText;
            Авторизация.Location = new Point(0, 0);
            Авторизация.Name = "Авторизация";
            Авторизация.Size = new Size(406, 100);
            Авторизация.TabIndex = 0;
            Авторизация.Text = "Авторизация";
            Авторизация.TextAlign = ContentAlignment.MiddleCenter;
            Авторизация.Click += Авторизация_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(passwordFiels);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(loginField);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 338);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(117, 239);
            button1.Name = "button1";
            button1.Size = new Size(191, 56);
            button1.TabIndex = 4;
            button1.Text = "ВОЙТИ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            passwordFiels.TextChanged += textBox2_TextChanged;
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
            loginField.TextChanged += loginField_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 469);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Авторизация;
        private Panel panel3;
        private Label CloseAppButton;
        private PictureBox pictureBox1;
        private TextBox passwordFiels;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button button1;
    }
}

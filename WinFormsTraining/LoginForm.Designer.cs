namespace WinFormsTraining
{
    partial class LoginForm
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
            button1 = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 6, 23);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 481);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 144, 14);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 47, 3);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 122, 12);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(75, 387);
            button1.Name = "button1";
            button1.Size = new Size(175, 64);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(75, 257);
            passField.Name = "passField";
            passField.Size = new Size(401, 48);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(12, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(75, 170);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(401, 64);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(12, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 7, 77);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 100);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BorderStyle = BorderStyle.FixedSingle;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(469, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(27, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(247, 247, 249);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(496, 100);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 481);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button button1;
    }
}
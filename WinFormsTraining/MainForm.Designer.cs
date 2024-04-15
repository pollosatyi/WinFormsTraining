namespace WinFormsTraining
{
    partial class MainForm
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
            mainLabel1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            closeButton = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainLabel1
            // 
            mainLabel1.Dock = DockStyle.Fill;
            mainLabel1.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            mainLabel1.ForeColor = Color.FromArgb(247, 247, 249);
            mainLabel1.Location = new Point(0, 0);
            mainLabel1.Name = "mainLabel1";
            mainLabel1.Size = new Size(800, 100);
            mainLabel1.TabIndex = 0;
            mainLabel1.Text = "Главный экран";
            mainLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 6, 23);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 7, 77);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(mainLabel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BorderStyle = BorderStyle.FixedSingle;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(773, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(27, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label mainLabel1;
        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
    }
}
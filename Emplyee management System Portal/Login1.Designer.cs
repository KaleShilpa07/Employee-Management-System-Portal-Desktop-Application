namespace Emplyee_management_System_Portal
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            ResetBTN = new Button();
            LoginBTN = new Button();
            label3 = new Label();
            label2 = new Label();
            UseNameTB = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            PasswordTB = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ResetBTN
            // 
            ResetBTN.BackColor = Color.Teal;
            ResetBTN.FlatAppearance.BorderColor = Color.Black;
            ResetBTN.FlatAppearance.MouseDownBackColor = Color.Gray;
            ResetBTN.FlatAppearance.MouseOverBackColor = Color.Pink;
            ResetBTN.FlatStyle = FlatStyle.Flat;
            ResetBTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ResetBTN.ForeColor = Color.White;
            ResetBTN.Location = new Point(741, 363);
            ResetBTN.Name = "ResetBTN";
            ResetBTN.Size = new Size(110, 34);
            ResetBTN.TabIndex = 17;
            ResetBTN.Text = "RESET";
            ResetBTN.UseVisualStyleBackColor = false;
            ResetBTN.Click += ResetBTN_Click;
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = Color.Teal;
            LoginBTN.FlatAppearance.BorderColor = Color.Black;
            LoginBTN.FlatAppearance.MouseDownBackColor = Color.Gray;
            LoginBTN.FlatAppearance.MouseOverBackColor = Color.Pink;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.ForeColor = Color.White;
            LoginBTN.Location = new Point(592, 363);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(112, 34);
            LoginBTN.TabIndex = 16;
            LoginBTN.Text = "LOGIN";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(584, 264);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(584, 183);
            label2.Name = "label2";
            label2.Size = new Size(135, 29);
            label2.TabIndex = 14;
            label2.Text = "User Name";
            // 
            // UseNameTB
            // 
            UseNameTB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UseNameTB.ForeColor = SystemColors.InactiveCaptionText;
            UseNameTB.Location = new Point(584, 215);
            UseNameTB.Name = "UseNameTB";
            UseNameTB.Size = new Size(279, 35);
            UseNameTB.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(659, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(657, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 10;
            label1.Text = "Login User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 576);
            panel1.TabIndex = 9;
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.ForeColor = SystemColors.InactiveCaptionText;
            PasswordTB.Location = new Point(584, 296);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(279, 35);
            PasswordTB.TabIndex = 12;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(394, 29);
            label4.TabIndex = 0;
            label4.Text = "Emplyee Managment System Portal";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 279);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 418);
            label5.Name = "label5";
            label5.Size = new Size(88, 29);
            label5.TabIndex = 13;
            label5.Text = "C# .net";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(136, 461);
            label6.Name = "label6";
            label6.Size = new Size(138, 29);
            label6.TabIndex = 14;
            label6.Text = "SQL Server";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 547);
            label7.Name = "label7";
            label7.Size = new Size(225, 29);
            label7.TabIndex = 18;
            label7.Text = "..CopyRight@2023..";
            // 
            // Login1
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1077, 576);
            Controls.Add(ResetBTN);
            Controls.Add(LoginBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UseNameTB);
            Controls.Add(PasswordTB);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Login1";
            Text = "Login1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetBTN;
        private Button LoginBTN;
        private Label label3;
        private Label label2;
        private TextBox UseNameTB;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox PasswordTB;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
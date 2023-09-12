namespace Emplyee_management_System_Portal
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            UpdateBTN = new Button();
            AddBTN = new Button();
            periodDatetimepicker = new DateTimePicker();
            panel2 = new Panel();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SalaryAmountTB = new TextBox();
            panel1 = new Panel();
            EmpCB = new ComboBox();
            DayAttendTB = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            SalaryLBL = new Label();
            DeptLBL = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            EmpLBL = new Label();
            pictureBox6 = new PictureBox();
            LogoutLBL = new Label();
            DeleteBTN = new Button();
            SalaryList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // UpdateBTN
            // 
            UpdateBTN.BackColor = Color.Teal;
            UpdateBTN.FlatAppearance.BorderColor = Color.Black;
            UpdateBTN.FlatAppearance.MouseDownBackColor = Color.Gray;
            UpdateBTN.FlatAppearance.MouseOverBackColor = Color.Pink;
            UpdateBTN.FlatStyle = FlatStyle.Flat;
            UpdateBTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBTN.ForeColor = Color.White;
            UpdateBTN.Location = new Point(186, 681);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(139, 34);
            UpdateBTN.TabIndex = 47;
            UpdateBTN.Text = "UPDATE";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Teal;
            AddBTN.FlatAppearance.BorderColor = Color.Black;
            AddBTN.FlatAppearance.MouseDownBackColor = Color.Gray;
            AddBTN.FlatAppearance.MouseOverBackColor = Color.Pink;
            AddBTN.FlatStyle = FlatStyle.Flat;
            AddBTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBTN.ForeColor = Color.White;
            AddBTN.Location = new Point(51, 681);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(129, 34);
            AddBTN.TabIndex = 46;
            AddBTN.Text = "ADD";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // periodDatetimepicker
            // 
            periodDatetimepicker.Location = new Point(46, 368);
            periodDatetimepicker.Name = "periodDatetimepicker";
            periodDatetimepicker.Size = new Size(279, 35);
            periodDatetimepicker.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 815);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 15);
            panel2.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(45, 336);
            label9.Name = "label9";
            label9.Size = new Size(97, 29);
            label9.TabIndex = 38;
            label9.Text = "Periods";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(45, 440);
            label7.Name = "label7";
            label7.Size = new Size(173, 29);
            label7.TabIndex = 36;
            label7.Text = " Salary Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(46, 246);
            label5.Name = "label5";
            label5.Size = new Size(156, 29);
            label5.TabIndex = 34;
            label5.Text = "Day Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(46, 162);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 32;
            label3.Text = "Employees";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(583, 150);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 30;
            label2.Text = "Manage Salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 21);
            label1.Name = "label1";
            label1.Size = new Size(497, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Management Portal System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalaryAmountTB
            // 
            SalaryAmountTB.BackColor = Color.White;
            SalaryAmountTB.Enabled = false;
            SalaryAmountTB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryAmountTB.ForeColor = SystemColors.ActiveCaptionText;
            SalaryAmountTB.Location = new Point(45, 472);
            SalaryAmountTB.Name = "SalaryAmountTB";
            SalaryAmountTB.Size = new Size(279, 35);
            SalaryAmountTB.TabIndex = 35;
            SalaryAmountTB.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 77);
            panel1.TabIndex = 29;
            // 
            // EmpCB
            // 
            EmpCB.FormattingEnabled = true;
            EmpCB.Items.AddRange(new object[] { "Male", "Female" });
            EmpCB.Location = new Point(46, 194);
            EmpCB.Name = "EmpCB";
            EmpCB.Size = new Size(279, 37);
            EmpCB.TabIndex = 48;
            EmpCB.SelectionChangeCommitted += EmpCB_SelectionChangeCommitted;
            // 
            // DayAttendTB
            // 
            DayAttendTB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DayAttendTB.Location = new Point(46, 278);
            DayAttendTB.Name = "DayAttendTB";
            DayAttendTB.Size = new Size(279, 35);
            DayAttendTB.TabIndex = 49;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(74, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(767, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // SalaryLBL
            // 
            SalaryLBL.AutoSize = true;
            SalaryLBL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryLBL.ForeColor = Color.Teal;
            SalaryLBL.Location = new Point(841, 92);
            SalaryLBL.Name = "SalaryLBL";
            SalaryLBL.Size = new Size(80, 29);
            SalaryLBL.TabIndex = 63;
            SalaryLBL.Text = "Salary";
            SalaryLBL.Click += label6_Click;
            // 
            // DeptLBL
            // 
            DeptLBL.AutoSize = true;
            DeptLBL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLBL.ForeColor = Color.Teal;
            DeptLBL.Location = new Point(617, 92);
            DeptLBL.Name = "DeptLBL";
            DeptLBL.Size = new Size(144, 29);
            DeptLBL.TabIndex = 62;
            DeptLBL.Text = "Department ";
            DeptLBL.Click += DeptLBL_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(543, 87);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(323, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // EmpLBL
            // 
            EmpLBL.AutoSize = true;
            EmpLBL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpLBL.ForeColor = Color.Teal;
            EmpLBL.Location = new Point(410, 92);
            EmpLBL.Name = "EmpLBL";
            EmpLBL.Size = new Size(122, 29);
            EmpLBL.TabIndex = 58;
            EmpLBL.Text = "Employee";
            EmpLBL.Click += EmpLBL_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(917, 87);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
            // 
            // LogoutLBL
            // 
            LogoutLBL.AutoSize = true;
            LogoutLBL.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLBL.ForeColor = Color.Teal;
            LogoutLBL.Location = new Point(991, 92);
            LogoutLBL.Name = "LogoutLBL";
            LogoutLBL.Size = new Size(87, 29);
            LogoutLBL.TabIndex = 66;
            LogoutLBL.Text = "Logout";
            LogoutLBL.Click += LogoutLBL_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.BackColor = Color.Red;
            DeleteBTN.FlatAppearance.BorderColor = Color.Black;
            DeleteBTN.FlatAppearance.MouseDownBackColor = Color.Gray;
            DeleteBTN.FlatAppearance.MouseOverBackColor = Color.Pink;
            DeleteBTN.FlatStyle = FlatStyle.Flat;
            DeleteBTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBTN.ForeColor = Color.White;
            DeleteBTN.Location = new Point(113, 721);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(139, 48);
            DeleteBTN.TabIndex = 85;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = false;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // SalaryList
            // 
            SalaryList.BackgroundColor = Color.White;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryList.GridColor = Color.LightGray;
            SalaryList.Location = new Point(353, 194);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            SalaryList.RowTemplate.Height = 33;
            SalaryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryList.Size = new Size(742, 477);
            SalaryList.TabIndex = 86;
            SalaryList.CellContentClick += SalaryList_CellContentClick_1;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 830);
            Controls.Add(SalaryList);
            Controls.Add(DeleteBTN);
            Controls.Add(LogoutLBL);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(SalaryLBL);
            Controls.Add(DeptLBL);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(EmpLBL);
            Controls.Add(pictureBox4);
            Controls.Add(DayAttendTB);
            Controls.Add(EmpCB);
            Controls.Add(UpdateBTN);
            Controls.Add(AddBTN);
            Controls.Add(periodDatetimepicker);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SalaryAmountTB);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBTN;
        private Button AddBTN;
        private DateTimePicker periodDatetimepicker;
        private Panel panel2;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox SalaryAmountTB;
        private Panel panel1;
        private ComboBox EmpCB;
        private TextBox DayAttendTB;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label SalaryLBL;
        private Label DeptLBL;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label EmpLBL;
        private PictureBox pictureBox6;
        private Label LogoutLBL;
        private Button DeleteBTN;
        private DataGridView SalaryList;
    }
}
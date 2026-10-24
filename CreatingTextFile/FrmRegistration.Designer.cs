namespace CreatingTextFile
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtStuNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            btnRecords = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(18, 80);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(22, 108);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(62, 136);
            label3.Name = "label3";
            label3.Size = new Size(32, 16);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(38, 166);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 3;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(326, 82);
            label5.Name = "label5";
            label5.Size = new Size(59, 16);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(313, 110);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 5;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(333, 136);
            label7.Name = "label7";
            label7.Size = new Size(52, 16);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F);
            label8.Location = new Point(309, 164);
            label8.Name = "label8";
            label8.Size = new Size(76, 16);
            label8.TabIndex = 7;
            label8.Text = "Contact No.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F);
            label9.Location = new Point(597, 110);
            label9.Name = "label9";
            label9.Size = new Size(24, 16);
            label9.TabIndex = 8;
            label9.Text = "M.I";
            // 
            // txtStuNo
            // 
            txtStuNo.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtStuNo.Location = new Point(100, 77);
            txtStuNo.Name = "txtStuNo";
            txtStuNo.Size = new Size(200, 22);
            txtStuNo.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtLastName.Location = new Point(100, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 22);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtFirstName.Location = new Point(391, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 22);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtMiddleName.Location = new Point(627, 105);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(56, 22);
            txtMiddleName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAge.Location = new Point(100, 133);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(97, 22);
            txtAge.TabIndex = 13;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Microsoft Sans Serif", 10F);
            txtContactNo.Location = new Point(391, 159);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(200, 23);
            txtContactNo.TabIndex = 14;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelors of Science in Information Technology", "Bachelors of Science in Computer Science", "Bachelors of Science in Compuer Engineering" });
            cbProgram.Location = new Point(391, 75);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(200, 24);
            cbProgram.TabIndex = 15;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(391, 131);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 24);
            cbGender.TabIndex = 16;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(100, 161);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 17;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(586, 200);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 35);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.SandyBrown;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(483, 200);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(97, 35);
            btnRecords.TabIndex = 21;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkOrange;
            label10.Location = new Point(12, 24);
            label10.Name = "label10";
            label10.Size = new Size(175, 37);
            label10.TabIndex = 22;
            label10.Text = "Registration";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(721, 257);
            Controls.Add(label10);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStuNo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtStuNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Button btnRecords;
        private Label label10;
    }
}
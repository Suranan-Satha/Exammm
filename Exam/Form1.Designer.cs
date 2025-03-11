namespace Exam
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Major = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_id = new TextBox();
            tb_name = new TextBox();
            tb_department = new TextBox();
            tb_grade = new TextBox();
            btn_addStd = new Button();
            btn_showstd = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lb_id = new Label();
            lb_name = new Label();
            lb_major = new Label();
            lb_grade = new Label();
            lb_advisor = new Label();
            cmbAdvisor = new ComboBox();
            groupBox1 = new GroupBox();
            lst_Students = new ListBox();
            btn_showAdvisorStudents = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(72, 119);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 2;
            Major.Text = "Major";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 167);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 216);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Advisor";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(126, 23);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(195, 27);
            tb_id.TabIndex = 5;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(126, 74);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(195, 27);
            tb_name.TabIndex = 6;
            // 
            // tb_department
            // 
            tb_department.Location = new Point(126, 119);
            tb_department.Name = "tb_department";
            tb_department.Size = new Size(195, 27);
            tb_department.TabIndex = 7;
            // 
            // tb_grade
            // 
            tb_grade.Location = new Point(126, 167);
            tb_grade.Name = "tb_grade";
            tb_grade.Size = new Size(195, 27);
            tb_grade.TabIndex = 8;
            // 
            // btn_addStd
            // 
            btn_addStd.Location = new Point(61, 264);
            btn_addStd.Name = "btn_addStd";
            btn_addStd.Size = new Size(260, 29);
            btn_addStd.TabIndex = 10;
            btn_addStd.Text = "AddStd";
            btn_addStd.UseVisualStyleBackColor = true;
            btn_addStd.Click += btn_addStd_Click;
            // 
            // btn_showstd
            // 
            btn_showstd.Location = new Point(375, 242);
            btn_showstd.Name = "btn_showstd";
            btn_showstd.Size = new Size(313, 57);
            btn_showstd.TabIndex = 11;
            btn_showstd.Text = "ShowStd";
            btn_showstd.UseVisualStyleBackColor = true;
            btn_showstd.Click += btn_showstd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 13;
            label3.Text = "ข้อมูลนักศึกษา";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 23);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 14;
            label6.Text = "รหัสนักศึกษา";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 55);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 15;
            label7.Text = "ชื่อ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 89);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 16;
            label8.Text = "สาขาที่เรียน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 125);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 17;
            label9.Text = "เกรด";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 160);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 18;
            label10.Text = "อาจารย์ที่ปรึกษา";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(215, 23);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(58, 20);
            lb_id.TabIndex = 19;
            lb_id.Text = "label11";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(215, 55);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(58, 20);
            lb_name.TabIndex = 20;
            lb_name.Text = "label12";
            // 
            // lb_major
            // 
            lb_major.AutoSize = true;
            lb_major.Location = new Point(215, 89);
            lb_major.Name = "lb_major";
            lb_major.Size = new Size(58, 20);
            lb_major.TabIndex = 21;
            lb_major.Text = "label13";
            // 
            // lb_grade
            // 
            lb_grade.AutoSize = true;
            lb_grade.Location = new Point(215, 125);
            lb_grade.Name = "lb_grade";
            lb_grade.Size = new Size(58, 20);
            lb_grade.TabIndex = 22;
            lb_grade.Text = "label14";
            // 
            // lb_advisor
            // 
            lb_advisor.AutoSize = true;
            lb_advisor.Location = new Point(215, 160);
            lb_advisor.Name = "lb_advisor";
            lb_advisor.Size = new Size(58, 20);
            lb_advisor.TabIndex = 23;
            lb_advisor.Text = "label15";
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(126, 213);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(195, 28);
            cmbAdvisor.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lb_advisor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lb_grade);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lb_major);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lb_name);
            groupBox1.Controls.Add(lb_id);
            groupBox1.Location = new Point(375, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 199);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // lst_Students
            // 
            lst_Students.FormattingEnabled = true;
            lst_Students.Location = new Point(61, 306);
            lst_Students.Name = "lst_Students";
            lst_Students.Size = new Size(260, 324);
            lst_Students.TabIndex = 27;
            lst_Students.SelectedIndexChanged += lst_Students_SelectedIndexChanged;
            // 
            // btn_showAdvisorStudents
            // 
            btn_showAdvisorStudents.Location = new Point(375, 306);
            btn_showAdvisorStudents.Name = "btn_showAdvisorStudents";
            btn_showAdvisorStudents.Size = new Size(313, 324);
            btn_showAdvisorStudents.TabIndex = 28;
            btn_showAdvisorStudents.Text = "showAdvisorStudents";
            btn_showAdvisorStudents.UseVisualStyleBackColor = true;
            btn_showAdvisorStudents.Click += btn_showAdvisorStudents_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 696);
            Controls.Add(btn_showAdvisorStudents);
            Controls.Add(lst_Students);
            Controls.Add(groupBox1);
            Controls.Add(cmbAdvisor);
            Controls.Add(label3);
            Controls.Add(btn_showstd);
            Controls.Add(btn_addStd);
            Controls.Add(tb_grade);
            Controls.Add(tb_department);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Major);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Major;
        private Label label4;
        private Label label5;
        private TextBox tb_id;
        private TextBox tb_name;
        private TextBox tb_department;
        private TextBox tb_grade;
        private Button btn_addStd;
        private Button btn_showstd;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lb_id;
        private Label lb_name;
        private Label lb_major;
        private Label lb_grade;
        private Label lb_advisor;
        private ComboBox cmbAdvisor;
        private GroupBox groupBox1;
        private ListBox lst_Students;
        private Button btn_showAdvisorStudents;
    }
}

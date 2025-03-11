using System.Xml.Linq;

namespace Exam
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();


        public Form1()
        {
            InitializeComponent();
            LoadAdvisors();
            UpdateStudentList();
        }
        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("Dr.Pyothorn", "Computer Science"));
            advisors.Add(new Advisor("Dr.Wullapa", "Mathematics"));
            advisors.Add(new Advisor("Dr.Noppakun", "Computer Science"));
            advisors.Add(new Advisor("Dr.Patareeya", "Mathematics"));

            cmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addStd_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string major = tb_department.Text;
            double grade;

            if (!double.TryParse(tb_grade.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                return;
            }

            if (cmbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                return;
            }
            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lb_id.Text = student.ID;
            lb_name.Text = student.Name;
            lb_major.Text = student.Major;
            lb_grade.Text = student.Grade.ToString();
            lb_advisor.Text = student.Advisor.Name;

            UpdateStudentList();
            MessageBox.Show("เพิ่มข้อมูลนักศึกษาเรียบร้อยแล้ว!");
        }

        private void btn_showstd_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("ยังไม่มีนักศึกษาที่ถูกบันทึก");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุด: {topStudent.Name} (เกรด: {topStudent.Grade})");
        }

        private void UpdateStudentList()
        {
            lst_Students.Items.Clear();
            foreach (var student in students)
            {
                lst_Students.Items.Add(student.Name);
            }
        }

        private void lst_Students_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lst_Students.SelectedIndex != -1)
            {

                string selectedName = lst_Students.SelectedItem.ToString();


                Student student = students.FirstOrDefault(s => s.Name == selectedName);


                if (student != null)
                {
                    lb_id.Text = student.ID;
                    lb_name.Text = student.Name;
                    lb_major.Text = student.Major;
                    lb_grade.Text = student.Grade.ToString();
                    lb_advisor.Text = student.Advisor.Name;
                }
            }


        }

        private void btn_showAdvisorStudents_Click(object sender, EventArgs e)
        {
            if (cmbAdvisor.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                return;
            }

            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            MessageBox.Show($"นักศึกษาในที่ปรึกษาของ {advisor.Name}: {advisor.GetStudentList()}");
        }
    }
}


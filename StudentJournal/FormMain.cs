using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentJournal
{
    public partial class FormMain : Form
    {
        public List<Student> students;
        public Database DB;
        public FormMain()
        {
            InitializeComponent();
            students = new List<Student>();

            DB = new Database();
            DB.Connect();

            getStudents();
            getLearning();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                string sql = "INSERT INTO `students` (`fname`, `lname`, `pname`, `group`, `bday`, `phone`, `mail`) VALUES ('" + frm.fname + "', '" + frm.lname + "', '" + frm.pname + "', '" + frm.group + "', '" + frm.bday + "','" + frm.phone + "','" + frm.link + "')";
                DB.QR(sql);
            }
        }

        void getStudents()
        {
            List<string> tmpID = DB.GetQR("students", "id");
            List<string> tmpFName = DB.GetQR("students", "fname");
            List<string> tmpLName = DB.GetQR("students", "lname");
            List<string> tmpPName = DB.GetQR("students", "pname");
            List<string> tmpGroup = DB.GetQR("students", "group");
            List<string> tmpBDay = DB.GetQR("students", "bday");
            List<string> tmpPhone = DB.GetQR("students", "phone");
            List<string> tmpMail = DB.GetQR("students", "mail");

            for (int i = 0; i < tmpID.Count; i++)
            {
                Student tmpStudent = new Student();
                tmpStudent.id = Convert.ToInt32(tmpID[i]);
                tmpStudent.fio = tmpLName[i] + " " + tmpFName[i][0] + ". " + tmpPName[i][0] + ".";
                tmpStudent.group = tmpGroup[i];
                tmpStudent.bday = tmpBDay[i];
                tmpStudent.phone = tmpPhone[i];
                tmpStudent.mail = tmpMail[i];
                students.Add(tmpStudent);
            }

            gridStudents.Rows.Clear();
            for (int j = 0; j < students.Count; j++)
            {
                gridStudents.Rows.Add(students[j].fio);
            }
        }

        void getLearning()
        {
            gridLearning.Rows.Clear();
            gridLearning.Columns.Clear();
            for (int i = 1; i <= 31; i++)
            {
                gridLearning.Columns.Add("col_day", Convert.ToString(i));
            }

            for (int j = 0; j < gridLearning.Columns.Count; j++)
            {
                gridLearning.Columns[j].Width = 25;
            }

            for (int k = 0; k < students.Count; k++)
            {
                gridLearning.Rows.Add();
            }
        }
    }
}

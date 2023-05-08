using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiAndClasses
{
    public partial class frmCreateLesson : Form
    {
        private Lesson theLesson;
        private Courses allCourses = new Courses();
        
        public frmCreateLesson()
        {
            InitializeComponent();
        }

        private void btnCreateLesson_Click(object sender, EventArgs e)
        {
            theLesson = new Lesson(txtLessonName.Text, int.Parse(txtMaxStudents.Text));
           
            this.Text = "Lesson data";
            allCourses.AddLesson(theLesson);
            lstLessons.Items.Add(theLesson.GetSubject());

            grpLessons.Visible = true;
            grpCreateLesson.Visible = false;
            grpStudents.Visible = true;
            btnAddLesson.Visible = true;
            EnableStduentOperations(false);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Student Name can not be empty!");
                return;
            }

            Student newStudent = new Student(txtStudentName.Text);
            theLesson.AddStudent(newStudent);
            lstStudents.Items.Add(newStudent);
            txtStudentName.Text = "";

            if (theLesson.CanAddAnotherStudent() == false)
                grpAddStudent.Enabled = false;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            Student currentStudent = lstStudents.SelectedItem as Student;
            if (currentStudent == null)
            {
                MessageBox.Show("You must select a student first");
            }
            else
            {
                theLesson.RemoveStudent(currentStudent);
                UpdateStudentList();
                grpAddStudent.Enabled = true;
                EnableStduentOperations(false);
            }
        }

        private void UpdateStudentList()
        {
            lstStudents.Items.Clear();
            Student[] allStudents = theLesson.GetStudents();
            foreach (Student s in allStudents)
            {
                if (s != null)
                    lstStudents.Items.Add(s);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            Student currentStudent = lstStudents.SelectedItem as Student;
            

            if (currentStudent == null)
            {
                MessageBox.Show("You must select a student first");
            }
            else if (txtGrade.Text == "")
            {
                MessageBox.Show("Cannot enter an empty grade");
                txtGrade.Text = "";
            }
            else if (int.Parse(txtGrade.Text) > 100 || int.Parse(txtGrade.Text) < 0)
            {
                MessageBox.Show("Grade can only be betweek 0-100!");
                txtGrade.Text = "";
            }

            else
            {
                currentStudent.AddGrade(int.Parse(txtGrade.Text));
                MessageBox.Show("Grade is updated");
                UpdateStudentList();
                txtGrade.Text = "";
            }
            EnableStduentOperations(false);
        }

        private void EnableStduentOperations(bool toEnable)
        {
            grpAddGrade.Enabled = toEnable;
            btnRemoveStudent.Enabled = toEnable;
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem == null)
                EnableStduentOperations(false);
            else
                EnableStduentOperations(true);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grpStudents.Visible = false;
            grpCreateLesson.Visible = true;
            grpLessons.Visible = false;
            txtLessonName.Text = "";
            txtMaxStudents.Text = "";
        }

        private void lstLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLessons.SelectedItem == null) return;
            foreach (Lesson item in allCourses.getLessons())
            {
                if (item is null) return;
                if (item.GetSubject().Equals(lstLessons.SelectedItem)){
                    theLesson = item;
                    lstStudents.Items.Clear();
                    Student[] lessonStudents = item.GetStudents();
                    foreach (Student s in lessonStudents)
                    {
                        if (s != null)
                            lstStudents.Items.Add(s);
                    }
                }
            }
        }
    }
}

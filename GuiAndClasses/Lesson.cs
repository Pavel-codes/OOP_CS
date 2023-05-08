using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAndClasses
{
    class Lesson
    {
        private string subject;
        private Student[] allStudents;
        private int numOfStudents;

        public Lesson(string subject, int maxStudents)
        {
            this.subject = subject;
            allStudents = new Student[maxStudents];
            numOfStudents = 0;
        }

        public Student[] GetStudents() { return allStudents; }
        public string GetSubject() { return subject; }
        public int GetMaxStudents() { return allStudents.Length; }
        public int GetNumOfStudents() { return numOfStudents; }
        public bool CanAddAnotherStudent() { return numOfStudents < allStudents.Length; }

        public bool RemoveStudent(Student s)
        {
            for (int i = 0; i < numOfStudents; i++)
            {
                if (allStudents[i] == s)
                {
                    for (int j = i + 1; j < numOfStudents; j++)
                    {
                        allStudents[j - 1] = allStudents[j];
                    }
                    allStudents[numOfStudents - 1] = null;
                    numOfStudents--;
                    return true;
                }
            }
            return false;
        }
        public bool AddStudent(Student s)
        {
            if (CanAddAnotherStudent())
            {
                allStudents[numOfStudents++] = s;
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            string res = "The class has " + numOfStudents + " students (out of " + allStudents.Length + "):\n";
            for (int i = 0; i < numOfStudents; i++)
                res += "\t" + allStudents[i].ToString();

            return res;
        }
    }
}

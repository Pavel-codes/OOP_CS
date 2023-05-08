using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAndClasses
{
    class Student
    {
        private string name;
        private int[] allGrades;
        private int numOfGrades;

        public Student(string name)
        {
            this.name = name;
            allGrades = new int[2];
            numOfGrades = 0;
        }

        public string GetName() { return name; }
        public int GetNumOfGrades() { return numOfGrades; }

        public bool AddGrade(int newGrade)
        {
            if (newGrade < 0 || newGrade > 100)
                return false;

            if (numOfGrades == allGrades.Length)
            {
                int[] temp = new int[allGrades.Length * 2];
                for (int i = 0; i < allGrades.Length; i++)
                    temp[i] = allGrades[i];

                allGrades = temp;
            }

            allGrades[numOfGrades++] = newGrade;
            return true;
        }
        public override string ToString()
        {
            string res = name + " has " + numOfGrades + " grades: ";
            for (int i = 0; i < numOfGrades; i++)
                res += allGrades[i] + " ";
            res += "\n";

            return res;
        }
    }
}

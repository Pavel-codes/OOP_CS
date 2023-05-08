using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAndClasses
{
    class Courses
    {
        private Lesson[] lessons;
        private int numOfLessons;

        public Courses()
        {
            numOfLessons = 0;
            lessons = new Lesson[2];
        }
        public Lesson[] getLessons()
        {
            return lessons;
        }
        public bool AddLesson(Lesson l)
        {
            if (l == null)
                return false;

            if (numOfLessons == lessons.Length)
            {
                Lesson[] temp = new Lesson[lessons.Length * 2];
                for (int i = 0; i < lessons.Length; i++)
                {
                    temp[i] = lessons[i];
                }
                lessons = temp;
            }

            lessons[numOfLessons++] = l;
            return true;
        }
    }
}

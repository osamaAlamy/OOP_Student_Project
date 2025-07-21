using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrecListWithClasses.BL
{
    class Course
    {
        public Course(string sCourseName, int hours)
        {
            CourseName = sCourseName;
            Hours = hours;
            

        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        int _Hours;
        public int Hours
        {
            set
            {
                if (value >= 3)
                    _Hours = value;
            }
            get { return _Hours; }
        }
        public void Add(string courseName, int hours)
        {
        }

    }
}

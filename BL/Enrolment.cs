using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrecListWithClasses.BL
{
    internal class Enrolment
    {
        #region Propertis
        public Student Student { get; set; }
        public Course Course { get; set; }
        DateTime _EnrolDate;
        public DateTime EnrolDate
        {
            set
            {
                if (value >= DateTime.Now)
                    _EnrolDate = value;
            }

            get { return _EnrolDate; }
        }
        public double Grade { get; set; }
        #endregion

        #region Methods
        public Enrolment()
        {
            Student = new Student();
            Course = new Course("", 10);
            EnrolDate = DateTime.Now;
            Grade = 0;
        }
        public Enrolment(Enrolment enrolment)
        {
            Student = new Student(enrolment.Student);
            Course = new Course(enrolment.Course.CourseName,10);
            EnrolDate = enrolment.EnrolDate;
            Grade = enrolment.Grade;
        } 
        #endregion


    }
}

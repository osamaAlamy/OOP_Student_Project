using Student_Project_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenrecListWithClasses.BL
{
    class Student
    {
        #region Counstructors
        public Student()
        {
            _Age = 18;
            _Name = "User";
            Id = 0;
            Enrolments = new List<Enrolment>();
            Major = new Major("", "");
        }
        public Student(string name, int age, string major)
        {
            _Age = age;
            _Name = name;
            Major = new Major(major,"");
            Enrolments = new List<Enrolment>();
        }
        public Student(Student myStudent)
        {
            Id = myStudent.Id;
            Name = myStudent.Name;
            Major = new Major(myStudent.Major.Name,myStudent.Major.DoctorName);
            Enrolments = new List<Enrolment>(myStudent.Enrolments);
        }
        #endregion

        #region Proprties
        public int Id { get; set; }
        string _Name;
        public string Name
        {
            set
            {
                if (_Name.Length < 200)
                    _Name = value;
            }
            get
            {
                return _Name;
            }
        }
        int _Age;
        public int Age
        {
            set
            {
                if (_Age >= 18)
                    _Age = value;
            }
            get
            {
                return _Age;
            }
        }
        public Major Major { get; set; }
        public List<Enrolment> Enrolments { get; }
        #endregion

        #region Methods
        public void Print()
        {
            Console.WriteLine($@"""student Name {this.Name}
Major {this.Major.Name}
age {this.Age}""");
        }
        public void AddCourses(string courseName, double grade)
        {
            Enrolment oEnrolment = new Enrolment();
            oEnrolment.Student = this;
            oEnrolment.Course = new Course(courseName,10);
            oEnrolment.EnrolDate = DateTime.Now;
            oEnrolment.Grade = grade;
            this.Enrolments.Add(oEnrolment);
        }
        public void AddCourses(Enrolment enrol)
        {
            Enrolments.Add(enrol);
        }
        public void printCourses()
        {
            foreach (var enrol in this.Enrolments)
            {
                Console.WriteLine($"The course name is: {enrol.Course.CourseName} " +
                    $"and the hours is: {enrol.Course.Hours} " +
                    $"and your grade is: {enrol.Grade} ");
            }
        }
        #endregion
    }
}

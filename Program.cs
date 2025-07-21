using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenrecListWithClasses.BL;


namespace Student_Project_Class
{


    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To student Grade project.");
            Console.WriteLine("__________________________________");

            Student student = new Student();
            Console.Write("Please Enter student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Please Enter Student Mejor: ");
            student.Major = new Major(Console.ReadLine(), "");

            Console.Write("Please Enter your Age: ");
            student.Age = int.Parse(Console.ReadLine());

            Course course1;
            Enrolment enrolment1;
            char cUserInput = 'r';
            int nHours = 0;
            string sCourseName = "";
            Console.WriteLine("Now you will Enter student Courses");

            while(cUserInput != 'q')
            {
                // Create Course Object
                Console.Write("Please enter course name: ");
                sCourseName = Console.ReadLine();
                Console.Write("Please Enter Course hours: ");
                nHours = int.Parse(Console.ReadLine());
                course1 = new Course(sCourseName, nHours);
                // create enrollment object
                enrolment1 = new Enrolment();
                enrolment1.Student = student;
                enrolment1.Course = course1;
                enrolment1.EnrolDate = DateTime.Now;
                Console.Write("Please Enter Course Grade: ");

                enrolment1.Grade = double.Parse(Console.ReadLine());
                student.AddCourses(enrolment1);

                Console.Write("For Exit Enter q: ");
                cUserInput = char.Parse(Console.ReadLine());


            }
            Console.WriteLine("________________________________");
            Console.WriteLine("this is the student information");
            student.Print();
            Console.WriteLine("___________________________");
            Console.WriteLine("this is the student course");
            student.printCourses();

        }
    }

}
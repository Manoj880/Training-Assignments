using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy
{
    public class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine("Student with ID: " + student.StudentId + " , Student Name: " + student.StudentName + " , and Date of Birth: " + student.DateOfBirth);
        }
        public static void display(Course course)
        {
            Console.WriteLine("Course ID: " + course.Id + " , Course Name: " + course.Name + " , Course Duration: " + course.duration + " , Course Fee is: " + course.fees);
        }
        public static void display(Enroll enroll)
        {
            Console.WriteLine("Enrollment Details");
            display(enroll.students);
            display(enroll.courses);
            Console.Write("Date of Enrollment: " + enroll.datetime);
        }
    }
}
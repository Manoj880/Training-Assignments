using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy
{
    class App
    {
        public static void Main()
        {
            /* case study-1*/



            //scenario1();
            //scenario2();
            //scenario3();
            //Course course = new Course(01, "Testing", 2, 18000);
            //Info.display(course);



            /*Case Study-2 */
            // Course course1 = new Course(101,"SAP",6,15000);
            // Student student = new Student(11, "Manoj", "19/09/1999");
            // AppEngine appengine = new AppEngine();
            // appengine.introduce(course1);
            // appengine.register(student);
            // appengine.enroll(student, course1);
            // Student[] students = appengine.listOfStudents();
            //for(int i=0;i<appengine.studentlistsize;i++)
            // {
            // Info.display(students[i]);
            // }
            // Course[] courses = appengine.listOfCourses();
            // for (int i = 0; i < appengine.courselistsize; i++)
            // {
            // Info.display(courses[i]);
            // }
            // Enroll[] enrolls = appengine.listOfEnrollments();
            // for (int i = 0; i < appengine.enrolllistsize; i++)
            // {
            // Info.display(enrolls[i]);
            // }



            // Course course2 = new Course(11, "C#", 4, 30000);
            // Student student1 = new Student(12, "Sandhya", "24/11/2000");
            // AppEngine appengine1 = new AppEngine();
            // appengine.introduce(course2);
            // appengine.register(student1);
            // appengine.enroll(student1, course2);
            // Student[] students1 = appengine.listOfStudents();
            // for (int i = 0; i < appengine.studentlistsize; i++)
            // {
            // Info.display(students[i]);
            // }
            // Course[] courses1 = appengine.listOfCourses();
            // for (int i = 0; i < appengine.courselistsize; i++)
            // {
            // Info.display(courses[i]);
            // }
            // Enroll[] enrolls1 = appengine.listOfEnrollments();
            // for (int i = 0; i < appengine.enrolllistsize; i++)
            // {
            // Info.display(enrolls[i]);
            // }



            /* CaseStudy-3 */
            //UserInterface userInterface = new SMS();
            //userInterface.showFirstScreen();



            /* Case-Study 4*/
            UserInterface userInterface = new SMS();
            userInterface.showFirstScreen();
            Console.ReadLine();
        //}
        //public static void scenario1()
        //{
        //    Student student = new Student(18334, "Manoj", "19-09-1999");
        //    Student student2 = new Student(18325, "Hari", "09-09-1999");
        //    Student student3 = new Student(18333, "Sandhya", "24-11-2000");
        //    Info.display(student);
        //    Info.display(student2);
        //    Info.display(student3);
        //}
        //public static void scenario2()
        //{
        //    Student[] students = new Student[2];
        //    students[0] = new Student(060, "Sunny", "13-11-2001");
        //    students[1] = new Student(035, "Sandhya", "24-11-2000");
        //    students[2] = new Student(059, "Sravya", "07-02-2001");
        //    Info.display(students[0]);
        //    Info.display(students[1]);
        //    Info.diaplay(students[2]);
        //}
        //public static void scenario3()
        //{
        //    Student[] student = new Student[3];
        
            
            //    for (int i = 0; i < student.Length; i++)
        //    {
        //        Console.WriteLine("Enter Id,Name and Date of Birth of student");
        //        student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
        //        Info.display(student[i]);
        //    }
        }

    }
}

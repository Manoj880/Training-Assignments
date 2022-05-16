using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Dob;

        public Student(int Id, string Name, String Dob)
        {
            this.Id = Id;
            this.Name = Name;
            this.Dob = Dob;
        }
        public Student()
        {

        }
        public void setId(int Id) { this.Id = Id; }
        public int getId() { return this.Id; }
        public void setName(String Name) { this.Name = Name; }
        public String getName() { return this.Name;}
        public void setDob(String Dob) { this.Dob = Dob; }
        public string getDob() { return this.Dob; }
    }
    public class Course
    {
        public int CourseId;
        public string CourseName;
        public string CourseDuration;
        public int CourseFees;

        public Course(int CourseId, string Coursename, string CourseDuration, int CourseFees)
        {
            this.CourseId = CourseId;
            this.CourseName = Coursename;
            this.CourseDuration = CourseDuration;
            this.CourseFees = CourseFees;
        }
        public Course()
        {

        }
        public void setId(int CourseId) { this.CourseId = CourseId;}
        public int getId() { return this.CourseId;}
        public void setName(string CourseName) { this.CourseName = CourseName;}
        public string getName() { return this.CourseName;}
        public void setDuration(string CourseDuration) { this.CourseDuration = CourseDuration;}
        public string getDuration() { return this.CourseDuration;}
        public void setFees(int CourseFees) { this.CourseFees=CourseFees;}
        public int getFees() { return this.CourseFees;}
    }
    public class Info
    {
        public void display(Student student1, Student student2, Student student3, Student student4, Student student5)
        {
            Console.WriteLine("Information of the students are: ");
            Console.WriteLine("The student named: {0} with Id: {1} and Dob: {2}", student1.getName(), student1.getId(), student1.getDob());
            Console.WriteLine("The student named: {0} with Id: {1} and Dob: {2}", student2.getName(), student2.getId(), student2.getDob());
            Console.WriteLine("The student named: {0} with Id: {1} and Dob: {2}", student3.getName(), student3.getId(), student3.getDob());
            Console.WriteLine("The student named: {0} with Id: {1} and Dob: {2}", student4.getName(), student4.getId(), student4.getDob());
            Console.WriteLine("The student named: {0} with Id: {1} and Dob: {2}", student5.getName(), student5.getId(), student5.getDob());
        }
        public void display(Course course1, Course course2, Course course3,Course course4, Course course5)
        {
            Console.WriteLine("Information of the Courses available are: ");
            Console.WriteLine("The course Id: {0} with Name: {1} and The duration is: {2} with a fees of: {3}/-", course1.getId(), course1.getName(), course1.getDuration(), course1.getFees());
            Console.WriteLine("The course Id: {0} with Name: {1} and The duration is: {2} with a fees of: {3}/-", course2.getId(), course2.getName(), course2.getDuration(), course2.getFees());
            Console.WriteLine("The course Id: {0} with Name: {1} and The duration is: {2} with a fees of: {3}/-", course3.getId(), course3.getName(), course3.getDuration(), course3.getFees());
            Console.WriteLine("The course Id: {0} with Name: {1} and The duration is: {2} with a fees of: {3}/-", course4.getId(), course4.getName(), course4.getDuration(), course4.getFees());
            Console.WriteLine("The course Id: {0} with Name: {1} and The duration is: {2} with a fees of: {3}/-", course5.getId(), course5.getName(), course5.getDuration(), course5.getFees());
        }
    }
    public class App
    {
        public void Scenario1()
        {
            Student student1 = new Student(001, "Manoj", "19/09/1999");
            Student student2 = new Student(002, "Sandhya", "24/11/2000");
            Student student3 = new Student(003, "Devadas", "24/03/1998");
            Student student4 = new Student(004, "Hari", "11/09/1999");
            Student student5 = new Student(005, "Manisha", "27/04/1998");

            Info info = new Info();
            info.display(student1, student2, student3, student4, student5);
        }
        public void Scenario2()
        {
            Student[] array = new Student[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Student name: ");
                string Name = Console.ReadLine();
                Console.Write("Enter Studen Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Date of Birth of student (dob in dd/mm/yyyy): ");
                string Dob = Console.ReadLine();
            }
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine();
            }
        }
        public void Courses()
        {
            Course course1 = new Course(101, "C#.Net", "60-Days", 30000);
            Course course2 = new Course(102, "Dbms", "40-Days", 20000);
            Course course3 = new Course(103, "Html", "45-Days", 15000);
            Course course4 = new Course(104, "Unit-Testing", "30-Days", 25000);
            Course course5 = new Course(105, "Stack-Development", "90-Days", 35000);


        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Scenario1();
            app.Scenario2();

            app.Courses();


            Console.Read();
        }
    }
}

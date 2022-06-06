using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();
        void updateCourseDetails();
        void viewAllEnrollments();




    }

    public class SMS : UserInterface
    {
        AppEngine appEngine;
        //int studentidseq;
        //int courseseq;
        public SMS()
        {
            this.appEngine = new AppEngine();
            //this.studentidseq = 1;
            //this.courseseq = 10;
        }
        public void introduceNewCourseScreen()
        {
            Console.Write("Enter Course ID: ");
            int CourseId = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Course Name: ");
            Console.WriteLine();
            string course = Console.ReadLine();
            Console.Write("Enter Course Duration: ");
            Console.WriteLine();
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Fee: ");
            Console.WriteLine();
            double Fee = Convert.ToInt32(Console.ReadLine());
            Course course1 = new Course(/*courseseq*/CourseId, course, duration, Fee);
            appEngine.introduce(course1);
            //courseseq++;
            Console.WriteLine("Course added succesfully....!");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Exit New Course Screen");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showAdminScreen();
            if (ex >= 2)
                showFirstScreen();
        }



        public void showAdminScreen()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welcome to Admin Screen");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter Your action \n1. Introuduce New Course \n2. Update Course Details \n3. Entoll Student \n4. View all Enrollments \n5. Exit Admin screen");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    updateCourseDetails();
                    break;
                case 3:
                    studentEnroll();
                    break;
                case 4:
                    viewAllEnrollments();
                    break;
                default:
                    //Console.Write("Please, Enter valid input: ");
                    //showAdminScreen();
                    if (ip >= 5)
                        showFirstScreen();
                    break;
            }
        }



        public void showAllCoursesScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("All Courses Screen");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("List of all available Courses");
            Console.WriteLine();
            //foreach(var v in appEngine.listOfCourses())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("course id: " + dr[0]);
                    Console.WriteLine("course name: " + dr[1]);
                    Console.WriteLine("course duration: " + dr[2]);
                    Console.WriteLine("course fees: " + dr[3]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Exit All Courses Screen....!");
            Console.WriteLine("Enter 2 to go to Student Management Screen....!");
            int ex = int.Parse(Console.ReadLine());
            if (ex <= 1)
                showStudentScreen();
            if (ex >= 2)
                showFirstScreen();
        }



        public void showAllStudentsScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("All students screen");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("List of all Registered students: ");
            Console.WriteLine();
            //foreach(var v in appEngine.listOfStudents())
            //{
            // Info.display(v);
            //}
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student id :" + dr[0]);
                    Console.WriteLine("Student name :" + dr[1]);
                    Console.WriteLine("Date of birth :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Exit All Students Screen....!");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showStudentScreen();
            if (ex >=2)
                showFirstScreen();
            //showFirstScreen();     
        }



        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to Student Management System(SMS) ");
            Console.WriteLine("----------------------------------------------------"); 
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Enter your action to perform : ");
            int op = Convert.ToInt32(Console.ReadLine());



            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    //Console.Write("Enter valid input: ");
                    //showFirstScreen();
                    if (op >= 3)
                    Environment.Exit(0);
                    break;
            }
        }



        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Student Registration Screen");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter Student ID: ");
            int sid = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Student Name: ");
            string sname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Date of Birth (dd/mm/yyyy): ");
            string dob = Console.ReadLine();
            Student student = new Student(/*studentidseq*/sid, sname, dob);
            appEngine.register(student);
            //studentidseq++;
            Console.WriteLine("Student registered succesfully");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Exit Student Registration Screen");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showStudentScreen();
            if (ex >= 2)
                showFirstScreen();
        }



        public void showStudentScreen()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Welcome! To Student Screen");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Select option to proceed: \n1. For Registration \n2. To See all Courses \n3. To See all Students\n4. Exit student screen");
            Console.Write("Enter your action Proceed: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCoursesScreen();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                default:
                    //Console.WriteLine("Please, Enter valid input");
                    //showStudentScreen();
                    if (input >= 4)
                        showFirstScreen();
                    break;

            }
        }
        public void studentEnroll()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Student Enrollment");
            Console.WriteLine("------------------------------");
            Console.Write("Enter Student ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Course ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Student student = appEngine.GetStudentById(sid);
            Course course = appEngine.GetCourseById(cid);
            if (student == null)
            {
                Console.WriteLine("There is NO student with this ID! Please, Check");
            }
            else
            {
                if (course == null)
                {
                    Console.WriteLine("There is NO course with this ID! Please, Check");
                }
                else
                {
                    appEngine.enroll(student, course);
                }
            }
            Console.WriteLine("Enter 1 to Exit Student Enroll Screen");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showAdminScreen();
            if (ex >= 2)
                showFirstScreen();

        }
        public void viewAllEnrollments()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enrollment Details");
            Console.WriteLine("---------------------------------");
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("Select * from Enroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student id: " + dr[0]);
                    Console.WriteLine("Course id: " + dr[1]);
                    Console.WriteLine("Date of Enrollment: " + dr[2]);
                    Console.WriteLine();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter 1 to Exit Student Enroll Screen");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showAdminScreen();
            if (ex >= 2)
                showFirstScreen();

        }
        public void updateCourseDetails()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Updating Course Screen");
            Console.WriteLine("----------------------------");
            try
            {
                con = SQLConnection.getcon();
                Console.Write("Enter Course ID to Update: ");
                int stuid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter Course name: ");
                string coursename = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter duration of Course: ");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter fees of Course: ");
                double fee = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                cmd = new SqlCommand("update Course set courseName = @name where CourseId=@sid", con);
                cmd.Parameters.AddWithValue("@name", coursename);
                cmd.Parameters.AddWithValue("@dur", duration);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@sid", stuid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Changes updated Successfully");
                }
                else Console.WriteLine("Oops! Something went wrong. Record not Updated....!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter 1 to Exit Course Details Screen");
            Console.WriteLine("Enter 2 to go to Student Management Screen");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
                showAdminScreen();
            if (ex >= 2)
                showFirstScreen();
        }
        //public class User_Exception
        //{

        //}
    }
}
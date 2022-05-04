using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_P2
{
    class Employee
    {
        public int EmployeeId;
        public string firstname;
        public string lastname;
        public string Title;
        public string DOB;
        public DateTime DOJ { get; set; }
        public string City;
       

       
        class Query
        {
            static void Main(string[] args)
            {
              
                List<Employee> emplist = new List<Employee>();
                emplist.Add(new Employee { EmployeeId = 1001, firstname = "Malcolm", lastname = "Daruwalla", Title = "Manager", DOB = "16 / 11 / 1984", DOJ = Convert.ToDateTime("8 / 6 / 2011"), City = "Mumbai" });
                emplist.Add(new Employee { EmployeeId = 1002, firstname = "Asdin", lastname = "Dhalla", Title = "AsstManager", DOB = "20/ 08 / 1984", DOJ = Convert.ToDateTime("7 / 7 / 2012"), City = "Mumbai" });
                emplist.Add(new Employee { EmployeeId = 1003, firstname = "Madhavi", lastname = "Oza", Title = "Consultant", DOB = "14 / 11 / 1987", DOJ = Convert.ToDateTime("12 / 4 / 2015"), City = "Pune" });
                emplist.Add(new Employee { EmployeeId = 1004, firstname = "Saba", lastname = "Shaikh", Title = "SE", DOB = "03 / 06 / 1990", DOJ = Convert.ToDateTime("2 / 2 / 2016"), City = "Pune" });
                emplist.Add(new Employee { EmployeeId = 1005, firstname = "Nazia", lastname = "Shaikh", Title = "SE", DOB = "08 / 03 / 1991", DOJ = Convert.ToDateTime("2 / 2 / 2016"), City = "Mumbai" });
                emplist.Add(new Employee { EmployeeId = 1006, firstname = "Amit", lastname = "Pathak", Title = "Consultant", DOB = "07 / 11 / 1989", DOJ = Convert.ToDateTime("8 / 8 / 2014"), City = "Chennai" });
                emplist.Add(new Employee { EmployeeId = 1007, firstname = "Vijay", lastname = "Natrajan", Title = "Consultant", DOB = "02 / 12 / 1989", DOJ = Convert.ToDateTime("1 / 6 / 2015"), City = "Mumbai" });
                emplist.Add(new Employee { EmployeeId = 1008, firstname = "Rahul", lastname = "Dubey", Title = "Associate", DOB = "11 / 11 / 1993", DOJ = Convert.ToDateTime("6 / 11 / 2014"), City = "Chennai" });
                emplist.Add(new Employee { EmployeeId = 1009, firstname = "Suresh", lastname = "Mistry", Title = "Associate", DOB = "12 / 08 / 1992", DOJ = Convert.ToDateTime("3 / 12 / 2014"), City = "Chennai" });
                emplist.Add(new Employee { EmployeeId = 1010, firstname = "Sumit", lastname = "Shah", Title = "Manager", DOB = "12 / 04 / 1991", DOJ = Convert.ToDateTime("2 / 1 / 2016"), City = "Pune" });

               



                IEnumerable<Employee> Query1 = from Employee in emplist
                                                select Employee;
                IEnumerable<Employee> Query2 = from Employee in emplist
                                           where Employee.City != "Mumbai"
                                           select Employee;
                IEnumerable<Employee> Query3 = from Employee in emplist
                                            where Employee.Title == "AsstManager"
                                            select Employee;
                IEnumerable<Employee> Query4 = from Employee in emplist
                                             where Employee.lastname.StartsWith("S")
                                             select Employee;
                IEnumerable<Employee> Query5 = from Employee in emplist
                               
                                              where Employee.DOJ <= Convert.ToDateTime("1 / 1/2015")
                                              select Employee;
                foreach (var a in Query1) { Console.WriteLine("All the Employees are: {0} {1} with Employee ID: {2}",a.firstname,a.lastname,a.EmployeeId);}
                foreach (var b in Query2) { Console.WriteLine("The name of Employee who is not from mumbai is: {0}",b.firstname);}
                foreach (var c in Query3) { Console.WriteLine("The Employee whose Title is AsstManager is: {0}",c.firstname); }
                foreach (var d in Query4) { Console.WriteLine("The Employee Name whose lastname starts with S is: {0}",d.firstname,d.lastname); }
                foreach (var e in Query5) { Console.WriteLine("The employee Name who joined Before 1/1/2015 is: {0}",e.firstname); }
                
                Console.Read();
            }
        }
        
    }
}

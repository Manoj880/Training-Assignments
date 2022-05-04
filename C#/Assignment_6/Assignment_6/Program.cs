using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {

        static void Main(string[] args)
        { 

            Dayscholar dayscholar = new Dayscholar();
            dayscholar.ShowDetails("Manoj", 334);
            
            Resident resident = new Resident();
            resident.ShowDetails("Sunny", 325);

            Books books = new Books(334);
            books.value(325);
            Console.Read();
        }
        interface IStudent
        {
            

            void ShowDetails(string Name, int StudentId);

        }
        class Dayscholar : IStudent
        {
             public void ShowDetails(string Name, int StudentId)
            {
                Console.WriteLine("The student with name: {0} with Id: {1} is a Dayscholar",Name,StudentId);
            }
        }
        public class Resident: IStudent
        {
            
            public void ShowDetails(string Name, int StudentId)
            {
                Console.WriteLine("The Resident with Name: {0} and Id: {1} resides in college.",Name,StudentId);
            }

        }
        struct Books
        {
            int book_id;
            public int Book_id { get { return book_id; } set { book_id = value; } }
            public Books(int book_id) { this.book_id = book_id; }
            public void value(int value)
            {
                Console.WriteLine("The Id of book is: {0} and the value of book is: {1}", book_id, value);
            }
            
        }       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest1
{
    internal class Program
    {
        class test
        {

            static void Main(string[] args)
            {
                try
                {
                    Passenger passenger = new Passenger("Manoj", "22", "10/5/2022");
                    Console.WriteLine("Enter no of tickets to be booked: ");
                    Passenger.Ticket_Booking(int.Parse(Console.ReadLine()));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }



                Console.ReadLine();
            }
        }
    }
    class Passenger
    {
        public string name;
        public string age;
        public string Date_of_Travel;

        public Passenger(string name, string age, string Date_of_Travel)
        {
            this.name = name;
            this.age = age;
            this.Date_of_Travel = Date_of_Travel;
            Console.WriteLine("The Passenger of Name {0} with age {1} with date of journey {2}", name, age, Date_of_Travel);
        }
        public static void Ticket_Booking(int No_of_Tickets)
        {
           
            try
            {
                

                if (No_of_Tickets > 5)
                {
                    Console.WriteLine("Cannot book More than 5 tickets.");
                }
                else
                {
                    Console.WriteLine("Tickets Booking Successful");
                    }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }



    }
}

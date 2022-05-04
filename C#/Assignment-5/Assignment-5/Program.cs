using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
       class Bank
        {
            string accname = "Manoj";
            int amt = 10000;
            static int newbal;
            public void Bank_Balance()
            {
                { Console.WriteLine("Hello! {0} your account balance is: {1}", accname, amt); }

            }
            public void Deposite()
            {
                try
                { Console.WriteLine("Enter the amount to deposite: "); 
                    int dm = int.Parse(Console.ReadLine());
                    newbal = amt + dm;
                    Console.WriteLine("Amount depositted successfully!");
                    Console.WriteLine("Total amount in your account is: {0}", newbal);
                }
                catch (Exception) { Console.WriteLine("Please enter Valid amount"); }
            }
            public void Withdraw()
            {
                try { Console.WriteLine("Enter amount to withdraw: ");
                    int wm=int.Parse(Console.ReadLine());
                    newbal = amt - wm;
                    if (wm > amt) { Console.WriteLine("Insufficient Amount! Please check your balance"); }
                    else { Console.WriteLine("Amount withdrawn successfully"); 
                        Console.WriteLine("Remaining amount in your account is: {0}", newbal); }
                }
                catch (Exception) { Console.WriteLine("Please enter Valid amount."); }   
                
            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            string accname = "Manoj";
            string bank_name = "Axis";
            string accno;
            int Pin;            // ------ Pin = 1234 ------
            int action;
            Console.WriteLine("Hi! {0} welcome to {1} bank", accname, bank_name);
            Console.WriteLine("Please Enter the account number: ");
            accno = Console.ReadLine();
            Console.WriteLine("Welcome! {0}", accname);
            Console.WriteLine("Please enter pin to access your account");
            Pin = int.Parse(Console.ReadLine());
            //try
            {
                if (Pin == 1234)
                { Console.WriteLine("Select the action to continue the process:"); }

                else
                { Console.WriteLine("Incorrect pin! Please check your pin and try again."); }
            }
           // catch(Exception) { Console.WriteLine("Unauthorised Access"); }
            action=Convert.ToInt32(Console.ReadLine());
            if (action == 1) { bank.Bank_Balance(); }
            else if (action == 2) { bank.Deposite(); }
            else if (action == 3) { bank.Withdraw(); }
            else { Console.WriteLine("You have not selected any action! Try again."); }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class WithdrawException : ApplicationException
    {
        public WithdrawException(string m): base(m)
        {
        }
    }
    class Bank
    {
        string acc_name = "Manoj";
        int amt= 25000;
        static int newbal;
        
        public void Bank_Balance()
        {
            Console.WriteLine("Welcome! {0} your account balance is: {1}", acc_name,amt);
         }
        public void WithDraw()
        {
              Console.WriteLine("Enter the amount to withdraw: ");
                int wm = int.Parse(Console.ReadLine());


                newbal = amt - wm;
                if (wm > amt)
                {
                    throw (new WithdrawException("Insufficient Amount please check your balance"));
                }
                else
                {
                    Console.WriteLine("Amount withdrawn successfully");
                    Console.WriteLine("Remaining amount in your account is: {0}", newbal);
                }
            
        }
        public void Deposite()
        {
            try
            {
                Console.WriteLine("Enter Amount To Deposite: ");
                int dm = int.Parse(Console.ReadLine());
                newbal = amt + dm;
                Console.WriteLine("Amount depositted successfully!");
                Console.WriteLine("Total amount in your account is: {0}", newbal);
            }
            catch (Exception) { Console.WriteLine("Please enter valid amount"); }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            string acc_name = "Manoj";
            string bank_name = "Axis";
            string acc_num;
            
            Console.WriteLine("Hi! {0} Welcome to {1} bank", acc_name, bank_name);
            Console.WriteLine("Please enter account number: ");
            acc_num =Console.ReadLine();
            Console.WriteLine("Enter 1 to check your Bank Balance");
            Console.WriteLine("Enter 2 to withdraw amount from your account");
            Console.WriteLine("Enter 3 to Deposite amount from your account");
            Console.WriteLine("Select action to continue the process: ");
            string action;
            action=(Console.ReadLine());
            try
            {
                //bank.Bank_Balance();
                //bank.WithDraw();
                //bank.Deposite();
                if (action == "1") { bank.Bank_Balance(); }
                else if (action == "2") { bank.WithDraw(); }
                else if (action == "3") { bank.Deposite(); }
                else { Console.WriteLine("Please select valid action!"); }
            }
            catch (WithdrawException w) { Console.WriteLine(w.Message); }
            catch (FormatException e) { Console.WriteLine(e.Message); }
            Console.ReadLine();
            
            
            
        } 
     
        }
    }


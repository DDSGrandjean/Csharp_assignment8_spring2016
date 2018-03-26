//DYLAN GRANDJEAN
//Assignment 8 - Loans App
//This program is designed to give the user an amount of borrowable loan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Main
    {
        static void Main(string[] args)
        {
            //Display header and instruction for this program
            Header();
            Instruction();

            //Instantiate the Calculation class
            CalculateLoan calculate = new CalculateLoan();

            //Get user inputs
            Console.Write("Enter name: ");
            calculate.Name = Console.ReadLine();
            Console.Write("Enter salary: ");
            calculate.Salary = double.Parse(Console.ReadLine());
            Console.Write("Enter credit code: ");
            calculate.CreditCode = int.Parse(Console.ReadLine());

            Console.WriteLine(calculate.ToString());
            Console.Read();
        }

        public static void Header()
        {
            Console.WriteLine("\tLoan\n" +
                              "\tCalculate loans for employees\n" +
                              "\tDYLAN GRANDJEAN\n\t" +
                              DateTime.Today.ToShortDateString());
        }

        public static void Instruction()
        {
            Console.WriteLine("*******************************************************\n" +
                              "This program will determine loans for employees\n\n" +
                              "You will be asked to enter name, salary,\nand credit code.\n\n" +
                              "*******************************************************");
        }
    }
}

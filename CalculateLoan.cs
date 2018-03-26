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
    class CalculateLoan
    {
        //Variable declaration
        private string name;
        private double salary;
        private double subLoan;
        private double loan;
        private int creditCode;
        private int creditBonus;
        private bool error = false;

        //Default constructor
        public CalculateLoan(){}

        //Get values from the user and instantiates class variables
        public string Name { set { name = value; } }
        public double Salary { set { salary = value; } }
        public int CreditCode { set { creditCode = value; } }

        //determines eligibility and amount of loan available
        private void CalculateAmount()
        {
            switch (creditCode)
            {
                case 1: creditBonus = 5000; break;
                case 2: creditBonus = 4000; break;
                case 3: creditBonus = 3000; break;
                case 4: creditBonus = 1000; break;
                default: error = true;      break;
            }

            if (salary > 0)
            {
                if (salary >= 40000)
                    subLoan = salary * 0.25;
                else
                    subLoan = salary * 0.15;

                loan = subLoan + creditBonus;
            }
            else
                error = true;

        }

        //Turns output values ToString()
        public override string ToString()
        {
            CalculateAmount();

            if (error)
            {
                return "*******************************************************\n" +
                       "Salary error";
            }
            else
            {
                return "*******************************************************\n" +
                       "\tName > " + name +
                       "\nLoan amount > " + subLoan.ToString("C") +
                       "\nAdditional amount > " + creditBonus.ToString("C") +
                       "\nTotal loan >" + loan.ToString("C");
            }
        }
    }
}

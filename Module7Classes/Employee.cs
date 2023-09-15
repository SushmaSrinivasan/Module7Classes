using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7classes
{
    public class Employee
    {
        public string fName;
        public string lName;
        public string email;

        const int minimalHoursWorkedUnit = 1;

        public int noOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        public Employee(string v1, string v2, string v3, DateTime dateTime, int v4)
        {
        }

        public void PerformWork()
        {
            // noOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{fName} {lName} has worked for {noOfHoursWorked} hours");

        }
        public void PerformWork(int noOfHoursWorked)
        {
            noOfHoursWorked += noOfHoursWorked;
            Console.WriteLine($"{fName} {lName} has worked for {noOfHoursWorked} hours");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            wage = noOfHoursWorked * hourlyRate;

            Console.WriteLine($"{fName} {lName} has received a wage of {wage} for {noOfHoursWorked} hour(s) of work.");

            if (resetHours)
                noOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{fName}\nLast name: \t{lName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
        


    }
}

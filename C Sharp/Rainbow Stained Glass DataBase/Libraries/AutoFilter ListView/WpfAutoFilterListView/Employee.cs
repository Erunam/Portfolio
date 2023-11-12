using System;
using System.Collections.Generic;
using System.Text;

namespace ScottLogic
{
    public class Employee
    {
        private string lastNameValue;
        private string firstNameValue;
        private int? salaryValue;
        private DateTime? startDateValue;

        public Employee(string lastName, string firstName,
            int? salary, DateTime? startDate)
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
            StartDate = startDate;
        }

        public string LastName
        {
            get { return lastNameValue; }
            set { lastNameValue = value; }
        }
        public string FirstName
        {
            get { return firstNameValue; }
            set { firstNameValue = value; }
        }

        public int? Salary
        {
            get { return salaryValue; }
            set { salaryValue = value; }
        }

        public DateTime? StartDate
        {
            get { return startDateValue; }
            set { startDateValue = value; }
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName + "\n" +
                "Salary:" + salaryValue + "\n" +
                "Start date:" + startDateValue;
        }

    }
}

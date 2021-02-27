using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;

        private string lastName;

        private decimal salary;

        private int age;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (!NameCheck(value))
                {
                    throw new ArgumentException($"First name cannot contain fewer than 3 symbols!");
                }

            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (!NameCheck(value))
                {
                    throw new ArgumentException($"Last name cannot contain fewer than 3 symbols!");
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (!MinAge(value))
                {
                    throw new ArgumentException($"Age cannot be zero or a negative integer!");
                }
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if(!MinSalary(value))
                {
                    throw new ArgumentException($"Salary cannot be less than 460 leva!");
                }
            }
        }

    


    public override string ToString()
        {   
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

    public void IncreaseSalary(decimal precentage)
    {
        if (Age > 30)
        {
           this.Salary += this.Salary * precentage / 100;
        }
        else
        {
            this.Salary += this.Salary * precentage / 100;
        }
    }

    public bool NameCheck(string name)
    {
        if (name.Length < 3)
        {
            return false;
        }

        return true;
    }

    public bool MinSalary(decimal salary)
    {
        if (salary < 460)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool MinAge(int age)
    {
        if (age <= 0)
        {
            return false;
        }

        return true;
    }
    }
}

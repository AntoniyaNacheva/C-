//using System.Security.Cryptography.X509Certificates;

using System.Security.Cryptography;

namespace inheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Manager carl = new Manager("Carl", 45, "Manager", 123123, 7);
            ////carl.DisplayManagerInfo();
            //carl.BecomeOlder(5);

            //carl.DisplayManagerInfo();

            //Console.WriteLine(carl.ToString());

            //Employee joe = new Employee("Joe", 36, "Sales Rep", 12345);
            //joe.DisplayEmployeeInfo();

            //Dog dog = new Dog();
            //dog.MakeSound();


            //BaseClass baseClass = new BaseClass();
            //baseClass.ShowFields();

            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.AccessFields();
            //derivedClass.ShowFields();


            //Dog myDog = new Dog();
            //myDog.MakeSound();
            ////myDog.Eat();

            //Cat mycat = new Cat();
            //mycat.MakeSound();
            ////mycat.Eat();

            Console.ReadKey();
        }
    }

    public class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. " +
                $"New balance is {Balance:C}.");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. " +
                    $"New balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

    public sealed class SavingAccount : Account
    {
        public SavingAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance)
        {

        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds. " +
                    "Cannot withdraw from a savings account.");
            }
        }
    }

    /*
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Person contructor called");
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public int BecomeOlder(int years)
        {
            Age += years;
            return Age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID)
            : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee contructor called");
        }
        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, " +
                $"Employee ID: {EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobTitle,
            int employeeID, int teamSize)
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
    */


    /*
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }
    */

    /*
    class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, " +
                $"Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            // privateField = 3;
        }
    }
    */

    /*
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat is miaowing...");
        }
    }
    */

    //class Collie : Dog
    //{
    //    public void GoingNuts()
    //    {
    //        Console.WriteLine("Collie going Nuts");
    //    }
    //}
}

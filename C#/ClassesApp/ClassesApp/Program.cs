using System.Drawing;

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Creating of object ot an instance of the Class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            //Console.WriteLine("Please enter the Brand name");
            // Setting brand
            //audi.Brand = Console.ReadLine();


            // Getting brand
            Console.WriteLine($"Brand is {audi.Brand}");
            Console.WriteLine($"Brand is {bmw.Brand}");
            */

            /*
            Customer earl = new Customer("Earl");
            Customer frank = new Customer("Frank");

            Customer myCustomer = new Customer();

            myCustomer.SetDetails("Frank", "Mainstreet 2", "213313212");

            Console.WriteLine($"myCustomer is {myCustomer.Name} " +
                $"and he lives in {myCustomer.Address}");

            Console.WriteLine($"earl is {earl.Name} " +
                $"and he lives in {earl.Address}");

            //Console.WriteLine($"Name of Customer is {earl.Name}");
            */

            // Default Customer with no Arguments given

            /*
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter the customer name");
            myCustomer.Name = Console.ReadLine();

            Console.WriteLine($"Details about customer {myCustomer.Name}");
            */

            /*
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();

            Car myBmw = new Car("i7", "BMW", true);
            myBmw.Drive();
            */

            /*
            Customer customer = new Customer();
            customer.SetDetails("Denis", "Mainstreet 1");

            Customer customer1 = new Customer("Frank");

            Console.WriteLine($"ContactNumber of Frank is {customer1.ContactNumber}");
            */

            /*
            Console.WriteLine(AddNum(15, 25));

            // Using named parameter
            Console.WriteLine(AddNum(firstNum: 23,secondNum: 25));
            */

            /*
            Rectangle r1 = new Rectangle();
            r1.Width = 5;
            r1.Height = 5;

            Console.WriteLine($"Area of r1 is {r1.Area}");

            */

            //Customer.DoSomeCustomerStuff();
            //Customer myCustomer = new Customer();

            // The DoSomeCustomerStuff method is static and cannot be called on Objects
            // myCustomer.DoSomeCustomerStuff();

            //MyMethod();

            /*
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);
            car3.Drive();

            // accessing the public static variable NumberOfCars of the Car Class
            Console.WriteLine($"Number of cars produced: {Car.NumberOfCars}");
            */

            /*
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John");
            Customer customer3 = new Customer();

            customer1.getDetails();
            customer2.getDetails();

            //Console.WriteLine($"Customer 3 id is {customer3.Id}");

            customer3.Password = "13654ggff$%";
            customer3.getDetails();
            */

            Rectangle rect1 = new Rectangle("Red");
            Rectangle rect2 = new Rectangle("Blue");

            rect1.DisplayDetails();
            rect2.DisplayDetails();

            Console.ReadKey();
        }

        // In C# the static keyword is used to declare members of a class that belong 
        // to the class itself rather that to any specific instance ot the class

        //static void MyMethod()
        //{
        //    Console.WriteLine("My Method");
        //}

        /*
        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        */
    }
}
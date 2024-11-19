
namespace ListsApp
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Price = 0.80 },
                new Product { Name = "Banana", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 }
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapProducts = products
                .Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Available Products for less than $1: ");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: " +
                    $"{product.Name} for {product.Price}");
            }


            /*
            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            bool hasLargeNumber = numbers.Any(x => x > 30);

            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers");
            }
            else
            {
                Console.WriteLine("No large numbers");
            }
            */

            /*
            //static int Squaring(int num1)
            //{
            //    return num1 + num1;
            //}

            List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };

            Console.WriteLine("Unsorted list");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Predicate<int> isGreaterThanTen = IsGreaterThanTen;

            List<int> higherTen = numbers.FindAll(isGreaterThanTen);


            //Console.WriteLine(higherEqualTen);

            Console.WriteLine("All numbers 10 or higher in our list numbers");
            foreach (int number in higherTen)
            {
                Console.WriteLine(number);
            }
            */

            /*
            Console.WriteLine("Unsorted list");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted list");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /* 
             
            List<string> colors = ["red", "blue", "green", "red"];

            colors.Add("blue");

            //List<string> colors = new List<string>();

            //colors.Add("red");
            //colors.Add("blue");
            //colors.Add("green");
            //colors.Add("red");

            Console.WriteLine("Current colors in the colors list:");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Deleted the first element
            bool isDeleting = colors.Remove("red");
            while (isDeleting)
            {
                isDeleting = colors.Remove("red");
            }

            Console.WriteLine("Current colors in the colors list:");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            */

            Console.ReadKey();
        }

        /*
        public static bool IsGreaterThanTen(int x)
        {
            return x > 10;
        }
        */
    }
}

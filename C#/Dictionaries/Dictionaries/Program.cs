namespace Dictionaries
{
    /*
    class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    */

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("1", new Student(1, "John", 85));
            students.Add("2", new Student(2, "Alice", 90));
            students.Add("3", new Student(3, "Bob", 78));

            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.Value.Name}, " +
                    $"Id: {item.Value.Id}, Grade: {item.Value.Grade}");
            }

            /*
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The statecode is {item.Key} " +
                    $"and the state name is {item.Value}");
            }
            */

            /*
            Dictionary<string, List<int>> myDict = new Dictionary<string, List<int>>
            {
                {"numbers", new List<int> { 1, 2, 3 }}
            };

            foreach (int number in myDict["numbers"])
            {
                Console.Write(number + " ");
            }
            */

            /*
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John", 35, 100000));
            employees.Add(2, new Employee("Maria", 25, 200000));
            employees.Add(3, new Employee("Tony", 45, 80000));
            employees.Add(4, new Employee("Emmz", 15, 50000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: " +
                    $"{item.Value.Name} earns {item.Value.Salary} " +
                    $"and is {item.Value.Age} years old!");
            }
            */

            /*
              
            Dictionary<int, string> employees = new Dictionary<int, string>();
             
            employees.Add(101, "John");
            employees.Add(102, "Bob");
            employees.Add(103, "Rob");
            employees.Add(104, "Flob");
            employees.Add(105, "Dob");

            string name = employees[101];

            //Console.WriteLine(name);

            employees[102] = "Jane";

            employees.Remove(101);

            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            bool added = employees.TryAdd(102, "Tony");

            if (!added)
            {
                Console.WriteLine("Employee with the id of 102 already exist");
            }
            */

            /*
            int counter = 101;

            while (employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Jesus Christ");

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, " +
                    $"Name: {employee.Value}");
            }
            */

            Console.ReadKey();
        }
    }
}

namespace DelegatesAndEvents
{
    //// 1. Declaration:
    //public delegate void Notify(string message);

    /*
    public delegate int Comaparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comaparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        // Swapping mechanism
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }
    */

    internal class Program
    {
        //// 1. Declaration:
        //public delegate void Notify(string message);


        public delegate void LogHandler(string message);

        public class Logger
        {
            public void LogToConsole(string message)
            {
                Console.WriteLine("Console Log: " + message);
            }
            public void LogToFile(string message)
            {
                Console.WriteLine("File Log: " + message);
            }
        }

        static void Main(string[] args)
        {
            /*
            Person[] people = {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Denis", Age = 36 },
                new Person { Name = "Charlie", Age = 35 }
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            sorter.Sort(people, CompareByName);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
            */


            /*
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "One", "Two", "Three", "Four" };

            PrintArray(intArray);
            PrintArray(stringArray);
            */

            Logger logger = new Logger();

            // Creating a multicast delegate
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            // Invoking the multicast delegate
            logHandler("Log this info");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);
                }
            }

            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else
            {
                Console.WriteLine("LogToFile Method not found");
            }

            //logHandler("After removing LogToFile");

            if (logHandler != null)
            {
                InvokeSafely(logHandler, "After removing LogToFile");
            }




            /*
            Logger logger = new Logger();
            LogHandler logHandler =  logger.LogToConsole;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Log some stuff");
            */


            //// 2. Instantiation:
            //Notify notifyDelegate = ShowMessage;

            //// 3. Invocation:
            //notifyDelegate("Hello, Delegates");

            Console.ReadKey();
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;

            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }
            return false;
        }

        /*
        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
        */

        /*
        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        // Generic method that accepts a generic datatype
        public static void PrintArray<T>(T[] array)
            {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
        */


        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
}

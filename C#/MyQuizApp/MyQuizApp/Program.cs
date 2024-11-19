namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    1
                ),
                new Question(
                    "What is 2 + 2?",
                    new string[] {"3", "4", "5", "6"},
                    1
                ),
                 new Question(
                    "Who wrote Hamlet?",
                    new string[] {"Goethe", "Austin", "Shakespeare", "Dickens"},
                    2
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}

/*
using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("John", 30);
            person.Greet();
        }
    }

    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            _name = name;
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }
    }
}
*/

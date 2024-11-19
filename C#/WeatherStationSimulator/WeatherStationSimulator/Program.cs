namespace WeatherStationSimulator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            // int and double

            int myInt = 5;
            double myDouble = 8.1;

            //int myIntResult = myInt / myDouble; // error

            //double myDoubleResult = myInt / 8 + 5 / 3; 
            //double myDoubleResult = myInt / 8.0 + 5.0 / 3;

            double myDoubleResult = myInt / myDouble;

            Console.WriteLine(myDoubleResult);

            Console.ReadLine();
            */

            Console.WriteLine("Enter the number of days to simulate:");

            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            //double averageTemp = CalculateAverage(temperature);

            Console.WriteLine($"Average Temparature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was: {temperature.Max()}");

            Console.WriteLine($"The min temp was: {temperature.Min()}");
            //Console.WriteLine($"The min temp was: {MinTemperature(temperature)}");

            Console.WriteLine($"Most common condition is: {MostCommonCondition(weatherConditions)}");

            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;

                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            //foreach (int i in temperature)
            //{
            //    sum += i;
            //}
            //return temperature[0];

            double average = sum / temperature.Length;

            return average;
        }

        //static int MinTemperature(int[] temperature)
        //{
        //    int min = temperature[0];

        //    foreach (int temp in temperature)
        //    {
        //        if (temp < min)
        //        {
        //            min = temp;
        //        }
        //    }
        //    return min;
        //}
    }
}


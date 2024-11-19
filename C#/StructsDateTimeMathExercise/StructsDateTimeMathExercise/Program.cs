using System.Security.Cryptography.X509Certificates;

namespace StructsDateTimeMathExercise
{
    public struct Event
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;

            if (startDate >= endDate)
            {
                throw new ArgumentException("StartDate must be before EndDate");
            }
        }
        public double GetDuration()
        {
            return (EndDate - StartDate).TotalDays;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            return StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));

            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");

            Console.ReadKey();
        }
    }
}

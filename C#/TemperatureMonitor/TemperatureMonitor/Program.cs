using System.ComponentModel;

namespace TemperatureMonitor
{
    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        // property holding the temperature
        public int Temperature { get; }

        // constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        //public event TemperatureChangeHandler OnTemperatureChanged;

        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                //_temperature = value;
                if (_temperature != value)
                {
                    _temperature = value;
                    //RaiseTemperatureChangedEvent("Temperature is above threshold");

                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // letting every subscriber know
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // Subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is {sender}");
        }
    }

    public class TempCoolingAlert
    {
        public void OnTemparatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temp Cooling Alert: temperature is {e.Temperature} sender is {sender}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();   

            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemparatureChanged;

            monitor.Temperature = 20;

            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

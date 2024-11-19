namespace StockPriceAlertSystem
{
    public delegate void StockPriceChangedHandler(string message);

    public class Stock
    {
        public event StockPriceChangedHandler OnStockPriceChanged;

        private decimal _price;
        private decimal _threshold;

        // TODO: Implement the Price property with event triggering
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (_price < Threshold)
                {
                    RaiseStockPriceChangedEvent("Stock Alert: Stock price is below threshold!");
                }
            }
        }
        // TODO: Implement the Threshold property
        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        // TODO: Implement the RaiseStockPriceChangedEvent method
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
        }
    }

    public class StockAlert
    {
        // TODO: Implement the OnStockPriceChanged method
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine("Stock Alert: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implement the stock price alert test

            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            stock.Threshold = 120m;

            stock.Price = 130m;
            stock.Price = 110m;


            Console.ReadKey();
        }
    }
}

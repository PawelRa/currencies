namespace currencies
{
    public class CurrencyInMemory : CurrencyBase
    {
        private List<double> euro = new List<double>(); //EUR
        private List<double> dollar = new List<double>(); //USD
        private List<double> szterlingPound = new List<double>(); //GBP

        public CurrencyInMemory()
        {
        }

        public override void AddCurrency(string name, double exchangeRate)
        {
            switch (name.ToUpper())
            {
                case "EUR":
                    this.euro.Add(exchangeRate);
                    break;
                case "USD":
                    this.dollar.Add(exchangeRate);
                    break;
                case "GBP":
                    this.szterlingPound.Add(exchangeRate);
                    break;
                default:
                    throw new Exception("Incorrect name");
            }
        }

        public override Statistics GetDollarStatistics()
        {
            var statistics = new Statistics("USD");

            foreach (var item in this.dollar)
            {
                statistics.AddCurrency(item);
            }

            return statistics;
        }

        public override Statistics GetEuroStatistics()
        {
            var statistics = new Statistics("EUR");

            foreach (var item in this.euro)
            {
                statistics.AddCurrency(item);
            }

            return statistics;
        }

        public override Statistics GetPoundStatistics()
        {
            var statistics = new Statistics("GBP");

            foreach (var item in this.szterlingPound)
            {
                statistics.AddCurrency(item);
            }

            return statistics;
        }

        public void sum()
        {
            Console.WriteLine("euro");
            foreach (var item in euro)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("dolar");
            foreach (var item in dollar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Funt");
            foreach (var item in szterlingPound)
            {
                Console.WriteLine(item);
            }
        }

    }
}

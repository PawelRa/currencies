namespace currencies
{
    public class CurrencyInMemory : CurrencyBase
    {
        private List<double> data = new List<double>();

        public CurrencyInMemory(string name) : base(name) { }

        public override void AddCurrency(double exchangeRate)
        {
            try
            {
                data.Add(Convert.ToDouble(exchangeRate));
            }
            catch { Console.WriteLine("Zła wartość"); }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics(this.Name);

            foreach (var item in data)
            {
                statistics.AddCurrency(item);
            }

            return statistics;
        }
    }
}

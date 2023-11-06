namespace currencies
{
    public abstract class CurrencyBase : ICurrency
    {
        protected CurrencyBase(string name)
        {
            if ((name == "USD") || (name == "EUR") || (name == "GBP"))
            {
                this.Name = name;
            }
            else
            {
                Console.WriteLine("Wrong currency");
            }
        }

        public string Name { get; private set; }

        public abstract void AddCurrency(double exchangeRate);

        public abstract Statistics GetStatistics();
    }
}
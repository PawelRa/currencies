namespace currencies
{
    public abstract class CurrencyBase : ICurrency
    {
        protected CurrencyBase() { }

        public abstract void AddCurrency(string name, double exchangeRate);

        public abstract Statistics GetDollarStatistics();

        public abstract Statistics GetEuroStatistics();

        public abstract Statistics GetPoundStatistics();
    }
}
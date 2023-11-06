namespace currencies
{
    internal interface ICurrency
    {
        string Name { get; }

        void AddCurrency(double exchangeRate);

        Statistics GetStatistics();
    }
}

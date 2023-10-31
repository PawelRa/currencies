namespace currencies
{
    internal interface ICurrency
    {
        void AddCurrency(string name, double exchangeRate);

        Statistics GetEuroStatistics();
        Statistics GetDollarStatistics();
        Statistics GetPoundStatistics();
    }
}

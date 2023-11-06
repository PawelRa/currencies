namespace currencies
{
    public interface ICurrencyInFile
    {
        void AddCurrency(string name, double exchangeRate);
        void DollarFileDelete();
        void EuroFileDelete();
        Statistics GetDollarStatistics();
        Statistics GetEuroStatistics();
        Statistics GetPoundStatistics();
        void PoundFileDelete();
    }
}
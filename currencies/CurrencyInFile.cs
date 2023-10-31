namespace currencies
{
    public class CurrencyInFile : CurrencyBase
    {
        private const string euroFile = "euro.txt";
        private const string dollarFile = "dollar.txt";
        private const string englishPoundFile = "pound.txt";

        public override void AddCurrency(string name, double exchangeRate)
        {
            switch (name.ToUpper())
            {
                case "EUR":
                    using (var euroWriter = File.AppendText(euroFile))
                    {
                        euroWriter.WriteLine(exchangeRate);
                    }
                    break;
                case "USD":
                    using (var dollarWriter = File.AppendText(dollarFile))
                    {
                        dollarWriter.WriteLine(exchangeRate);
                    }
                    break;
                case "GBP":
                    using (var poundWriter = File.AppendText(englishPoundFile))
                    {
                        poundWriter.WriteLine(exchangeRate);
                    }
                    break;
                default:
                    throw new Exception("Incorrect name");
            }
        }

        public override Statistics GetDollarStatistics()
        {
            var statistics = new Statistics("USD");
            if (File.Exists(dollarFile))
            {
                using (var reader = File.OpenText(dollarFile))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = double.Parse(line);
                        statistics.AddCurrency(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }

        public override Statistics GetEuroStatistics()
        {
            var statistics = new Statistics("EUR");
            if (File.Exists(euroFile))
            {
                using (var reader = File.OpenText(euroFile))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = double.Parse(line);
                        statistics.AddCurrency(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }

        public override Statistics GetPoundStatistics()
        {
            var statistics = new Statistics("GBP");
            if (File.Exists(englishPoundFile))
            {
                using (var reader = File.OpenText(englishPoundFile))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = double.Parse(line);
                        statistics.AddCurrency(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }

        public void EuroFileDelete()
        {
            File.Delete(euroFile);
        }

        public void DollarFileDelete()
        {
            File.Delete(dollarFile);
        }

        public void PoundFileDelete()
        {
            File.Delete(englishPoundFile);
        }
    }
}

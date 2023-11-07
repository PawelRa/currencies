namespace currencies
{
    public class CurrencyInFile : CurrencyBase
    {
        private string FileName;

        public CurrencyInFile(string name) : base(name)
        {
            FileName = this.Name + ".TXT";
        }

        public override void AddCurrency(double exchangeRate)
        {

            using (var fileWriter = File.AppendText(FileName))
            {
                fileWriter.WriteLine(exchangeRate);
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics(FileName);
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
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

        public void DeleteFile()
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
        }
    }
}

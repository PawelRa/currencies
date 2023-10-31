namespace currencies
{
    public class Statistics
    {
        public double Min { get; private set; }

        public double Max { get; private set; }

        public double Sum { get; private set; }

        public int Count { get; private set; }

        public string Name { get; private set; }

        public double Average
        {
            get
            {
                return Math.Round(this.Sum / this.Count, 4);
            }
        }

        public Statistics(string name)
        {
            this.Name = name;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Sum = 0;
            this.Count = 0;
        }

        public void AddCurrency(double exchangeRate)
        {
            this.Count++;
            this.Sum += exchangeRate;
            this.Min = Math.Min(this.Min, exchangeRate);
            this.Max = Math.Max(this.Max, exchangeRate);
        }
    }
}

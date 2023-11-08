namespace currencies
{
    public class PrintStatistics
    {
        public PrintStatistics(Statistics euro, Statistics dollar, Statistics pound)
        {
            this.Dollar = dollar;
            this.Euro = euro;
            this.Pound = pound;
        }

        public Statistics Euro { get; private set; }
        public Statistics Dollar { get; private set; }
        public Statistics Pound { get; private set; }

        public void printStat()
        {
            Console.WriteLine("Koniec programu");
            Console.WriteLine();

            if (this.Euro.Count >= 1)
            {
                Console.WriteLine("Podsumowanie kursów EURO");
                Console.WriteLine($"Minimalny kurs = {this.Euro.Min}, maksymalny kurs = {this.Euro.Max}, średni kurs = {this.Euro.Average}");
                Console.WriteLine();
            }

            if (this.Dollar.Count >= 1)
            {
                Console.WriteLine("Podsumowanie kursów USD");
                Console.WriteLine($"Minimalny kurs = {this.Dollar.Min}, maksymalny kurs = {this.Dollar.Max}, średni kurs = {this.Dollar.Average}");
                Console.WriteLine();
            }

            if (this.Pound.Count >= 1)
            {
                Console.WriteLine("Podsumowanie kursów funta brytyjskiego");
                Console.WriteLine($"Minimalny kurs = {this.Pound.Min}, maksymalny kurs = {this.Pound.Max}, średni kurs = {this.Pound.Average}");
            }
        }
    }
}

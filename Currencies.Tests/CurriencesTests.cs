using currencies;

namespace Currencies.Tests
{
    public class CurriencesTests
    {
        [Test]
        public void EuroAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("EUR");
            currencies.AddCurrency(4.58);
            currencies.AddCurrency(4.6);
            currencies.AddCurrency(4.7);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(3, Is.EqualTo(statistics.Count));
        }

        [Test]
        public void DollarAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("USD");
            currencies.AddCurrency(3.23);
            currencies.AddCurrency(3.99);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(2, Is.EqualTo(statistics.Count));
        }

        [Test]
        public void PoundAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("GBP");
            currencies.AddCurrency(5);
            currencies.AddCurrency(5.55);
            currencies.AddCurrency(6);
            currencies.AddCurrency(5.88);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(4, Is.EqualTo(statistics.Count));
        }

        [Test]
        public void EuroAverageTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("EUR");
            currencies.AddCurrency(4);
            currencies.AddCurrency(5);
            currencies.AddCurrency(6);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(5, Is.EqualTo(statistics.Average));
        }

        [Test]
        public void DollarAverageTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("USD");
            currencies.AddCurrency(2);
            currencies.AddCurrency(4);
            currencies.AddCurrency(6);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(4, Is.EqualTo(statistics.Average));
        }

        [Test]
        public void PoundAverageTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("GBP");
            currencies.AddCurrency(2);
            currencies.AddCurrency(4);
            currencies.AddCurrency(6);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(4, Is.EqualTo(statistics.Average));
        }

        [Test]
        public void EuroMinMaxTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("EUR");
            currencies.AddCurrency(2.5885);
            currencies.AddCurrency(3.2542);
            currencies.AddCurrency(4);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(2.5885, Is.EqualTo(statistics.Min));
            Assert.That(4, Is.EqualTo(statistics.Max));
        }

        [Test]
        public void DollarMinMaxTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("USD");
            currencies.AddCurrency(2.5885);
            currencies.AddCurrency(3.2542);
            currencies.AddCurrency(4);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(2.5885, Is.EqualTo(statistics.Min));
            Assert.That(4, Is.EqualTo(statistics.Max));
        }

        [Test]
        public void PoundMinMaxTest()
        {
            //arrange
            var currencies = new CurrencyInMemory("GBP");
            currencies.AddCurrency(3.5885);
            currencies.AddCurrency(3.2542);
            currencies.AddCurrency(4);

            //act
            var statistics = currencies.GetStatistics();

            //assert
            Assert.That(3.2542, Is.EqualTo(statistics.Min));
            Assert.That(4, Is.EqualTo(statistics.Max));
        }
    }
}
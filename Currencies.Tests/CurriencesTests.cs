using currencies;

namespace Currencies.Tests
{
    public class CurriencesTests
    {
        [Test]
        public void EuroAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory();
            currencies.AddCurrency("EUR", 4.58);
            currencies.AddCurrency("EUR", 4.6);
            currencies.AddCurrency("EUR", 4.7);

            //act
            var statistics = currencies.GetEuroStatistics();

            //assert
            Assert.That(3, Is.EqualTo(statistics.Count));
        }

        [Test]
        public void DollarAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory();
            currencies.AddCurrency("USD", 3.23);
            currencies.AddCurrency("USD", 3.99);

            //act
            var statistics = currencies.GetDollarStatistics();

            //assert
            Assert.That(2, Is.EqualTo(statistics.Count));
        }

        [Test]
        public void PoundAddTest()
        {
            //arrange
            var currencies = new CurrencyInMemory();
            currencies.AddCurrency("GBP", 5);
            currencies.AddCurrency("GBP", 5.55);
            currencies.AddCurrency("GBP", 6);
            currencies.AddCurrency("GBP", 5.88);

            //act
            var statistics = currencies.GetPoundStatistics();

            //assert
            Assert.That(4, Is.EqualTo(statistics.Count));
        }

    }
}
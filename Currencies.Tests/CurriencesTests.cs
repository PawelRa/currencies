//using currencies;

//namespace Currencies.Tests
//{
//    public class CurriencesTests
//    {
//        [Test]
//        public void EuroAddTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("EUR", 4.58);
//            currencies.AddCurrency("EUR", 4.6);
//            currencies.AddCurrency("EUR", 4.7);

//            //act
//            var statistics = currencies.GetEuroStatistics();

//            //assert
//            Assert.That(3, Is.EqualTo(statistics.Count));
//        }

//        [Test]
//        public void DollarAddTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("USD", 3.23);
//            currencies.AddCurrency("USD", 3.99);

//            //act
//            var statistics = currencies.GetDollarStatistics();

//            //assert
//            Assert.That(2, Is.EqualTo(statistics.Count));
//        }

//        [Test]
//        public void PoundAddTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("GBP", 5);
//            currencies.AddCurrency("GBP", 5.55);
//            currencies.AddCurrency("GBP", 6);
//            currencies.AddCurrency("GBP", 5.88);

//            //act
//            var statistics = currencies.GetPoundStatistics();

//            //assert
//            Assert.That(4, Is.EqualTo(statistics.Count));
//        }

//        [Test]
//        public void EuroAverageTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("EUR", 4);
//            currencies.AddCurrency("EUR", 5);
//            currencies.AddCurrency("EUR", 6);

//            //act
//            var statistics = currencies.GetEuroStatistics();

//            //assert
//            Assert.That(5, Is.EqualTo(statistics.Average));
//        }

//        [Test]
//        public void DollarAverageTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("USD", 2);
//            currencies.AddCurrency("USD", 4);
//            currencies.AddCurrency("USD", 6);

//            //act
//            var statistics = currencies.GetDollarStatistics();

//            //assert
//            Assert.That(4, Is.EqualTo(statistics.Average));
//        }

//        [Test]
//        public void PoundAverageTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("GBP", 2);
//            currencies.AddCurrency("GBP", 4);
//            currencies.AddCurrency("GBP", 6);

//            //act
//            var statistics = currencies.GetPoundStatistics();

//            //assert
//            Assert.That(4, Is.EqualTo(statistics.Average));
//        }

//        [Test]
//        public void EuroMinMaxTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("EUR", 2.5885);
//            currencies.AddCurrency("EUR", 3.2542);
//            currencies.AddCurrency("EUR", 4);
//            currencies.AddCurrency("GBP", 1);

//            //act
//            var statistics = currencies.GetEuroStatistics();

//            //assert
//            Assert.That(2.5885, Is.EqualTo(statistics.Min));
//            Assert.That(4, Is.EqualTo(statistics.Max));
//        }

//        [Test]
//        public void DollarMinMaxTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("USD", 2.5885);
//            currencies.AddCurrency("USD", 3.2542);
//            currencies.AddCurrency("USD", 4);
//            currencies.AddCurrency("GBP", 1);

//            //act
//            var statistics = currencies.GetDollarStatistics();

//            //assert
//            Assert.That(2.5885, Is.EqualTo(statistics.Min));
//            Assert.That(4, Is.EqualTo(statistics.Max));
//        }

//        [Test]
//        public void PoundMinMaxTest()
//        {
//            //arrange
//            var currencies = new CurrencyInMemory();
//            currencies.AddCurrency("GBP", 3.5885);
//            currencies.AddCurrency("GBP", 3.2542);
//            currencies.AddCurrency("GBP", 4);
//            currencies.AddCurrency("USD", 2.5885);

//            //act
//            var statistics = currencies.GetPoundStatistics();

//            //assert
//            Assert.That(3.2542, Is.EqualTo(statistics.Min));
//            Assert.That(4, Is.EqualTo(statistics.Max));
//        }
//    }
//}
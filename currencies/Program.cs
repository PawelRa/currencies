using currencies;

Console.WriteLine("Witamy w programie do analizy kursu walut");
Console.WriteLine("========================================");
Console.WriteLine();

var currencies = new CurrencyInMemory();

currencies.AddCurrency("EUR",4.58);
currencies.AddCurrency("EUR", 4.6);
currencies.AddCurrency("EUR", 4.7);
currencies.AddCurrency("USD",1);
currencies.AddCurrency("USD",2);
currencies.AddCurrency("GBP",1);
currencies.AddCurrency("Gbp",4);

//currencies.sum();

var statistics = currencies.GetEuroStatistics();

Console.WriteLine(statistics.Min);
Console.WriteLine(statistics.Count);


var testpliku = new CurrencyInFile();


testpliku.AddCurrency("EUR", 4.58);
testpliku.AddCurrency("EUR", 4.6);
testpliku.AddCurrency("EUR", 4.7);
testpliku.AddCurrency("usd", 1.1);
testpliku.AddCurrency("UsD", 2.1);
testpliku.AddCurrency("UsD", 3.1);
testpliku.AddCurrency("GBP", 1);
testpliku.AddCurrency("Gbp", 4);

var statystykiPliku = testpliku.GetDollarStatistics();

Console.WriteLine($"srednia pliku = {statystykiPliku.Average}");


using currencies;

Console.WriteLine("Witamy w programie do analizy kursu walut");
Console.WriteLine("========================================");
Console.WriteLine();

Console.WriteLine("Wciśnij 'C' by kontynuować wpisywanie danych do pliku lub przejdź dalej");

var currencyInFile = new CurrencyInFile();
bool firstStepInMemory = false;

if (Console.ReadLine().ToUpper() != "C")
{
    Console.WriteLine("Wybierz metodę przechowywania danych");
    Console.WriteLine("Pamięć wciśnij 'P' lub dowolny klawisz dla zapisu na dysku");
    string firstStep = Console.ReadLine().ToUpper();

    if (firstStep == "P")
    {
        firstStepInMemory = true;
    }

    WhileCurrencies(firstStepInMemory);
}
else
{
    //TODO: kontynuacja zapisu do pliku 
    WhileCurrencies(firstStepInMemory);

}

void WhileCurrencies(bool choice)
{
    if (choice == true)
    {
        var currencies = new CurrencyInMemory();
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Wybierz walutę");
            Console.WriteLine("EURO wybierz 'E', Dolar wybierz 'D', Funt szterling wybierz 'F'. Wyjście dowolny klawisz");

            string currenciesChoice = Console.ReadLine().ToUpper();
            if (currenciesChoice != "E" && currenciesChoice != "D" && currenciesChoice != "F")
            {
                continueProgram = false;
                break;
            }
            else
            {
                string actualCurrency = "";

                switch (currenciesChoice)
                {
                    case "D":
                        actualCurrency = "USD";
                        break;
                    case "E":
                        actualCurrency = "EUR";
                        break;
                    case "F":
                        actualCurrency = "GBP";
                        break;
                }

                while (continueProgram)
                {
                    Console.WriteLine("Wpisz aktualny kurs, wciśnij 'Z' by zmienić walutę lub 'Q' by wyjść");
                    string tempValue = Console.ReadLine();

                    if (tempValue.ToUpper() == "Z") { break; }

                    if (tempValue.ToUpper() == "Q")
                    {
                        continueProgram = false;
                        break;
                    }

                    double value = 0;
                    try
                    {
                        value = Convert.ToDouble(tempValue);
                    }
                    catch { Console.WriteLine("Zła wartość"); }

                    currencies.AddCurrency(actualCurrency, value);
                }
            }
        }

        var euroStatistics = currencies.GetEuroStatistics();
        var dollarStatistics = currencies.GetDollarStatistics();
        var poundStatistics = currencies.GetPoundStatistics();

        Console.WriteLine();
        if (euroStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów EURO");
            Console.WriteLine($"Minimalny kurs = {euroStatistics.Min}, maksymalny kurs = {euroStatistics.Max}, średni kurs = {euroStatistics.Average}");
            Console.WriteLine();
        }

        if (dollarStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów USD");
            Console.WriteLine($"Minimalny kurs = {dollarStatistics.Min}, maksymalny kurs = {dollarStatistics.Max}, średni kurs = {dollarStatistics.Average}");
            Console.WriteLine();
        }

        if (poundStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów funta brytyjskiego");
            Console.WriteLine($"Minimalny kurs = {poundStatistics.Min}, maksymalny kurs = {poundStatistics.Max}, średni kurs = {poundStatistics.Average}");
        }
    }
    else
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Wybierz walutę");
            Console.WriteLine("EURO wybierz 'E', Dolar wybierz 'D', Funt szterling wybierz 'F'. Wyjście dowolny klawisz");

            string currenciesChoice = Console.ReadLine().ToUpper();
            if (currenciesChoice != "E" && currenciesChoice != "D" && currenciesChoice != "F")
            {
                continueProgram = false;
                break;
            }
            else
            {
                string actualCurrency = "";

                switch (currenciesChoice)
                {
                    case "D":
                        actualCurrency = "USD";
                        break;
                    case "E":
                        actualCurrency = "EUR";
                        break;
                    case "F":
                        actualCurrency = "GBP";
                        break;
                }

                while (continueProgram)
                {
                    Console.WriteLine("Wpisz aktualny kurs, wciśnij 'Z' by zmienić walutę lub 'Q' by wyjść");
                    string tempValue = Console.ReadLine();

                    if (tempValue.ToUpper() == "Z") { break; }

                    if (tempValue.ToUpper() == "Q")
                    {
                        continueProgram = false;
                        break;
                    }

                    double value = 0;
                    try
                    {
                        value = Convert.ToDouble(tempValue);
                    }
                    catch { Console.WriteLine("Zła wartość"); }

                    currencyInFile.AddCurrency(actualCurrency, value);
                }
            }
        }

        var euroStatistics = currencyInFile.GetEuroStatistics();
        var dollarStatistics = currencyInFile.GetDollarStatistics();
        var poundStatistics = currencyInFile.GetPoundStatistics();

        Console.WriteLine();
        if (euroStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów EURO");
            Console.WriteLine($"Minimalny kurs = {euroStatistics.Min}, maksymalny kurs = {euroStatistics.Max}, średni kurs = {euroStatistics.Average}");
            Console.WriteLine();
        }

        if (dollarStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów USD");
            Console.WriteLine($"Minimalny kurs = {dollarStatistics.Min}, maksymalny kurs = {dollarStatistics.Max}, średni kurs = {dollarStatistics.Average}");
            Console.WriteLine();
        }

        if (poundStatistics.Count >= 1)
        {
            Console.WriteLine("Podsumowanie kursów funta brytyjskiego");
            Console.WriteLine($"Minimalny kurs = {poundStatistics.Min}, maksymalny kurs = {poundStatistics.Max}, średni kurs = {poundStatistics.Average}");
        }
    }
}





//currencies.AddCurrency("EUR", 4.58);
//currencies.AddCurrency("EUR", 4.6);
//currencies.AddCurrency("EUR", 4.7);
//currencies.AddCurrency("USD", 1);
//currencies.AddCurrency("USD", 2);
//currencies.AddCurrency("GBP", 1);
//currencies.AddCurrency("Gbp", 4);

//currencies.sum();

//var statistics = currencies.GetEuroStatistics();

//Console.WriteLine(statistics.Min);
//Console.WriteLine(statistics.Count);


//var testpliku = new CurrencyInFile();


//testpliku.AddCurrency("EUR", 4.58);
//testpliku.AddCurrency("EUR", 4.6);
//testpliku.AddCurrency("EUR", 4.7);
//testpliku.AddCurrency("usd", 1.1);
//testpliku.AddCurrency("UsD", 2.1);
//testpliku.AddCurrency("UsD", 3.1);
//testpliku.AddCurrency("GBP", 1);
//testpliku.AddCurrency("Gbp", 4);

//var statystykiPliku = testpliku.GetDollarStatistics();

//Console.WriteLine($"srednia pliku = {statystykiPliku.Average}");


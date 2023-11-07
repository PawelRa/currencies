using currencies;

Console.WriteLine("Witamy w programie do analizy kursu walut");
Console.WriteLine("========================================");
Console.WriteLine();

bool firstStepInMemory = false;

Console.WriteLine("Wybierz metodę przechowywania danych");
Console.WriteLine("Pamięć wciśnij 'P' lub dowolny klawisz dla zapisu na dysku");
string firstStep = Console.ReadLine().ToUpper();
bool continueProgram = true;

CurrencyInFile euroInFile = new CurrencyInFile("EUR");
CurrencyInFile dollarInFile = new CurrencyInFile("USD");
CurrencyInFile poundInFile = new CurrencyInFile("GBP");

if (firstStep == "P")
{
    //TODO: obsługa zapisu w pamięci
    firstStepInMemory = true;
    WhileCurrencies(firstStepInMemory);
}
else
{
    //TODO: Obsługa zapisu do plików
    Console.WriteLine("Jeżeli chcesz skasować pliki z danymi wybierz 'R'");
    string deleteFile = Console.ReadLine();

    if (deleteFile.ToUpper() == "R")
    {
        //TODO: obsługa kasowania pliku
        euroInFile.DeleteFile();
        dollarInFile.DeleteFile();
        poundInFile.DeleteFile();
    }
    WhileCurrencies(firstStepInMemory);
}



void WhileCurrencies(bool choice)
{
    if (choice)
    {
        //TODO: Obsługa programu w pamięci
        CurrencyInMemory euroCurrencies = new CurrencyInMemory("EUR");
        CurrencyInMemory dollarCurrencies = new CurrencyInMemory("USD");
        CurrencyInMemory poundCurrencies = new CurrencyInMemory("GBP");

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

                    if (currenciesChoice == "E")
                    {
                        euroCurrencies.AddCurrency(value);
                    }
                    else if (currenciesChoice == "D")
                    {
                        dollarCurrencies.AddCurrency(value);
                    }
                    else if (currenciesChoice == "F")
                    {
                        poundCurrencies.AddCurrency(value);
                    }
                }
            }
        }

        var euroStatistics = euroCurrencies.GetStatistics();
        var dollarStatistics = dollarCurrencies.GetStatistics();
        var poundStatistics = poundCurrencies.GetStatistics();

        Console.WriteLine("Koniec programu");
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
        //TODO: Obsługa programu na plikach
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

                    if (currenciesChoice == "E")
                    {
                        euroInFile.AddCurrency(value);
                    }
                    else if (currenciesChoice == "D")
                    {
                        dollarInFile.AddCurrency(value);
                    }
                    else if (currenciesChoice == "F")
                    {
                        poundInFile.AddCurrency(value);
                    }
                }
            }
        }

        var euroStatistics = euroInFile.GetStatistics();
        var dollarStatistics = dollarInFile.GetStatistics();
        var poundStatistics = poundInFile.GetStatistics();

        Console.WriteLine("Koniec programu");
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


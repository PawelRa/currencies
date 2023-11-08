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
    firstStepInMemory = true;
    WhileCurrencies(firstStepInMemory);
}
else
{
    Console.WriteLine("Jeżeli chcesz skasować pliki z danymi wybierz 'R'");
    string deleteFile = Console.ReadLine();

    if (deleteFile.ToUpper() == "R")
    {
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

        var result = new PrintStatistics(euroCurrencies.GetStatistics(), dollarCurrencies.GetStatistics(), poundCurrencies.GetStatistics());
        result.printStat();
    }
    else
    {
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

        var result = new PrintStatistics(euroInFile.GetStatistics(), dollarInFile.GetStatistics(), poundInFile.GetStatistics());
        result.printStat();
    }
}

using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using System;


var sqlcountriesCurrenciesRepository = new SqlRepository<CountriesCurrencies>(new MotoAppDbContext());
var sqlpreciousMetalsRepository = new SqlRepository<PreciousMetals>(new MotoAppDbContext());

AddCountriesCurrencies(sqlcountriesCurrenciesRepository);
WriteAllToConsole(sqlcountriesCurrenciesRepository);

AddPreciousMetals(sqlpreciousMetalsRepository);
WriteAllToConsole(sqlpreciousMetalsRepository);

static void AddCountriesCurrencies(IRepository<CountriesCurrencies> sqlcountriesCurrenciesRepository)
{
    Console.WriteLine("Program Obliczający kursy różnych walut na złotówki");

    Console.WriteLine("Podaj Wartość Kursu Waluty:  EURO - Unia Europejska");
    var calculation = Console.ReadLine();

    if (double.TryParse(calculation, out double calculation1))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś niewłaściwa wartość");
    }

    const double euro = 1.00d;
    double zł = Math.Round(calculation1 / euro, 4);
    Console.WriteLine("{0} euro = {1} zł", euro, zł);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (EURO - Unia Europejska)", variableCurrenciesMetal = zł });

    Console.WriteLine("Podaj Wartość Waluty: Dolar Amerykański USD");
    var calculation2 = Console.ReadLine();

    if (double.TryParse(calculation2, out double calculation2b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double DolarAmerykański = 1.00d;
    double zł2 = Math.Round(calculation2b / DolarAmerykański, 4);
    Console.WriteLine("{0} Dolar Amerykański = {1} zł", DolarAmerykański, zł2);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Dolar Amerykański)", variableCurrenciesMetal = zł2 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Dolar Kanadyjski (CAD)");
    var calculation3 = (Console.ReadLine());
    if (double.TryParse(calculation3, out double calculation3b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    double dolarKana = 1.00d;
    double zł3 = Math.Round(calculation3b / dolarKana, 4);
    Console.WriteLine("{0} DolarKanadyjski = {1} zł", dolarKana, zł3);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Dolar Kanadyjski (CAD))", variableCurrenciesMetal = zł3 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Dolar Australijski (AUD)");

    var calculation4 = Console.ReadLine();
    if (double.TryParse(calculation4, out double calculation4b))
    {
    }
    else
    {
        Console.WriteLine("Anulowałeś lub Niewłaściwa wartość");
    }
    const double dolarAustra = 1.00d;
    double zł4 = Math.Round(calculation4b / dolarAustra, 4);
    Console.WriteLine("{0} DolarAustralijski = {1} zł", dolarAustra, zł4);

    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Dolar Australijski (AUD)", variableCurrenciesMetal = zł4 });

    
    Console.WriteLine("Podaj Wartość Kursu Waluty: Funt Szterling Wielka Brytania (GBP)");
    var calculation5 = Console.ReadLine();

    if (double.TryParse(calculation5, out double calculation5b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double funtSzterlingBrytyjski = 1.00d;
    double zł5 = Math.Round(calculation5b / funtSzterlingBrytyjski, 4);
    Console.WriteLine("{0} Funt Szterling Wielka Brytania = {1} zł", funtSzterlingBrytyjski, zł5);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Funt Szterling Wielka Brytania (GBP)", variableCurrenciesMetal = zł5 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Frank Szwajcarski (CHF)");
    var calculation6 = Console.ReadLine();

    if (double.TryParse(calculation6, out double calculation6b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double frankSzwajcarski = 1.00d;
    double zł6 = Math.Round(calculation6b / frankSzwajcarski, 4);
    Console.WriteLine("{0} Frank Szwajcarski = {1} zł", frankSzwajcarski, zł6);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Frank Szwajcarski (CHF))", variableCurrenciesMetal = zł6 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Czeska (CZK)");
    var calculation7 = Console.ReadLine();

    if (double.TryParse(calculation7, out double calculation7b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double koronaCzeska = 1.00d;
    double zł7 = Math.Round(calculation7b / koronaCzeska, 4);
    Console.WriteLine("{0} Korona Czeska = {1} zł", koronaCzeska, zł7);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Korona Czeska (CZK))", variableCurrenciesMetal = zł7 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Duńska (DKK)");
    var calculation8 = Console.ReadLine();

    if (double.TryParse(calculation8, out double calculation8b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double koronaDuńska = 1.00d;
    double zł8 = Math.Round(calculation8b / koronaDuńska, 4);
    Console.WriteLine("{0} Korona Duńska = {1} zł", koronaDuńska, zł8);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Korona Duńska (DKK))", variableCurrenciesMetal = zł8 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Norweska (NOK)");
    var calculation9 = Console.ReadLine();

    if (double.TryParse(calculation9, out double calculation9b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double koronaNorweska = 1.00d;
    double zł9 = Math.Round(calculation9b / koronaNorweska, 4);
    Console.WriteLine("{0} Korona Norweska = {1} zł", koronaNorweska, zł9);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Korona Norweska (NOK))", variableCurrenciesMetal = zł9 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Szwedzka (SEK)");
    var calculation10 = Console.ReadLine();

    if (double.TryParse(calculation10, out double calculation10b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double koronaSzwedzka = 1.00d;
    double zł10 = Math.Round(calculation10b / koronaSzwedzka, 4);
    Console.WriteLine("{0} Korona Szwedzka = {1} zł", koronaSzwedzka, zł10);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Korona Szwedzka (SEK))", variableCurrenciesMetal = zł10 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Forint Węgry (HUF)");
    var calculation11 = Console.ReadLine();

    if (double.TryParse(calculation11, out double calculation11b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double forintWęgry = 1.00d;
    double zł11 = Math.Round(calculation11b / forintWęgry, 4);
    Console.WriteLine("{0} Forint Węgry = {1} zł", forintWęgry, zł11);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Forint Węgry (HUF))", variableCurrenciesMetal = zł11 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: lew Bułgaria (BGN)");
    var calculation12 = Console.ReadLine();

    if (double.TryParse(calculation12, out double calculation12b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double lewBułgaria = 1.00d;
    double zł12 = Math.Round(calculation12b / lewBułgaria, 4);
    Console.WriteLine("{0} lewBułgaria = {1} zł", lewBułgaria, zł12);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (lew Bułgaria (BGN))", variableCurrenciesMetal = zł12 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Hrywna Ukraina (UAH)");
    var calculation13 = Console.ReadLine();

    if (double.TryParse(calculation13, out double calculation13b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double hrywnaUkraina = 1.00d;
    double zł13 = Math.Round(calculation13b / hrywnaUkraina, 4);
    Console.WriteLine("{0} Hrywna Ukraina = {1} zł", hrywnaUkraina, zł13);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Hrywna Ukraina (UAH))", variableCurrenciesMetal = zł13 });

    Console.WriteLine("Podaj Wartość Kursu Kursu Waluty: lej Rumuński (RON)");
    var calculation14 = Console.ReadLine();

    if (double.TryParse(calculation14, out double calculation14b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double lejRumuński = 1.00d;
    double zł14 = Math.Round(calculation14b / lejRumuński, 4);
    Console.WriteLine("{0} lej Rumuński = {1} zł", lejRumuński, zł14);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (lej Rumuński (RON))", variableCurrenciesMetal = zł14 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Jen Japonia (JPY)");
    var calculation15 = Console.ReadLine();

    if (double.TryParse(calculation15, out double calculation15b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double jenJaponia = 1.00d;
    double zł15 = Math.Round(calculation15b / jenJaponia, 4);
    Console.WriteLine("{0} Jen Japonia = {1} zł", jenJaponia, zł15);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (Jen Japonia (JPY))", variableCurrenciesMetal = zł15 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: yuan renmimbi Chiny (CNY)");
    var calculation16 = Console.ReadLine();

    if (double.TryParse(calculation16, out double calculation16b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    const double yuanrenmimbiChiny = 1.00d;
    double zł16 = Math.Round(calculation16b / yuanrenmimbiChiny, 4);
    Console.WriteLine("{0} yuan renmimbi Chiny = {1} zł", yuanrenmimbiChiny, zł16);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (yuan renmimbi Chiny (CNY))", variableCurrenciesMetal = zł16 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: lira Turecka (TRY)");
    var calculation17 = Console.ReadLine();

    if (double.TryParse(calculation17, out double calculation17b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    const double liraTurecka = 1.00d;
    double zł17 = Math.Round(calculation17b / liraTurecka, 4);
    Console.WriteLine("{0} lira Turecka = {1} zł", liraTurecka, zł17);
    sqlcountriesCurrenciesRepository.Add(new CountriesCurrencies { FirstName = " (lira Turecka (TRY))", variableCurrenciesMetal = zł17 });

    sqlcountriesCurrenciesRepository.Save();
}

static void AddPreciousMetals(IRepository<PreciousMetals> sqlpreciousMetalsRepository)
{
    Console.WriteLine("Podaj Wartość Złota: Złota Sztabka: 5-50g");
    var calculation18 = Console.ReadLine();

    if (double.TryParse(calculation18, out double calculation18b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }
    double zł18 = calculation18b;

    sqlpreciousMetalsRepository.Add(new PreciousMetals { FirstName = " Złota Sztabka: 5-50g", variableCurrenciesMetal = zł18 });

    Console.WriteLine("Podaj Wartość Złota: Złota Moneta 1-3 11g");
    var calculation19 = Console.ReadLine();

    if (double.TryParse(calculation19, out double calculation19b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    double zł19 = calculation19b;
    sqlpreciousMetalsRepository.Add(new PreciousMetals { FirstName = " (Złota Moneta: 1-3 11g)", variableCurrenciesMetal = zł19 });

    Console.WriteLine("Podaj Wartość Srebra:");
    var calculation20 = Console.ReadLine();

    if (double.TryParse(calculation20, out double calculation20b))
    {

    }
    else
    {
        Console.WriteLine("Anulowałeś lub Podałeś Niewłaściwa wartość");
    }

    double zł20 = calculation20b;
    sqlpreciousMetalsRepository.Add(new PreciousMetals { FirstName = " (Srebrna Sztabka: 1g)", variableCurrenciesMetal = zł20 });

    sqlpreciousMetalsRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
        var items = repository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
}

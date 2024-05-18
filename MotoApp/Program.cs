using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using System;


var sqlwalutyPanstwRepository = new SqlRepository<WalutyPanstw>(new MotoAppDbContext());
var sqlmetaleSzlachetneRepository = new SqlRepository<MetaleSzlachetne>(new MotoAppDbContext());

AddWalutyPanstw(sqlwalutyPanstwRepository);
WriteAllToConsole(sqlwalutyPanstwRepository);

AddMetaleSzlachetne(sqlmetaleSzlachetneRepository);
WriteAllToConsole(sqlmetaleSzlachetneRepository);


static void AddWalutyPanstw(IRepository<WalutyPanstw> walutyPanstwRepository)
{
    Console.WriteLine("Program Obliczający kursy różnych walut na złotówki");

    Console.WriteLine("Podaj Wartość Kursu Waluty:  EURO - Unia Europejska");
    var przelicznik = Console.ReadLine();

    if (double.TryParse(przelicznik, out double przelicznik1))
    {

    }
    else
    {
        Console.WriteLine("Podałeś niewłaściwa wartość");
    }

    const double euro = 1.00d;
    double zł = Math.Round(przelicznik1 / euro, 2);
    Console.WriteLine("{0} euro = {1} zł", euro, zł);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (EURO - Unia Europejska)", zmiennaWalutiMetali = zł });

    Console.WriteLine("Podaj Wartość Waluty: Dolar Amerykański USD");
    var przelicznik2 = Console.ReadLine();

    if (double.TryParse(przelicznik2, out double przelicznik2b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double DolarAmerykański = 1.00d;
    double zł2 = Math.Round(przelicznik2b / DolarAmerykański, 2);
    Console.WriteLine("{0} Dolar Amerykański = {1} zł", DolarAmerykański, zł2);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Dolar Amerykański)", zmiennaWalutiMetali = zł2 });

    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    
    Console.WriteLine("Podaj Wartość Kursu Waluty: Dolar Kanadyjski (CAD)");
    var przelicznik3 = (Console.ReadLine());
    if (double.TryParse(przelicznik3, out double przelicznik3b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    double dolarKana = 1.00d;
    double zł3 = Math.Round(przelicznik3b / dolarKana, 2);
    Console.WriteLine("{0} DolarKanadyjski = {1} zł", dolarKana, zł3);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Dolar Kanadyjski (CAD))", zmiennaWalutiMetali = zł3 });


    // xxxxxxxxxxxxxxx
    Console.WriteLine("Podaj Wartość Kursu Waluty: Dolar Australijski (AUD)");

    var przelicznik4 = Console.ReadLine();
    if (double.TryParse(przelicznik4, out double przelicznik4b))
    {
    }
    else
    {
        Console.WriteLine("Niewłaściwa wartość");
    }
    const double dolarAustra = 1.00d;
    double zł4 = Math.Round(przelicznik4b / dolarAustra, 2);
    Console.WriteLine("{0} DolarAustralijski = {1} zł", dolarAustra, zł4);

    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Dolar Australijski (AUD)", zmiennaWalutiMetali = zł4 });

    
    Console.WriteLine("Podaj Wartość Kursu Waluty: Funt Szterling Wielka Brytania (GBP)");
    var przelicznik5 = Console.ReadLine();

    if (double.TryParse(przelicznik5, out double przelicznik5b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double funtSzterlingBrytyjski = 1.00d;
    double zł5 = Math.Round(przelicznik5b / funtSzterlingBrytyjski, 2);
    Console.WriteLine("{0} Funt Szterling Wielka Brytania = {1} zł", funtSzterlingBrytyjski, zł5);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Funt Szterling Wielka Brytania (GBP)", zmiennaWalutiMetali = zł5 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Frank Szwajcarski (CHF)");
    var przelicznik6 = Console.ReadLine();

    if (double.TryParse(przelicznik6, out double przelicznik6b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double frankSzwajcarski = 1.00d;
    double zł6 = Math.Round(przelicznik6b / frankSzwajcarski, 2);
    Console.WriteLine("{0} Frank Szwajcarski = {1} zł", frankSzwajcarski, zł6);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Frank Szwajcarski (CHF))", zmiennaWalutiMetali = zł6 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Czeska (CZK)");
    var przelicznik7 = Console.ReadLine();

    if (double.TryParse(przelicznik7, out double przelicznik7b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double koronaCzeska = 1.00d;
    double zł7 = Math.Round(przelicznik7b / koronaCzeska, 2);
    Console.WriteLine("{0} Korona Czeska = {1} zł", koronaCzeska, zł7);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Korona Czeska (CZK))", zmiennaWalutiMetali = zł7 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Duńska (DKK)");
    var przelicznik8 = Console.ReadLine();

    if (double.TryParse(przelicznik8, out double przelicznik8b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double koronaDuńska = 1.00d;
    double zł8 = Math.Round(przelicznik8b / koronaDuńska, 2);
    Console.WriteLine("{0} Korona Duńska = {1} zł", koronaDuńska, zł8);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Korona Duńska (DKK))", zmiennaWalutiMetali = zł8 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Norweska (NOK)");
    var przelicznik9 = Console.ReadLine();

    if (double.TryParse(przelicznik9, out double przelicznik9b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double koronaNorweska = 1.00d;
    double zł9 = Math.Round(przelicznik9b / koronaNorweska, 2);
    Console.WriteLine("{0} Korona Norweska = {1} zł", koronaNorweska, zł9);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Korona Norweska (NOK))", zmiennaWalutiMetali = zł9 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Korona Szwedzka (SEK)");
    var przelicznik10 = Console.ReadLine();

    if (double.TryParse(przelicznik10, out double przelicznik10b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double koronaSzwedzka = 1.00d;
    double zł10 = Math.Round(przelicznik10b / koronaSzwedzka, 2);
    Console.WriteLine("{0} Korona Szwedzka = {1} zł", koronaSzwedzka, zł10);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Korona Szwedzka (SEK))", zmiennaWalutiMetali = zł10 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Forint Węgry (HUF)");
    var przelicznik11 = Console.ReadLine();

    if (double.TryParse(przelicznik11, out double przelicznik11b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double forintWęgry = 1.00d;
    double zł11 = Math.Round(przelicznik11b / forintWęgry, 2);
    Console.WriteLine("{0} Forint Węgry = {1} zł", forintWęgry, zł11);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Forint Węgry (HUF))", zmiennaWalutiMetali = zł11 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: lew Bułgaria (BGN)");
    var przelicznik12 = Console.ReadLine();

    if (double.TryParse(przelicznik12, out double przelicznik12b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double lewBułgaria = 1.00d;
    double zł12 = Math.Round(przelicznik12b / lewBułgaria, 2);
    Console.WriteLine("{0} lewBułgaria = {1} zł", lewBułgaria, zł12);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (lew Bułgaria (BGN))", zmiennaWalutiMetali = zł12 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Hrywna Ukraina (UAH)");
    var przelicznik13 = Console.ReadLine();

    if (double.TryParse(przelicznik13, out double przelicznik13b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double hrywnaUkraina = 1.00d;
    double zł13 = Math.Round(przelicznik13b / hrywnaUkraina, 2);
    Console.WriteLine("{0} Hrywna Ukraina = {1} zł", hrywnaUkraina, zł13);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Hrywna Ukraina (UAH))", zmiennaWalutiMetali = zł13 });

    Console.WriteLine("Podaj Wartość Kursu Kursu Waluty: lej Rumuński (RON)");
    var przelicznik14 = Console.ReadLine();

    if (double.TryParse(przelicznik14, out double przelicznik14b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double lejRumuński = 1.00d;
    double zł14 = Math.Round(przelicznik14b / lejRumuński, 2);
    Console.WriteLine("{0} lej Rumuński = {1} zł", lejRumuński, zł14);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (lej Rumuński (RON))", zmiennaWalutiMetali = zł14 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: Jen Japonia (JPY)");
    var przelicznik15 = Console.ReadLine();

    if (double.TryParse(przelicznik15, out double przelicznik15b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double jenJaponia = 1.00d;
    double zł15 = Math.Round(przelicznik15b / jenJaponia, 2);
    Console.WriteLine("{0} Jen Japonia = {1} zł", jenJaponia, zł15);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (Jen Japonia (JPY))", zmiennaWalutiMetali = zł15 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: yuan renmimbi Chiny (CNY)");
    var przelicznik16 = Console.ReadLine();

    if (double.TryParse(przelicznik16, out double przelicznik16b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    const double yuanrenmimbiChiny = 1.00d;
    double zł16 = Math.Round(przelicznik16b / yuanrenmimbiChiny, 2);
    Console.WriteLine("{0} yuan renmimbi Chiny = {1} zł", yuanrenmimbiChiny, zł16);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (yuan renmimbi Chiny (CNY))", zmiennaWalutiMetali = zł16 });

    Console.WriteLine("Podaj Wartość Kursu Waluty: lira Turecka (TRY)");
    var przelicznik17 = Console.ReadLine();

    if (double.TryParse(przelicznik17, out double przelicznik17b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    const double liraTurecka = 1.00d;
    double zł17 = Math.Round(przelicznik17b / liraTurecka, 2);
    Console.WriteLine("{0} lira Turecka = {1} zł", liraTurecka, zł17);
    walutyPanstwRepository.Add(new WalutyPanstw { FirstName = " (lira Turecka (TRY))", zmiennaWalutiMetali = zł17 });
       
    
    walutyPanstwRepository.Save();
}

static void AddMetaleSzlachetne(IRepository<MetaleSzlachetne> employeeRepository)
{
    Console.WriteLine("Podaj Wartość Złota: Złota Sztabka: 5-50g");
    var przelicznik18 = Console.ReadLine();

    if (double.TryParse(przelicznik18, out double przelicznik18b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }
    double zł18 = przelicznik18b;

    employeeRepository.Add(new MetaleSzlachetne { FirstName = " Złota Sztabka: 5-50g", zmiennaWalutiMetali = zł18 });

    Console.WriteLine("Podaj Wartość Złota: Złota Moneta 1-3 11g");
    var przelicznik19 = Console.ReadLine();

    if (double.TryParse(przelicznik19, out double przelicznik19b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    double zł19 = przelicznik19b;
    employeeRepository.Add(new MetaleSzlachetne { FirstName = " (Złota Moneta: 1-3 11g)", zmiennaWalutiMetali = zł19 });

    Console.WriteLine("Podaj Wartość Srebra:");
    var przelicznik20 = Console.ReadLine();

    if (double.TryParse(przelicznik20, out double przelicznik20b))
    {

    }
    else
    {
        Console.WriteLine("Podałeś Niewłaściwa wartość");
    }

    double zł20 = przelicznik20b;
    employeeRepository.Add(new MetaleSzlachetne { FirstName = " (Srebrna Sztabka: 1g)", zmiennaWalutiMetali = zł20 });

    employeeRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
        var items = repository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
}

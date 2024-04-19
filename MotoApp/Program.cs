using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using System;
using System.Collections.Specialized;
using System.Globalization;
//using System;
//using System;

// Zmiany w Kodzie Prog
// KODY w Pliku z LEKCJI 21  - Zmieniony Cały Kod w Pliku
//                           - Zapis Całego Kodu - Zobacz nr 1 Lekcja 21

// KODY w Pliku z LEKCJI 19
//                         - Do Czego Służą INTERFACE
// Opis Lekcja 17
// Zmiany w Kodzie Prog w Pliku Program.cs nowa Wer Wpisu __SqlRepository__ Metody w Klasie 4:00 min
// 


var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext()); //  Lekcja 21
AddEmployees(employeeRepository);
AddMenagers(employeeRepository);
WriteAllToConsole(employeeRepository);


// Używając tej samej generycznej klasy jesteśmy w stanie zadeklarować innym typ danych
//SqlRepository<int> charArray = new SqlRepository<int>(5);
//for (int i = 0; i < 5; i++)
//{
  //  charArray.setGenericValue(i, (char)(i + 97));
//}
static void AddEmployees(IRepository<Employee> employeeRepository)
{

    //------------------------3

    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    //-var input = Console.ReadLine();
    //-employeeRepository.Add(new Employee {num = input()});
    //if (Int32.TryParse(inputString, out int numValue))
    //if (Int32.TryParse( out float num))
    //var input = Console.ReadLine();
    //=  if (input = "q")
    //-{
    // break;
    //-}
    //Console.ReadLine();
    //num = Convert.ToInt32(Console.ReadLine());
    //}
    //-----------------------------3
    //var b = Console.ReadLine();
    //if (float.TryParse(b, out float num))
    //var b = Console.ReadLine();
    //if (float.TryParse(b, out float j))
    //var b = Console.ReadLine();
    //if (float.TryParse(b, out float num))
    //if (float.TryParse(b, out float j))  //--- 2
    //Console.WriteLine("Kurs Waluty - Euro");
    //employeeRepository.Add(new Employee { FirstName = b + "  " + "a" + " (Dolar Amerykański USD)" } );
    // employeeRepository.Add(new Employee { num = num });


    // var b3a = Console.ReadLine();

    //if (b3a == "q")
    //{
    //break;
    //}

    //if (float.TryParse(b3a, out float b3)) < ----------

    //employeeRepository.Add(new Employee { num = b3 });



    //var b3 = 0;
    //var b3 = Calculation();
    //employeeRepository.Calculation();



    //  var input = Console.ReadLine();
    //if (string.TryParse(input1, out char input))
    //      if (input == "q")
    //     {
    //     break;
    //     }

    // switch (input)
    // {
    //     case "A":
    //     case "a":
    //   var input1 = Console.ReadLine();
    //  if (float.TryParse(input1, out float input2))

    //      employeeRepository.Add(new Employee { num = input2 }); 




    //employeeRepository.Add(new Employee { FirstName = " (EURO - Unia Europejska)" + " " });
    //MetodaWpisywaWartości("nazwa");  // - Wywołanie Metody
    //      break;
    // case "B":
    //case "b":
    //MetodaWpisywaWartości("nazwa");  // - Wywołanie Metody
    //   break;
    //  default: //   NOWY WPIS W KODZIE PROGRAMU
    //throw new Exception("Wrong Letter"); // -- > 1b w Pliku Employee.cs
    //this.grades.Add(0);
    //  Console.WriteLine("Wrong Letter");
    //  break;




    //employeeRepository.Add(new Employee { num = b3 });
    //while (true)
    //{
    //var b2b = Console.ReadLine();
    //if (float.TryParse(b2b, out float b2b2))
    //var input = Console.ReadLine();  // <<<<<< ----------------------------------
    //if (float.TryParse(input, out float b2b2))
    //  if (input == "q")
    //{
    //  break;
    //}
    //{

    //}
    //else (input == "q")
    // {
    //   break;
    // }


    //var b3 = Calculation();
    //employeeRepository.Calculation();
    //
    // employeeRepository.Calculation();
    //var input = employeeRepositoryGetAll();
    //
    //var input = Console.ReadLine();

    //employeeRepository.Calculation();
    //var b2b = 2.990f;
    //employeeRepository.Add(new Employee { num = b3 });
    //  employeeRepository.Add(new Employee { num = num });

    //employeeRepository.Add(new Employee { num = b2b });
    //employeeRepository.Add(new Employee { num = num });
    //var b3 = Console.ReadLine();
    //if (float.TryParse(b3, out float b3b))
    Console.WriteLine("Podaj Wartość Kursu Waluty: ");
    //var b2 = Console.ReadLine();
    var przelicznik = double.Parse(Console.ReadLine());
    //if (float.TryParse(euro, out float eurob))
        //var euro = 1;
        //const float przelicznik = prze;
        const double euro = 1.00d;
    double zł = Math.Round(przelicznik / euro, 2);
    //var zł = Math.Round(euro / przelicznik, 2);
    Console.WriteLine("{0} euro = {1} zł", euro, zł);
    //Console.ReadKey();
    employeeRepository.Add(new Employee { FirstName = " (EURO - Unia Europejska)", num = zł });
    //}
    Console.WriteLine("Podaj Wartość Waluty: EURO - Unia Europejska 2x");
    var przelicznik2 = double.Parse(Console.ReadLine());
    //if (float.TryParse(euro, out float eurob))
    //var euro = 1;
    //const float przelicznik = prze;
    const double euro2 = 1.00d;
    double zł2 = Math.Round(przelicznik2 / euro2, 2);
    //var zł = Math.Round(euro / przelicznik, 2);
    Console.WriteLine("{0} euro = {1} zł", euro2, zł2);
    //var b3 = 0;
    //employeeRepository.Calculation();
    //var b3a = Console.ReadLine();
      //  if (double.TryParse(b3a, out double b3))

            employeeRepository.Add(new Employee { FirstName = " (EURO - Unia Europejska)", num = zł2 });

   // WSTAW
        Console.WriteLine("Podaj Wartość Złota: ");
        var b20 = Console.ReadLine();
        if (float.TryParse(b20, out float b20a))
            employeeRepository.Add(new Employee { FirstName = " (Złota Sztabka5-50g))", num = b20a });
        //employeeRepository.Add(new Employee { FirstName = " (Złota Sztabka5-20g)", num = b4 });
        //employeeRepository.Add(new Employee { FirstName = " (Złota Sztabka5-10g)", num = b4 });
        //employeeRepository.Add(new Employee { FirstName = " (Złota Sztabka5-5g)", num = b4 });
        //employeeRepository.Add(new Employee { FirstName = " (Złota Moneta 1/2 uncji)" });
        //employeeRepository.Add(new Employee { FirstName = " (Złota Moneta 1/4 uncji)" });
        Console.WriteLine("Podaj Wartość Złota: ");
        var b21 = Console.ReadLine();
        if (float.TryParse(b21, out float b21a))
            employeeRepository.Add(new Employee { FirstName = " (Złota Moneta 1-3 11g)", num = b21a });

        //employeeRepository.Add(new Employee { FirstName = " (Złota Sztabka5-20g)" });


        //employeeRepository.Add(new Employee { Age = 23 });
        // employeeRepository.Add(2.80f);
        //employeeRepository.Add(new Employee = (Console.ReadLine());
        // var b = Console.ReadLine(); --------------
        //if (Int32.TryParse(b, out int j))
        // if (float.TryParse(b, out float j))  //------------- 2
        employeeRepository.Add(new Employee { num = 2.8088f }); //<<<<<<<<<<<<<<<<<<
                                                                //employeeRepository.Add(new Employee { num = j });
                                                                //employeeRepository.Add(new Employee { num = 29.80f });
                                                                //employeeRepository.Add(new Employee { num = 72.49f });
                                                                //employeeRepository.Add(new Employee { FirstName = "Adam - Euro " });
                                                                //xxxxxxxxxxxx
                                                                //employeeRepository.Add(new Employee { FirstName = "Kurs Waluty - Euro " });  // Wartość Liczbowa
                                                                //var b2 = Console.ReadLine();
                                                                //if (float.TryParse(b2, out float j2))  //--- 
                                                                //   employeeRepository.Add(new Employee { num = j2 });
                                                                //employeeRepository.Add(new Employee { FirstName = "Piotr - Dolar Amerykański" });
                                                                //var b3 = float.Parse(Console.ReadLine());

        //  employeeRepository.Add(new Employee { num = b3 });
        //xxxxxxxxxxxxxxxx
        //employeeRepository.Add(new Employee { FirstName = "Zuzia - Funt Angielski" });
        employeeRepository.Save();
        // employeeRepository.AddItem(2);
        //employeeRepository.AddGrade(2);
    }
//}
    



//var float num;
//List<Employee> employees = new List<Employee>()
//{
//  employeeRepository;
//ListRepository;
//Employee;

//    };
//foreach (var num in nums)
//  {
//   Console.WriteLine(num);
//}
//

//object value = employeeRepository.Additem(5);
//employeeRepository.Additem(9);

static void AddMenagers(IWriteRepository<Menager> menagerRepository)
{
    //menagerRepository.Add(new Menager { Age = 23 });
    menagerRepository.Add(new Menager { FirstName =  "Przemek" });
    //menagerRepository.Add(new Menager { FirstName = "Tomek" });
    menagerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

}

//.........................
// DRUGI SPOSOB ZAPISU

//    // IEnumerable<T> GetAll();  --  Interface IEnumerable - Lekcja 14
//                                  - jest w Pliku  IRepository.cs , IReadRepository

//---------------------
//List<employeeRepository> employeeRepositories = new List<employeeRepository>()
//{
//   employeeRepository
//};
//---------------------

//GetEmployeeById(employeeRepository); // Opis Zobacz nr 3 Lekcja 19

//  OPIS KODU PROG
//   Specjalna Metoda Która Ma IRepository<Employee> od Employee  Lekcja 19
//----------
//static void GetEmployeeById(IRepository<IEntity> employeeRepository)
//{
//    var employee = employeeRepository.GetById(1); // Opis Zobacz nr 2 Lekcja 19
//    var employee1 = employeeRepository.GetById(3);
//   Console.WriteLine(employee.ToString()); // Opis Zobacz nr 2 Lekcja 19 -listowanie
//    Console.WriteLine(employee1.ToString());
//}
// --------------
//var empl = employeeRepository.GetById(1);
//Console.WriteLine(empl.ToString());
//var emp = employeeRepository.GetById(3);
//Console.WriteLine(emp.ToString());


// INFORMACJE


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
// KODY w Plikach z LEKCJI 21

// Opisy Lini Kodów w Programie

// Lekcja 21
// Zmiany w Kodzie Prog           // Opis Zobacz nr 1


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -

// ----------
// INFO WAŻNE

// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
// KODY w Plikach z LEKCJI 19
//          - Zmiany w Kodzie Programu
//          - SqlRepository z Employee i naszym MotoAppDbContext który mamy przygotowany 0:45 sec
//            SqlRepository<Employee>

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2

//  var employee = employeeRepository.GetById(2); // Opis Zobacz nr 2 Lekcja 19

// - specjalną metode która będzie miała w Parametrze
//   IRepository od Employee i dzięki temu możemy na tym w Interface wywołać
//              np. GetById() i go Wylistować przez employee

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 3
//             - // Opis
//                    - Zobacz Notatki nr 1 z Lekcji 19 1:15 min


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -

// KODY w Plikach z LEKCJI 18
//          - Zmiany w Kodzie Programu

// KODY w Plikach z LEKCJI 17
//          - Kod w Liniach Powiazany ze Sobą Miedzy Trzema Plikami
//            Kod w Liniach Musi Być Odpowiednio Dopasowany do Siebie
//            do Kodu w każdym z Trzech Plików 
//            Bo Jak Nie To Są Błędy w Programie
//              - GenericRepository.cs
//              - SqlRepository.cs
//              - Program.cs  
//             


// KODY w Plikach z LEKCJI 16
//          - Kod w Liniach Powiazany ze Sobą Miedzy Trzema Plikami
//            Kod w Liniach Musi Być Odpowiednio Dopasowany do Siebie
//            do Kodu w każdym z Trzech Plików 
//            Bo Jak Nie To Są Błędy w Programie
//              - GenericRepositoryWithRemove.cs
//              - GenericRepository.cs
//              - Program.cs  
//             


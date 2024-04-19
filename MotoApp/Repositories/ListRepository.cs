namespace MotoApp.Repositories;

// KODY w Plikach z LEKCJI 21 - To Samo co w Lekcja 18
// KODY w Plikach z LEKCJI 18

using MotoApp.Entities;
using System;

//using static System.Formats.Asn1.AsnWriter;

//public class ListRepository<T, Tb> : IRepository<T, Tb> where T : class, IEntity, new() // class - Opis Lekcja 11
//  where Tb : struct, IEntity
//where Tb : class, IEntity, new()

public class ListRepository<T> : IRepository<T> where T : class, IEntity, new() // class - Opis Lekcja 11
                                                                                //where Bt : class, IEntity, new()
{

    // class - Opis Lekcja 11
    // Zmiany w Kodzie Prog           // Opis Zobacz nr 1
    // Usuniete rzeczy z Kodu w Pliku  // Opis Zobacz nr 1
    // Usunięty <TKey>
    // Zmieniona Nazwa z TEntity na <T>
    // Powrót do nazwy <T> z TEntity bo jeśli jest 1 Parametr Generyczny
    // To może być nazwa T - <T>
    // <TKey> - Usunięcie Parametru Generycznego <TKey>
    // i został tylko 1 Parametr Generyczny <T>

    // Lekcja 18 
    // Zmiany w Kodzie Prog           // Opis Zobacz nr 1

    //public Tb? Tb { get; set; }   // 2-gi Parametr  <<------------------------  3
   
    private readonly List<T> _items = new();
    private readonly List<double> nums = new();

    //private readonly MyList<T> nums = new();
    //private T[] genericArray;
    //public readonly List<float> nums = new();

    //public readonly List<float> nums2 = new();
    //private readonly List<float> grades = new(); //---------------------------------------


    //public void AddGrade(float grade)
    //{
    //grades.Add(grade);
    //  _grades.Add(grade);
    //} //---------------------------------------

    public IEnumerable<T> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    {
        return _items.ToList();
    }
    //public IEnumerable<T> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
      //  return nums.ToList();
    //}
    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);            // Opis Lini Kodu Zobacz nr 2  Lekcja 18 
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);  // Ad Opis Lini Kodu Zobacz nr 2  Lekcja 18 
                                      //save is not required with List
        }
    }

    public T GetById(int id)  // Ad Opis Lini Kodu w  Lekcja 11
    {
        //return default(T);
        return _items.Single(item => item.Id == id);
        //return _dbSet.Find(id);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    //public IEnumerable<Tb> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
      //  return nums.ToList();
    //}
    public void Calculation()
    {
        //var b2b = 0;
        
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            else if (double.TryParse(input, out double num))
            {
              nums.Add(num);
            }


        }
    }


    //public void Add(string input)  // Parsowanie <<------------------------  1
    //{
      //  if (float.TryParse(input, out float num))
        //{

          //    nums.Add(num);
            //}
            //else
            //{
            //  Console.WriteLine("String is not float");
      //  }
    //}

    public void Add(double num)
    {
        nums.Add(num);
        //throw new NotImplementedException();
    }


    //public IEnumerable<Tb> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
    //  nums.ToList();
    //}

    //<<------------------------

    //public IEnumerable<Tb> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
    //  return nums.ToList();
    //}
    //public void Add(Tb num)
    //{
    //  num = num;
    //nums.Add(num);            // Opis Lini Kodu Zobacz nr 2  Lekcja 18 
    //}

    //public IEnumerable<Tb> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
    //  return nums.ToList();
    //}
    // public void Add(Tb num)
    //{
    //  num.Id = nums.Count + 1;
    //nums.Add(num);            // Opis Lini Kodu Zobacz nr 2  Lekcja 18 
    //}

    //public void Save()
    //{
    //  foreach (var num in nums)
    //{
    //  Console.WriteLine(num);  // Ad Opis Lini Kodu Zobacz nr 2  Lekcja 18 
    //save is not required with List
    //}
    // }

    //public Tb GetById2(float id2)  // Ad Opis Lini Kodu w  Lekcja 11
    //{
    //return default(T);
    //  return nums.Single(num => num.Id2 == id2);
    //return _dbSet.Find(id);
    //}/

    //public void Remove(Tb num)
    //{
    //  nums.Remove(num);
    //}
    //public void Save()
    //{
    //  foreach (var num in nums)
    //{
    //  Console.WriteLine(num);  // Ad Opis Lini Kodu Zobacz nr 2  Lekcja 18 
    //save is not required with List
    //}
    //}


    //public void Calculation()
    //{
    //  throw new NotImplementedException();
    //}
    //public IEnumerable<Tb> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    //{
    //  nums.ToList();
    //}
    //public void Add(Tb num)  // <<------------------------ 2
    //{
    //throw new NotImplementedException();
    //nums.Add(num);

    //}

    //public Tb GetBy(int num)  // Ad Opis Lini Kodu w  Lekcja 11
    //{
    //return default(T);
    //  return nums.Single(num => num == num);
    //return _dbSet.Find(id);
    //}
    //public void Add(Tb num)
    //{
    //throw new NotImplementedException();
    //  nums.Add(num);
    //}

    //public void Remove(Tb num)
    //{
    //  throw new NotImplementedException();
    //}
    //public void Add(float b12)
    // {
    //var num = b12;
    //var Input = Console.ReadLine().ToUpper;
    //switch (Console.ReadLine(num))
    //{
    //  case "a":
    //    Console.WriteLine($" Your Result {num} - {num} = " + (num - num));
    //  break;

    //}
    //}


    //internal void AddNum(string? input)
    //{
    //throw new NotImplementedException();
    //nums.Add(num);
    //}
    //-----------------2
    //public void GetByNum(float num)
    //{
    //return default(T);
    //   nums.Single(num => num == 3.9f);
    //return _dbSet.Find(id);
    //}
    //-----------------2

    }
//.....


//........


// INFORMACJE


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
// KODY w Plikach z LEKCJI 18

// Opisy Lini Kodów w Programie

// Lekcja 18 
// Zmiany w Kodzie Prog           // Opis Zobacz nr 1
//   public IEnumerable<T> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
//   {
//       return _items;
//   }

//   - GetAll() - Użycie w Kodzie  2:40 min

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2
// KODY w Plikach z LEKCJI 18
//   - Opis Działąnia Kodu Prog w Punkcie 4 Lekcja 18

// Opis Lini Kodu Zobacz nr 2 Lekcja 18
// Ad Opis Lini Kodu Zobacz nr 2  Lekcja 18

//-DZIAŁANIE KODU PROGRAMU w Pliku ListRepository.cs 3:30 min
//           - Zobacz Plik Lek 18 GRUPA 2 -1a1 .BMP, Lek 18 GRUPA 2 -1a2 .BMP
//             w Katalogu --- ZZZ KURS ŚREDNI\Z - LEKCJE - GRUPA 2\NOTATKI Z LEKCJI - Pliki BMP
// public void Add(T item)
// {
//     item.Id = _items.Count + 1;
//     _items.Add(item);            // Opis Lini Kodu Zobacz nr 2  Lekcja 18 
// }

// public void Save()
// {
//    foreach (var item in _items)
//    {
//        Console.WriteLine(item);  // Ad Opis Lini Kodu Zobacz nr 2  Lekcja 18 
//                                  // save is not required with List
//    }
// }
// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// KODY w Plikach z LEKCJI 15

// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 15


// Zmiany w Kodziwe Prog           // Opis Zobacz nr 1
// Usuniete rzeczy z Kodu w Pliku  // Opis Zobacz nr 1
// Usunięty <TKey>
// Zmieniona Nazwa z TEntity na <T>
// Powrót do nazwy <T> z TEntity bo jeśli jest 1 Parametr Generyczny
// To może być nazwa T - <T>


// where TKey : struct  // Opis Zobacz nr 1 Lek 15 GRUPA 2     // Usuniety Kod w Pliku
// public TKey? Key { get; set; }                             // Usuniety Kod w Pliku


// KROK 2 - Nowa Metoda Testowa 1:10 min

//  public TEntity CreateNewItem()
//  {
//     return new TEntity();
//  }

// - - - - - - - - - - - - - - - - - - - - - - -

//  INFO WAŻNE
//           - Powiązanie Kodów w Plikach Kody Muszą Być Odpowiednio Dostosowane 
//              a jak nie to Powstaja Błędy
//            - Zobacz w Pliku Program.cs



////////////////////////////////////////////////////////
//POPRZEDNI ZAPIS - Do Wglądu

// INFORMACJE

// KODY w Plikach z LEKCJI 15

//vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv

// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
///// Opis Działania Kodu Lini w GRUPA 2 Lekcja 11
// 
// -NOWE WPISY KODU   0:50 min
//   where TEntity : IEntity        // Opis Lini Kodu Zobacz nr 1 Lek 11 GRUPA 2  0:50 sek
// where TEntity : class, IEntity // Opis Lini Kodu Zobacz nr 1 Lek 11 GRUPA 2  0:50 sek

// return default(TEntity); // 3 Wpis Kodu  nr 1  Lek 11 GRUPA 2  1:40 min
//  return null;  // Opis Lini Kodu Zobacz nr 1 Lek 11 GRUPA 2  0:50 sek
//    return _items.Single(item => item.Id == id);
// - Błąd - usunięcie Błędu  1:00 min

// // Opis Lini Kodu Zobacz nr 1 Lek 11 GRUPA 2  0:50 sek
//private zmiana na protected


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2
//  Działanie Kodu w GRUPA 2 Lekcja 11
//
// return default(TEntity); // 3 Wpis Kodu  nr 1  Lek 11 GRUPA 2  1:40 min
// 
// Definicja
//         - Obsługi Klasy Entity   2:00 min

// - - - - - - - - - - - - - - - - - - - - - - -

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 3
//  Działanie Kodu w GRUPA 2 Lekcja 11
//
//  Drugie Ograniczenie na Klucz TKey  2:15 min
// where TKey : struct   
//            - Mozna wykożystywać takie Typy ktore pod spodem sa Struktu
//

// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr
// if (File.Exists($"{fileName}")) //.Exists Działanie Kodu w GRUPA 2 Lekcja 11
// {fileName} - to ścieżka do pliku w ktorym Prog  0:50 min
// Dniu 16 Lekcja 6  0:50 min
// zapisuje dane - Opis na dole - Zobacz nr 2

// - - - - - - - - - - - - - - - - - - - - - - -
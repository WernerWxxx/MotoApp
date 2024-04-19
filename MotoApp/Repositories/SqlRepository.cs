namespace MotoApp.Repositories;
using MotoApp.Data;
// KODY w Pliku z LEKCJI 21 
// KODY w Plikach z LEKCJI 18 - To Samo w Lekcji 21

using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
//using static System.Formats.Asn1.AsnWriter;

// Opis Lekcja 17
// Zmiany w Kodzie Prog w Pliku Program.cs nowa Wersja Wpisu __SqlRepository__ Metody w Klasie
//  Wpis __SqlRepository__ Kodzie w Pliku Program.cs   Zobacz nr 7

//public class ListRepository<T, Tb> : IRepository<T, Tb> where T : class, IEntity, new() // class - Opis Lekcja 11
//  where Tb : struct, IEntity
//where Tb : class, IEntity, new()

public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
    //private readonly DbSet<Employee> _dbSet; // Opis Dzi Kodu - Działanie na Pracownikach LEKCJA 17 1:00 min
    private readonly DbContext _dbContext;  // Opis Dzi Kodu Potrzebny DbContext; z EntityFrameworkCore LEKCJA 17 1:00 min
    private readonly DbSet<T> _dbSet;       // - wzięte z Dokumentacji EntityFrameworkCore - BAR. WAZNE 1:00 min
    //private int v;

    // -  Opis Działa Kodu - Zobacz nr 1-2
    //private readonly DbContext _dbContext;
    //private readonly DbSet<Tb> _dbSet;
    //private object num;
    //private readonly List<float> nums = new();

    //public ListRepository(DbContext dbContext)
    public SqlRepository(DbContext dbContext) // Konstruktor // Opis Działa Kodu - Zobacz nr 1
    {                                                        // z LEKCJI 17
        _dbContext = dbContext;                  // Opis Lini Kodu Zobacz nr 2 z LEKCJI 17
        _dbSet = _dbContext.Set<T>();
        //DbSet<TEntity> DbContext.Set<TEntity>();        //_dbSet = _dbContext.Set<Employee>();   // Opis Lini Kodu Zobacz nr 2 z LEKCJI 17
    }  //  -  Opis Działa Kodu Wyżej - nr 1-2  2:00 min


    /// ///////////////////////////////
    /// Kod Testowy z Samouczków
    //////////////////////////////////

    //public SqlRepository(int v)
    //{
      //  this.v = v;
    //}

    // - tworzenie Zasobu który przyjdzie w Konstruktorze
    // przypisanie DbContext i DbSet na podstawie DbContextu
    // ..........................................

    //static void Swap<Tb>(ref Tb a, ref Tb b)
    //{
      //  Tb temp;
       // temp = a;
        //a = b;
        //b = temp;
    //}
    /// ///////////////////////////////
    /// Kod Testowy z Samouczków
    //////////////////////////////////


    public IEnumerable<T> GetAll()   // Ad Opis Zobacz nr 1  Lekcja 18 
    {
        //return _dbSet.OrderBy(item => item.Id).ToList();  // Opis Zobacz 4:00 min  Lekcja 18 
        return _dbSet.ToList();
        //return _dbSet.OrderBy(item => item.Id)ToList();
    }
    //public Employee GetById(int id)  // Opis Lini Kodu Zobacz nr 3  z LEKCJI 17  2:10 min
    public T GetById(int id)
    {
        return _dbSet.Find(id);
        //return _items.Find(item => item.Id == id);
    }
    //public void Add(Employee item)  // Opis Lini Kodu Zobacz nr 4 z LEKCJI 17
    public void Add(T item)
    {
        _dbSet.Add(item);
    }
    //public void Remove(Employee item)    // Opis Lini Kodu Zobacz nr 5 z LEKCJI 17
    public void Remove(T item)
    {
        //item.Id = _items.Count + 1;
        _dbSet.Add(item);
    }
    public void Save()   // Opis Lini Kodu Zobacz nr 6 z LEKCJI 17
    {
        _dbContext.SaveChanges();
    }

   

    public void Calculation()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }
            //_dbContext.SaveChanges();

            if (float.TryParse(input, out float inputa));

        }
        //throw new NotImplementedException();
    }
    public void Add(double num)  // <----------------------------- typ float
    {

        //throw new NotImplementedException();
        _dbContext.SaveChanges();
       // nums.Add(num);
        //_dbSet.Add(num);
    }

    // public void Add(Tb num)
    //{
    //throw new NotImplementedException();
    // nums.Add(num);
    //}
    // public void Remove(Tb num)    // Opis Lini Kodu Zobacz nr 5 z LEKCJI 17
    //{
    //item.Id = _items.Count + 1;
    //  _dbSet.Add(num);
    //}
    //public void Add(Tb num)
    //{
    //  throw new NotImplementedException();
    //}

    //public void Remove(Tb num)
    //{
    //   throw new NotImplementedException();
    ///}



    //public void AddGrade(float grade)
    //{
    //  grades.Add(grade);
    //}
    //public void Grade(float grade)  // Opis Lini Kodu Zobacz nr 3  z LEKCJI 17
    //{
    // AddGrade(grade);
    //return _items.Find(item => item.Id == id);
    //}

    //public void Add(float num)
    //{
    //throw new NotImplementedException();
    //List.Add(num);
    //}


}
// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// INFORMACJE
// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -

// KODY w Plikach z LEKCJI 17

// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 17
///        - w Notatkach nr 17 z Filmu Lekcji

//                                      dbContext // < nr - 1
//       public SqlRepository(DbContext dbContext)
//       {
//         _dbContext = dbContext;
//       _dbSet = _dbContext.Set<Employee>();  - tworzenie zasobu na Podstawie kontekstu który
//       }                                       przyjdzie w Konstruktorze " dbContext " // < nr - 1
//                                               1:35 min
//                                             - później Pokazane jak go Przekażemy ten Kontext
//                                             - na razie zrobimy Implementacje  1:50 min

// - - - - - - - - - - - - - - - - - - - - - - -

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 2
//             - w Notatkach nr 17 z Filmu Lekcji

//  Zrobienie Implementacji
//   - Która przypisze nam _dbContext i _dbSet na podstawie _dbContext
//   _dbContext
//   _dbSet

//  KOD PROGRAMU

//     {    v ---  // Opis Lini Kodu Zobacz nr 2
//       _dbContext = dbContext;
//       _dbSet = _dbContext.Set<Employee>();
//     }   ^--- // Opis Lini Kodu Zobacz nr 2

// - - - - - - - - - - - - - - - - - - - - - - -

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 3
//              - w Notatkach nr 17 z Filmu Lekcji

//   3
//   - METODY - Potrzebne Metody w Kodzie Prog w Pliku SqlRepository.cs 2:00 min
//     - GetById - 1 Metoda teraz Operujemy na _dbSet a nie na Liście
//               - to będzie _dbSet który jest w EntityFramework i w Pamięci Przechowywany
//                 Zapisuje Dane

// - - - - - - - - - - - - - - - - - - - - - - -

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 4

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 17
//        - w Notatkach nr 17 z Filmu Lekcji

//  public void Add(Employee item)  // Opis Lini Kodu Zobacz nr 4
//  {
//      _dbSet.Add(item);
//  }
// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 5

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 17
///        - w Notatkach nr 17 z Filmu Lekcji
///        
//   public void Remove(Employee item)    // Opis Lini Kodu Zobacz nr 5
//   {
//item.Id = _items.Count + 1;
//       _dbSet.Add(item);
//   }

// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 6

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 17
//        - w Notatkach nr 17 z Filmu Lekcji

//   public void Save()   // Opis Lini Kodu Zobacz nr 6
//   {
//       _dbContext.SaveChanges();
//   }

//  }
// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 7

///// Opis Działania Kodu Lini w Pliku w GRUPA 2 Lekcja 17
//    // Opis Lekcja 17
// Zmiany w Kodzie Prog w Pliku Program.cs nowa Wersja Wpisu __SqlRepository__ Metody w Klasie
//  Wpis __SqlRepository__ Kodzie w Pliku Program.cs   Zobacz nr 7

// - - - - - - - - - - - - - - - - - - - - - - -


// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 

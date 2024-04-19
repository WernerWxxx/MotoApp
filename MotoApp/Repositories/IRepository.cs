namespace MotoApp.Repositories;

using MotoApp.Entities;

// KODY w Pliku z LEKCJI 21 

//public interface IRepository<T, Tb> : IReadRepository<T, Tb>, IWriteRepository<T, Tb>
//where T : class, IEntity, new()
//where Tb : struct, IEntity

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
  where T : class, IEntity, new() // Opis Zobacz nr 1  Lek 19
                                 // Nowe Wpisy Kodu Zobacz nr 2  Lek 19
                                 // 2 Nowe Pliki w Projekcie
                                 // Opis Zobacz nr 3  Lek 19  - Dziedziczenie
{
    // IEnumerable<T> GetAll();  --  Interface IEnumerable - Lekcja 14
    // T GetById(int id);
    //void Add(T item);
    //void Remove(T item);
    //void Save();
    
}
// < ------------  Wygenerowane za Pomocą Alt + Enter
//public interface IReadRepository<T, Tb>
  //  where T : class, IEntity
    //where Tb : class, IEntity
//{
//}

//public interface IWriteRepository<T, Tb>
  //  where T : class, IEntity
    //where Tb : class, IEntity
//{
//}// < ------------  Wygenerowane za Pomocą Alt + Enter


// INFORMACJE

// KODY w Plikach z LEKCJI 19

// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
// KODY w Plikach z LEKCJI 19
//          - Zmiany w Kodzie Programu
//          - out - nowe Polecenie
//            KOWARIANCJA KONTRAWARIANCJA
//                                out  - Nowy wpis w Kodzie Prog
//   public interface IRepository<out T> where T : class, IEntity


// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 3
// KODY w Plikach z LEKCJI 19

// IRepository<T> - Dziedziczy po 
//                  IReadRepository<T>, IWriteRepository<T>

//  public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
//      where T : class, IEntity

// - - - - - - - - - - - - - - - - - - - - - - -
// - - - - - - - - - - - - - - - - - - - - - - -




// INFO:
//      Plik dodany w Lekcji 18 -:00 min

// INFORMACJE

// KODY w Plikach z LEKCJI 18
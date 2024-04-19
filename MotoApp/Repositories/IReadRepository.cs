namespace MotoApp.Repositories;

using MotoApp.Entities;

// KODY w Pliku z LEKCJI 21 
//public interface IReadRepository<out T, Tb> where T : class, IEntity, new() // Opis Zobacz nr 1  Lek 19
    //where Tb : class, IEntity, new()
  //  where Tb : struct, IEntity//, new()
    public interface IReadRepository<out T> where T : class, IEntity // Opis Zobacz nr 1  Lek 19
                                                                            //where Tb : struct, IEntity
{
    IEnumerable<T> GetAll();    //  Interface IEnumerable - Lekcja 14
    T GetById(int id);
    //T Add(float num);

    void Add(double num);
    //IEnumerable<Tb> GetAll2();    //  Interface IEnumerable - Lekcja 14
    //Tb GetById2(float num);
}

// KODY w Pliku z LEKCJI 21 

// INFO:
//      Plik dodany w Lekcji 19  x:xx min

// 2 Nowe Pliki w Projekcie  Lekcja 19
//                       - IWriteRepository.cs
//                       - IReadRepository.cs

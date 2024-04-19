namespace MotoApp.Repositories;

using MotoApp.Entities;

//public interface IWriteRepository<in T, Tb> where T : class, IEntity, new()
      //where Tb : class, IEntity, new()
    //where Tb : struct, IEntity
public interface IWriteRepository<in T> where T : class, IEntity

{
    void Add(T item);
    //void Add(Tb num);
    void Remove(T item);
    void Save();
    //void Add(float num);
    void Add(double num);
    void Calculation();

    //void Remove(Tb num);
}

public class Tb  // < ------------  Wygenerowane za Pomocą Alt + Enter
{
}

// KODY w Pliku z LEKCJI 21 

// INFO:
//      Plik dodany w Lekcji 19  x:xx min

// 2 Nowe Pliki w Projekcie  Lekcja 19
//                       - IWriteRepository.cs
//                       - IReadRepository.cs

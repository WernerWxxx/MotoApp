using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        double num { get; set; }
        //Tb num { get; set; }
        void Calculation();
    }
}


// KODY w Pliku z LEKCJI 21 

// INFORMACJE

// KODY w Plikach z LEKCJI 10
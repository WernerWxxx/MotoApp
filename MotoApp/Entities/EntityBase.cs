using MotoApp.Repositories;

namespace MotoApp.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public double num { get; set; }
        //Tb IEntity.num { get; set; }
        public void Calculation()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                // if (float.TryParse(b3, out float b3a))

            }
        }
    }
}

// KODY w Pliku z LEKCJI 21 

// INFORMACJE

// KODY w Plikach z LEKCJI 10
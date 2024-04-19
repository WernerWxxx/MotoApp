// INFO:
//      Plik dodany w Lekcji 15 1:00 min

// KODY w Pliku z LEKCJI 21 

namespace MotoApp.Entities
{
    public class BusinessPartner : EntityBase
    {
        //public BusinessPartner()
        //{
        //}

        //public BusinessPartner(string Name)
        //{
        //}
        public string? Name { get; set; }
        //public float? Name2 { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
        //public override float Tofloat() => $"Id: {Id}, Name: {Name2}";
    }
}

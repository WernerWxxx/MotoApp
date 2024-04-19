using MotoApp.Repositories;
using System.Globalization;

namespace MotoApp.Entities
{
    // KODY w Pliku z LEKCJI 21 

    public class Employee : EntityBase
    {

        //public float? Tb { get; set; }

        //public Employee
        public string? FirstName { get; set; }
        //public float? num { get; set; } // - Nie jest potrzebne bo nie ma GENERYCZNOŚCI

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}, numNUM: {num} + (Pracownik) ";
        //public override float ToFloat() => $" Name: {num} + (Pracownik)";
        //public override int ToInt() => $"Id: {Id}, Age: {22} + (Pracownik)";

    }
}

// INFORMACJE

// KODY w Plikach z LEKCJI 12


// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1
//
//   Lekcja 12 GRUPA 2
//  Info że w Pliku Employee.cs jest pusty Konstruktor  1:30 min
// 
//

// - 
// - 
// 
// 
// - 
// 

// - - - - - - - - - - - - - - - - - - - - - - -


// Opisy Lini Kodów w Programie

// - - - - - - - - - - - - - - - - - - - - - - -
// - Zobacz nr 1a
///// Opis Działania Kodu Lini w GRUPA 2 Lekcja 9
// 
// -NOWE WPISY KODU   2:55 min
// protected readonly List<T> _items = new(); // nowy Kod Prog - Lek 9 3:00 mi
//private zmiana na protected

// - 
// - 
// 
// 
// - 
// 

// - - - - - - - - - - - - - - - - - - - - - - -
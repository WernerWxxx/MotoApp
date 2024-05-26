using MotoApp.Repositories;
using System.Globalization;
using System.Diagnostics.Contracts;

namespace MotoApp.Entities
{
    public class CountriesCurrencies : EntityBase
    {
        public string FirstName { get; set; }
        public double variableCurrenciesMetal { get; set; }  // - Poprawki Wpis Kodu

        public override string ToString() => $"Id: {Id}, Name: {FirstName}, Value: {variableCurrenciesMetal} ";
    }
}
using MotoApp.Repositories;
using System.Globalization;
using System.Diagnostics.Contracts;

namespace MotoApp.Entities
{
    public class WalutyPanstw : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {FirstName}, Wartość: {zmiennaWalutiMetali} ";
    }
}
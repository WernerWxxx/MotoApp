using MotoApp.Repositories;
using System.Globalization;

namespace MotoApp.Entities
{
    public class Employee : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {FirstName}, numNUM: {num} ";
    }
}
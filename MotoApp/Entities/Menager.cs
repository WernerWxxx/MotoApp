namespace MotoApp.Entities;

public class Menager : EntityBase
{
    public string? FirstName { get; set; }
    public override string ToString() => $"Id: {Id}, Name: {FirstName}, Wartość: {num} ";
    ////public override string ToString() => base.ToString() + " (Metale Szlachetne)" + $" Wartość: {num}";
}
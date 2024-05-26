namespace MotoApp.Entities;

public class PreciousMetals : EntityBase
{
    public string? FirstName { get; set; }

    public double variableCurrenciesMetal { get; set; }
    public override string ToString() => $"Id: {Id}, Name: {FirstName}, Value: {variableCurrenciesMetal} ";
}
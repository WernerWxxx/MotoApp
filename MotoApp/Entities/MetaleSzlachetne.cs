namespace MotoApp.Entities;

public class MetaleSzlachetne : EntityBase
{
    public string? FirstName { get; set; }
    public override string ToString() => $"Id: {Id}, Name: {FirstName}, Wartość: {zmiennaWalutiMetali} ";

}//
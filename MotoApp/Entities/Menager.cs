namespace MotoApp.Entities;

public class Menager : Employee
{
    public override string ToString() => base.ToString() + " (Metale Szlachetne)" + $" num: {num}";
}
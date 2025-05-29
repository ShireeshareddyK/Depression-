 using System;
namespace CaseStudie1
{

class Laptop
{
    public const double TaxRate = 0.18; // fixed, known at compile time
    public readonly int ManufacturingYear; // assigned at runtime

    public Laptop(int year)
    {
        ManufacturingYear = year;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Tax Rate: {TaxRate}");
        Console.WriteLine($"Manufacturing Year: {ManufacturingYear}");
    }
}

class ConstReadonly
{
    static void Main()
    {
        Laptop laptop = new Laptop(2023);
        laptop.ShowDetails();
    }
}

}
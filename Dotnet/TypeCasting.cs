namespace CaseStudie1
{
    using System;

class TypeCasting
{
    static void Main()
    {
        int amount = 1500;

        double preciseAmount = (double)amount * 1.18; // e.g., adding 18% tax

        int finalAmount = (int)Math.Round(preciseAmount);

        Console.WriteLine("Final Amount: " + finalAmount);
    }
}

}
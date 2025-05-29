namespace CaseStudie1
{

class Customer { }
class PremiumCustomer : Customer
{
    public void ApplyDiscount()
    {
        Console.WriteLine("Discount applied for premium customer.");
    }
}

class AsOperator
{
    static void Main()
    {
        Customer cust = new PremiumCustomer();
        PremiumCustomer premium = cust as PremiumCustomer;

        if (premium != null)
        {
            premium.ApplyDiscount();
        }
        else
        {
            Console.WriteLine("No discount for regular customer.");
        }
    }
}

}
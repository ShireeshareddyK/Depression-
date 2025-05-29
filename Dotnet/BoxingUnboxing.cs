using System;
using System.Collections;
namespace CaseStudie1
{

class BoxingUnboxing
{
    static void Main()
    {
        ArrayList cart = new ArrayList();

       
        cart.Add(100); 
        cart.Add(200); 
        cart.Add(300);

        int total = 0;

        foreach (object item in cart)
        {
           
            total += (int)item;
        }

        Console.WriteLine("Total Price: " + total);
    }
}

}
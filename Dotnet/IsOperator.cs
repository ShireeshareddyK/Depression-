using System;
namespace CaseStudie1{
class Employee { }
class Manager : Employee { }
class Developer : Employee { }
class Intern : Employee { }

class IsOperator
{
    static void Main()
    {
        Employee emp = new Developer();
        //Employee emp=new Intern();
        //Employee emp=new Manager();

        if (emp is Manager)
            Console.WriteLine("Role: Manager");
        else if (emp is Developer)
            Console.WriteLine("Role: Developer");
        else if (emp is Intern)
            Console.WriteLine("Role: Intern");
        else
            Console.WriteLine("Role: Unknown");
    }
}
}

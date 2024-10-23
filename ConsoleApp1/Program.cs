using System.Runtime.Serialization;

namespace ConsoleApp1;

internal class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Creature c = new Creature("Shrek", 7 );
        c.SayHi();

        c.Level = 8;
       
        Console.WriteLine($"{c.Info}");

        Console.WriteLine($"{c.Name} - {c.Level}");

        Animals a = new() { Description = "Rats" };
        Console.WriteLine($"{a.Description}, {a.Size}");  // Rats, 3

        a = new() { Description = "Rats"; Size = 5 }; 
        Console.WriteLine($"{a.Description}, {a.Size}");
    }
}


namespace ConsoleApp1;

public class Creature
{
    
    public string? Name { get;  }
    private int level;

    public int Level
    {
        get => level;
        set => level = value > 0 ? value : 1;
    }

    public string Info => $"{Name} [{Level}]";

    public int SomeValue { get; set; }

    public Creature() 
    {
        Name = "Unknown";
        level = 1;
    
    }

    public Creature(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");

    public static void Slogan()
    {
        Console.WriteLine("Creatures are great");
    }

    
}


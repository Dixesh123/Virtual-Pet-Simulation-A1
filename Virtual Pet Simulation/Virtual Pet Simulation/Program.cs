using System;
using System.Xml.Linq;

class Pet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public Pet(string name, string type)
    {
        Name = name;
        Type = type;
        Hunger = 5;     // Initial hunger level
        Happiness = 5;  // Initial happiness level
        Health = 5;     // Initial health level
    }

    public void Feedinganimal()
    {
        Hunger = Math.Max(1, Hunger - 2); // Decreases hunger
        Health = Math.Min(10, Health + 1); // Increases health
        Console.WriteLine($"{Name}has been fed, reducing hunger and slightly improving health.");
    }

    public void Playwithanimal()
    {
        if (Hunger >= 7)
        {
            Console.WriteLine($"{Name} Is too full to play.");
            return;
        }
        Happiness = Math.Min(10, Happiness + 2); // Increases happiness
        Hunger = Math.Min(10, Hunger + 1); // Increases hunger
        Console.WriteLine($"{Name}played with joy, raising happiness yet a little bit increasing hunger.");
    }

    public void animalinrest()
    {
        Health = Math.Min(10, Health + 2); // Increases health
        Happiness = Math.Max(1, Happiness - 1); // Decreases happiness
        Console.WriteLine($"{Name} is sleeping. Happiness slightly declined as health increased.");
    }
    public void ShowStatus()
    {
        Console.WriteLine($"\n{Name}'s Status:");
        Console.WriteLine($"Hunger: {Hunger}/10");
        Console.WriteLine($"Happiness: {Happiness}/10");
        Console.WriteLine($"Health: {Health}/10");

        if (Hunger >= 8)
            Console.WriteLine("Alert: There is extreme hunger.!");
        if (Happiness <= 2)
            Console.WriteLine("Alert: There is very little happiness.!");
        if (Health <= 2)
            Console.WriteLine("Alert: Health is very low!");
    }
    public void TimePasses()
    {
        Hunger = Math.Min(10, Hunger + 1); // Hunger increases over time
        Happiness = Math.Max(1, Happiness - 1); // Happiness decreases over time

        if (Hunger >= 8 || Happiness <= 2)
        {
            Health = Math.Max(1, Health - 1); // Health deteriorates if hunger or happiness is critical
        }
    }
}



using System;

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
}
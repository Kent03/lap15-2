using System;

abstract class Animal
{
    //Đây là một triển khai của lớp trừu tượng Animalvà các lớp Dog, Cat và Duck
    //Lê Hoàng Khôi-20mc-20it438
    public string Type { get; }

    public Animal(string type)
    {
        Type = type;
    }

    public abstract string MakeSound();

    public abstract string GetInfo();
}

class Dog : Animal
{
    public string Name { get; }
    public string Breed { get; }

    public Dog(string name, string breed) : base("mammal")
    {
        Name = name;
        Breed = breed;
    }

    public override string MakeSound()
    {
        return "Woof!";
    }

    public override string GetInfo()
    {
        return $"Name: {Name}\nType: {Type}\nBreed: {Breed}";
    }
}

class Cat : Animal
{
    public string Name { get; }

    public Cat(string name) : base("mammal")
    {
        Name = name;
    }

    public override string MakeSound()
    {
        return "Meow!";
    }

    public override string GetInfo()
    {
        return $"Name: {Name}\nType: {Type}";
    }

    public void Climb(string thing)
    {
        Console.WriteLine($"{Name} is climbing {thing}.");
    }
}

class Duck : Animal
{
    public string Name { get; }

    public Duck(string name) : base("bird")
    {
        Name = name;
    }

    public override string MakeSound()
    {
        return "Quack!";
    }

    public override string GetInfo()
    {
        return $"Name: {Name}\nType: {Type}";
    }

    public void Swim(string thing)
    {
        Console.WriteLine($"{Name} is swimming in {thing}.");
    }

}

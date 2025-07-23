using System;

abstract class Pet
{
    private string name;
    private int age;
    private double weight;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set
        {
            if (value < 0) throw new ArgumentException("Age must be non-negative.");
            age = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0) throw new ArgumentException("Weight must be non-negative.");
            weight = value;
        }
    }

    public Pet(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight} kg");
    }

    public abstract void MakeSound();
}

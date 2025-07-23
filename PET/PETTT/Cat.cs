class Cat : Pet
{
    public string Breed { get; set; }

    public Cat(string name, int age, double weight, string breed)
        : base(name, age, weight)
    {
        Breed = breed;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Breed: {Breed}");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow~");
    }
}
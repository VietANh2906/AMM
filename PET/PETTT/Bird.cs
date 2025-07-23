class Bird : Pet
{
    public string Color { get; set; }

    public Bird(string name, int age, double weight, string color)
        : base(name, age, weight)
    {
        Color = color;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Color: {Color}");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Tweet! Tweet!");
    }
}
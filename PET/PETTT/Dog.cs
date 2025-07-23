class Dog : Pet
{
    public bool IsTrained { get; set; }

    public Dog(string name, int age, double weight, bool isTrained)
        : base(name, age, weight)
    {
        IsTrained = isTrained;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Trained: {IsTrained}");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}
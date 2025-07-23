using System.Collections.Generic;

class PetStore
{
    private List<Pet> pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        pets.Add(pet);
    }

    public void ShowAllPets()
    {
        Console.WriteLine("=== Pet List ===");
        foreach (var pet in pets)
        {
            pet.ShowInfo();
            Console.WriteLine();
        }
    }

    public void MakeAllPetsSound()
    {
        Console.WriteLine("=== Pet Sounds ===");
        foreach (var pet in pets)
        {
            Console.Write($"{pet.Name} says: ");
            pet.MakeSound();
        }
    }
}

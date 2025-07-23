using System;

class Program
{
    static void Main(string[] args)
    {
        PetStore store = new PetStore();

        Dog dog1 = new Dog("Buddy", 3, 15.5, true);
        Cat cat1 = new Cat("Mimi", 2, 4.2, "Siamese");
        Bird bird1 = new Bird("Coco", 1, 0.3, "Yellow");

        store.AddPet(dog1);
        store.AddPet(cat1);
        store.AddPet(bird1);

        store.ShowAllPets();
        store.MakeAllPetsSound();
    }
}

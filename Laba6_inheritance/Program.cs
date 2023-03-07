using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal dog = new("Корм для собак", "будка");
        Animal cat = new("Корм для кошек", "Дом");
        Animal horse = new("Сено", "Стойло");
        Vet vet = new();
        vet.treatAnimal(dog);
        vet.treatAnimal(cat);
        vet.treatAnimal(horse);
    }
}
class Animal
{
    public string food;
    public string location;
    
    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }

    public virtual void makeNoise() { }
    public virtual void eat() { }

    public virtual void sleep() { }
}
class Dog : Animal
{
    public Dog(string food, string location) : base(food, location)
    {
    }
    public override void makeNoise() {
        Console.WriteLine("гав");
    }
    public override void eat()
    {
        Console.WriteLine("Собака кушает");
    }
    public override void sleep() { Console.WriteLine("Собака спит"); }
}
class Cat : Animal
{
    public Cat(string food, string location) : base(food, location)
    {
    }
    public override void makeNoise()
    {
        Console.WriteLine("мяу");
    }
    public override void eat()
    {
        Console.WriteLine("Котик ест");
    }
    public override void sleep() { Console.WriteLine("Кот спит"); }
}
class Horse : Animal
{
    public Horse(string food, string location) : base(food, location)
    {
    }
    public override void makeNoise()
    {
        Console.WriteLine("Хаха");
    }
    public override void eat()
    {
        Console.WriteLine("Лошадь кушает");
    }
    public override void sleep() { Console.WriteLine("Лошадь спит"); }
}
class Vet
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine(animal.food);
        Console.WriteLine(animal.location);
        Console.WriteLine();
    }
}
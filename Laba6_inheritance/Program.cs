using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal dog = new Dog("Корм для собак", "будка", "Бася");
        Animal cat = new Cat("Корм для кошек", "Дом", "Снежок");
        Animal horse = new Horse("Сено", "Стойло", "Коричневая");
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
    string name;
    public Dog(string food, string location, string name) : base(food, location)
    {
        this.name = name;
    }
    public override void makeNoise() {
        Console.WriteLine("гав");
    }
    public override void eat()
    {
        Console.WriteLine("Собака кушает "+food);
    }
    public override void sleep() { Console.WriteLine("Собака спит"); }
}
class Cat : Animal
{
    string name;
    public Cat(string food, string location, string name) : base(food, location)
    {
        this.name = name;
    }
    public override void makeNoise()
    {
        Console.WriteLine("мяу");
    }
    public override void eat()
    {
        Console.WriteLine("Котик ест "+food);
    }
    public override void sleep() { Console.WriteLine("Кот спит"); }
}
class Horse : Animal
{
    string color;
    public Horse(string food, string location, string color) : base(food, location)
    {
        this.color = color;
    }
    public override void makeNoise()
    {
        Console.WriteLine("Хаха");
    }
    public override void eat()
    {
        Console.WriteLine("Лошадь кушает "+food);
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
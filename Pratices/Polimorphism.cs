
void Animalnoise(Animal animal)
{
    animal.MakeSound();

}

Animal animal = new Animal();
Dog dog = new Dog();
Goat goat = new Goat();


Animalnoise(animal);
Animalnoise(dog);
Animalnoise(goat);
     
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("This is my name");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dogs barks");
    }
}

class Goat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The Goats barks");
    }
}


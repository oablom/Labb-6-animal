

class AnimalProgram
{
    public static void Main(string[] args)
    {
        Fish firstFish = new Fish(8);

        PolarBear firstBear = new PolarBear(15);

        Cat firstCat = new Cat(false);

        Animal firstSnake = new Animal();
        
        firstFish.color = "blue";


     
        Console.WriteLine(firstFish.makeSound());
        Console.WriteLine(firstBear.makeSound());
        Console.WriteLine(firstCat.makeSound());
        Console.WriteLine(firstSnake.makeSound());


    }
}

class Animal
{
    string species = "snake";
    bool mammal = false;
    public string color = "black";
    public string habitat = "land";

    public Animal(string species, bool mammal, string color, string habitat)
    {
        this.species = species;
        this.mammal = mammal;
        this.color = color;
        this.habitat = habitat;
    }

    public Animal() { }

    public virtual string makeSound()
    {
        return "Sssssss";
    }

    public string move()
    {
        return $"{species} moves around.";
    }

    public string sleep()
    {
        return $"{species} sleeps.";
    }
}

class Fish : Animal
{
    int numFins = 4;

    public Fish(int numFins) : base("Fish", false, "Various", "Water")
    {
        this.numFins = numFins;
    }

    public int lifeSpan()
    {
        return 5; 
    }

    public override string makeSound()
    {
        return "Blub-blub-blub!";
    }
   
}

class Cat : Animal
{
    bool longHair = true;

    public Cat(bool longHair) : base("Cat", true, "Various", "Land")
    {
        this.longHair = longHair;
    }

    public string eat()
    {
        return "Cat eats fish or meat.";
    }

    public override string makeSound()
    {
        return "Mjaao";
    }
}

class Bear : Animal
{
    string location = "North America";

    public Bear(string location) : base("Bear", true, "Brown", "Land")
    {
        this.location = location;
    }

    public string aggressionLevel()
    {
        return "high";
    }

    public override string makeSound()
    {
        return "Raaawr!";
    }
}

class PolarBear : Bear
{
    double swimSpeed = 10;

    public PolarBear(double swimSpeed) : base("North Pole")
    {
        this.swimSpeed = swimSpeed;
    }

    public string swim()
    {
        return $"Polar bear swims at {swimSpeed} km/h.";
    }
}


class BrownBear : Bear
{
    double runningSpeed = 25;

      public BrownBear(double runningSpeed) : base("Europe")
       {
           this.runningSpeed = runningSpeed;
       }

    public string run()
    {
        return $"Brown bear runs at {runningSpeed} km/h.";
    }
}


Console.WriteLine("name your dog:");
string myDogName = Console.ReadLine();
Dog MyDog = new Dog(myDogName);


Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {MyDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

MyDog.Rename("Bad boy");

while (MyDog._levelOfHapiness != 5)
{
    MyDog.Bark();
}

MyDog.WagTail();

class Dog
{
    private string _name = "Koer";
    public int _levelOfHapiness;

    public Dog(string name) // name lets the user choose the name
    {
        _name = name;
        _levelOfHapiness = 0;

    }

    public string Name
    {
        get { return _name; }
    }
    
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }


    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been ranamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
       _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}


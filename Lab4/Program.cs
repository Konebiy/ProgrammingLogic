namespace Lab4;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }
    
    public void Repaint(string newColor)
    {
        // Assigning a new color to the car.
        color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start(); // Calling the Start method
        myCar.Drive(50); // Calling the Drive method with a parameter
        Console.WriteLine(myCar.GetDescription());
        myCar.Repaint("Red");
        Console.WriteLine(myCar.GetDescription()); // Confirm that the car color was updated.
    }
}
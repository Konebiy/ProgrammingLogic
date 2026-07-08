namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1
        int a = 10, b = 5, c = 15;

        Console.WriteLine(a > b); // returns True, because a is greater than b
        Console.WriteLine(a < c); // returns True, because a is less than c
        Console.WriteLine(a > b && a > c); // returns False, because one of the conditions is False
        Console.WriteLine(a > b || a > c); // returns True, because one of the conditions is True
        Console.WriteLine("");

        // Part 2
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella) // ! (NOT) operator reverses a boolean value.
        {
            Console.WriteLine("Take an umbrella!\n");
        }
        else
        {
            Console.WriteLine("You're good to go!\n");
        }

        // Part 3
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!\n");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5\n");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10\n");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6\n");
        }

        // Part 4
        Console.Write("Enter a day of the week (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}

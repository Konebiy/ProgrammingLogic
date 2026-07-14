namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple for loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();

        // Problem 3: While Loop Countdown
        int countDown = 5;
        while (countDown > 0)
        {
            Console.WriteLine(countDown);
            countDown--;
        }
        Console.WriteLine();

        // Problem 4: While Loop – Multiples of 10 from 10 to 1000
        int number = 10;
        while (number <= 1000)
        {
            Console.WriteLine(number);
            number = number * 10;
        }
        Console.WriteLine();

        // Problem 5: Seasons of the Year
        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string i in seasons)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // Problem 6: Days of the Week (1–7)
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        
        int day;

        Console.Write("Enter a number between 1 and 7: ");

        // Make sure the user entered a number and this is within the valid range.
        while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 7: ");
        }

        Console.WriteLine(days[day - 1] + "\n"); // Subtract 1 because array indexing starts at 0.

        // Problem 7: Favorite Books and Authors
        string[,] books = {{"Tiger Trappers", "Natalka Poltavka", "Eneida"}, {"Ivan Bahriany","Ivan Kotliarevsky", "Ivan Kotliarevsky"}};

        // I'm not sure it is the most efficient way to do this, but after several adjustments it works.
        for (int i = 0; i < books.GetLength(1); i++)
        {
            Console.Write(books[0, i] + " by ");
            Console.WriteLine(books[1, i]);      
        }
        Console.WriteLine();

        // Problem 8: Temperature Tracker
        int[] temperatures = {98, 64, 89, 55, 70};
        Array.Sort(temperatures);

        foreach (int i in temperatures)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n" + temperatures.Max());
        Console.WriteLine(temperatures.Min() + "\n");
    
        // Problem 9: Reverse Countdown
        int[] myNumbers = {5, 4, 3, 2, 1};
        Array.Reverse(myNumbers);
        
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);
        }

    }
}

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        /* Name: [Andrii Pidkivka] 
        Title: [IT-1050 - Lab 1] */

        // Step 2
        Console.WriteLine("Andrii Pidkivka");
        Console.WriteLine("IT-1050 - Lab 1"); 

        // Step 3
        int number = 7;
        char language = 'C';
        string game1 = "Replicube";
        string game2 = "The Farmer Was Replaced";
        string game3 = "Human Resource Machine";
        double programsWritten = 100;
        bool programmingExperience = true;

        Console.WriteLine("My favorite number is " + number + " because I believe it brings me luck.");
        Console.WriteLine("The first programming language I learned was " + language + ".");
        Console.Write("I like to play programming games, such as " + game1 + ", " + game2 + ", and " + game3 + "." );
        Console.Write(" They are fun to play and help develop logical thinking. ");
        Console.WriteLine("Since each level in these games is a program, I have written more than " + programsWritten + " programs.");
        Console.WriteLine("Do I have some programming experience? I would say " + programmingExperience + ".");

        // Step 4
        const string schoolName = "Lapaivka lyceum";
        Console.WriteLine("I graduated from " + schoolName + " in Ukraine in 2019.");

        // Step 5
        double doubleValue = 9.78d;
        int integerValue = (int) doubleValue;
        bool isTrue = true;
        string strValue = Convert.ToString(integerValue);

        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("integer: " + integerValue);
        Console.WriteLine("int to a string: " + strValue);
        Console.WriteLine("bool to a string: " + Convert.ToString(isTrue));

        // Step 6
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello, " + userName + ", your age is: " + age);

        // Step 7
        int num1 = 11;
        int num2 = 2; // Used for subtraction, division, and modulus operations

        Console.WriteLine("Addition (+10): " + (num1 + 10));
        Console.WriteLine("Subtraction (-2): " + (num1 - num2));
        Console.WriteLine("Multiplication (*3): " + (num1 * 3));
        Console.WriteLine("Division (/2): " + (num1 / num2));
        Console.WriteLine("Modulus (%2): " + (num1 % num2));

        // Step 8
        float floatValue = 1.123456789f;
        doubleValue = 1.123456789d; // doubleValue already exists, so assign it a new value
        Console.WriteLine(floatValue); // displays up to 7 digits of precision
        Console.WriteLine(doubleValue); // displays up to 15 digits of precision

        /* I was wondering why the float value displayed 8 instead of 7.
        After reserching this, I learned that a float can stores
        about 7 digits of precision, so the last digit was rounded from 7 to 8. */

        //Step 9
        integerValue = 10; // integerValue already exists, so assign a new value
        integerValue++;
        Console.WriteLine(integerValue);
        integerValue--;
        Console.WriteLine(integerValue);
    }
}

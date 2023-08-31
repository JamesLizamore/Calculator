// Declare variables and then initialize to zero.
using System.Globalization;

double num1 = 0; double num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
bool validInput1 = false;
while (!validInput1)
{
    Console.WriteLine("Type the first number, and then press Enter");
    string input1 = Console.ReadLine();

    // Replace commas with periods for consistent parsing
    input1 = input1.Replace(',', '.');

    validInput1 = double.TryParse(input1, NumberStyles.Float, CultureInfo.InvariantCulture, out num1);

    if (!validInput1)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

// Ask the user to type the second number.
bool validInput2 = false;
while (!validInput2)
{
    Console.WriteLine("Type the second number, and then press Enter");
    string input2 = Console.ReadLine();

    // Replace commas with periods for consistent parsing
    input2 = input2.Replace(',', '.');

    validInput2 = double.TryParse(input2, NumberStyles.Float, CultureInfo.InvariantCulture, out num2);

    if (!validInput2)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
using Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator app!");
        Console.WriteLine("Please enter your first number");
        /*Need code to take in user input for first number*/

        Console.WriteLine("Please enter your second number");
        /*Need code to take in user input for second number*/

        Calculation calc = new Calculation(num1,num2);
        calc.Addition(num1, num2);

    }
}
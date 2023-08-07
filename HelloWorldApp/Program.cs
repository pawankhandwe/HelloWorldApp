// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



class Program
{
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");

        int num1 = 5;
        int num2 = 7;
        int result = Multiply(num1, num2);

        System.Console.WriteLine($"The multiplication of {num1} and {num2} is {result}");
    }
}


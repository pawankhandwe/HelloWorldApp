// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");

        int num1 = 5;
        int num2 = 7;
        int result = Sum(num1, num2);

        System.Console.WriteLine($"The sum of {num1} and {num2} is {result}");
    }
}


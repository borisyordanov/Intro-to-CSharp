using System;
class NamePrinter
{
    static void PrintHello(string name)
    {
        Console.WriteLine("\"Hello, {0}!\"", name);
    }

    static void Main(string[] args)
    {
        string inputName = Console.ReadLine();
        PrintHello(inputName);
    }
}

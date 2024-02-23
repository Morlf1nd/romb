using System;

class Program
{
    static void Print(char symbol, int width)
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write(new string(' ', width - i - 1));
            Console.Write(symbol);
            if (i > 0)
            {
                Console.Write(new string(' ', 2 * i - 1));
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        for (int i = width - 2; i >= 0; i--)
        {
            Console.Write(new string(' ', width - i - 1));
            Console.Write(symbol);
            if (i > 0)
            {
                Console.Write(new string(' ', 2 * i - 1));
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter you symbol #, $, * ");
        char symbol = Convert.ToChar(Console.ReadLine());
        if (symbol != '#' && symbol != '$' && symbol != '*')
        {
            Console.WriteLine("Wrong symbol");
            return;
        }
        Console.WriteLine("Enter the weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        if (weight <= 0)
        {
            Console.WriteLine("weight can't be min 0");
            return;
        }
        
        Print(symbol, weight);

    }
}

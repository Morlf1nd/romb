using System;

class Program
{
    static void Print(char symbol, int heidth)
    {
        for (int i = 0; i < heidth; i++)
        {
            Console.Write(new string(' ', heidth - i - 1));
            Console.Write(symbol);
            if (i > 0)
            {
                Console.Write(new string(' ', 2 * i - 1));
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        for (int i = heidth - 2; i >= 0; i--)
        {
            Console.Write(new string(' ', heidth - i - 1));
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
        Console.WriteLine("Enter the height");
        int height = Convert.ToInt32(Console.ReadLine());
        if (height <= 0)
        {
            Console.WriteLine("weight can't be min 0");
            return;
        }
        
        Print(symbol, height);

    }
}

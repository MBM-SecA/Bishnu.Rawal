using System;

class IterationStatement
{
    static void Main232()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoop();        
    }

    void LearnForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("I am beautiful.");
        }

        int[] numbers = { 34, 5, 6, 78, 91 };

        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even.");
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }
    }

    void LearnWhileLoop()
    {
        char confirm = 'Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("I am beautiful.");
            Console.WriteLine("Print one more time?");
            confirm = Console.ReadKey().KeyChar;
        }

        do
        {
            Console.WriteLine("I am beautiful.");
            Console.WriteLine("Print one more time?");
            confirm = Console.ReadKey().KeyChar;
        } while(confirm == 'Y');
    }
}
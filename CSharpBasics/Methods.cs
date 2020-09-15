using System;
using EnumsAndProperties;

public class MethodTeacher
{
    // Simple method: with 2 arguments and a return type
    public double Sum(double firstNum, double secondNum)
    {
        //DayWeek x;
        return firstNum + secondNum;
    }

    // Variable-number of arguments
    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }

        return sum;
    }

    // Returning multiple value - Using tuples
    // Example: Method to find min and max from from set of numbers
    internal (int, int) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        return (min, max);
    }

    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name}[{age}], Address: {address}");
    }

    // Generic method
    public void Sum<T>(T firstNum, T secondNum)
    {
    }
}

public class MethodTester
{
    static void Main34234()
    {
        MethodTeacher methodTeacher = new MethodTeacher();

        int[] numbers = { 34, 5, 6, 7, 12, 34, 56, 78, 98 };
        (int Min, int Max) result = methodTeacher.FindMinMax(numbers);


        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");

        // Named-arguments
        methodTeacher.PrintCustomerDetails(age: 32, address: "Naikap", name:"Bishnu");

        methodTeacher.Sum<float>(345.34f, 4352.34f);
    }
}
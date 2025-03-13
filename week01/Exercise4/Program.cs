using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double num;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.WriteLine("Enter Number: ");
            num = double.Parse(Console.ReadLine());
            numbers.Add(num);
        }while(num != 0);

        double ava = (numbers.Count - 1);
        double sum = 0;
        double large = 0;

        foreach(double number in numbers){
            sum += number;
            if(number>large){
                large = number;
            }
        }
        double  average = sum / ava;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");   


        Console.WriteLine(numbers.Count);
    }
}
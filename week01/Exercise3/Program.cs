using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magical number between 1 - 100 ");
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, 101);
        int gue = 0;

        do{
        Console.WriteLine("what is your guess?");
        string guess = Console.ReadLine();
        gue = int.Parse(guess);
            if(gue < num){
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("Lower");
            }
        }while( gue != num);

        Console.WriteLine("Congratulations you guessed the number...!!!");
        

    }
}
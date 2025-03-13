using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(string name){
            return name;
        }

        static int PromptUserNumber(int num){
            return num;
        }

        static int SquareNumber (int num){
            int square = num;
            return square * square;
        }

        static void DisplayResult (string uName, int squaredNum){
            Console.WriteLine($"{uName}, the squere of your number is {squaredNum}");
        }

        DisplayWelcome();
        Console.Write($"Please enter your name: ");
        string name = Console.ReadLine();
        PromptUserName(name);
        Console.Write($"Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        PromptUserNumber(num);
        SquareNumber(num);
        DisplayResult(PromptUserName(name), SquareNumber(num));
    }
}
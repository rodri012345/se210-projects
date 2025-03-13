using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string grade = Console.ReadLine();
        int gradePorcent = int.Parse(grade);

        string letter = "";

        if(gradePorcent >= 90){
            letter = "A";
        }else if(gradePorcent >= 80){
            letter = "B";
        }else if(gradePorcent >= 70){
            letter = "C";
        }else if(gradePorcent >= 60){
            letter = "D";
        }else{
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if(gradePorcent >= 70){
            Console.WriteLine("Congratulations!!! You have approved...!!!");
        }else{
            Console.WriteLine("Your have reproved, more luck next time. You can do it.");
        }



    }
}
using System;
using System.Collections.Generic;
using System.IO;

class Program{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(){
        bool running = true;
        while (running){
            Console.WriteLine($"\nYou have {totalScore} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice){
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void CreateGoal(){
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type){
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals(){
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++){
            var g = goals[i];
            Console.WriteLine($"{i + 1}. {g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
        }
    }

    static void RecordEvent(){
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count){
            int points = goals[index].RecordEvent();
            Console.WriteLine($"You earned {points} points!");
            totalScore += points;
        }
        else{
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals(){
        Console.Write("Enter file name to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file)){
            writer.WriteLine(totalScore);
            foreach (var g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals(){
        Console.Write("Enter file name to load: ");
        string file = Console.ReadLine();

        if (File.Exists(file)){
            string[] lines = File.ReadAllLines(file);
            totalScore = int.Parse(lines[0]);
            goals.Clear();

            for (int i = 1; i < lines.Length; i++){
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split("|");

                switch (type){
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                        break;
                }
            }

            Console.WriteLine("Goals loaded.");
        }
        else{
            Console.WriteLine("File not found.");
        }
    }
}

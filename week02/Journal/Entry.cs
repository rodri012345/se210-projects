using System;

public class Entry{
    string date;
    string promptText;
    string entryText;

    public Entry(string promptText, string entryText){
        date = DateTime.Now.ToShortDateString();
        this.promptText = promptText;
        this.entryText = entryText;
    }

    public void Display(){
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {promptText}");
        Console.WriteLine($"Entry: {entryText}\n");
    }

    public string ToFileFormat(){
        return $"{date}|{promptText}|{entryText}";
    }

    public static Entry FromFileFormat(string line){
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { date = parts[0] };
    }
}
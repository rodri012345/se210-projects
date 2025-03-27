using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        entries.Add(newEntry);
    }

    public void DisplayAll(){
        if (entries.Count == 0){
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in entries){
            entry.Display();
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter writer = new StreamWriter(file)){
            foreach (Entry entry in entries){
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file){
        if (!File.Exists(file)){
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines){
            entries.Add(Entry.FromFileFormat(line));
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}

    public void Run(){

        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You will have a moment to start thinking...");
        ShowCountdown(5);
        Console.WriteLine("Start listing items! (Press Enter after each item)");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        
        while (DateTime.Now < endTime){
            Console.Write("> ");
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}

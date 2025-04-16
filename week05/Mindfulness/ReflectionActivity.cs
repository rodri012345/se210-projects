public class ReflectionActivity : Activity{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") {}

    public void Run(){
        DisplayStartingMessage();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
        Console.WriteLine("Reflect on the following questions:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime){
            Console.WriteLine(_questions[rnd.Next(_questions.Length)]);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}

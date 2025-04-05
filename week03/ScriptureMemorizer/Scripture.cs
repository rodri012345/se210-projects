public class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count){
        Random rand = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public void Display(){
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
    }

    public bool AllWordsHidden(){
        return _words.All(w => w.IsHidden());
    }
}

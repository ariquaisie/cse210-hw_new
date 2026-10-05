using System; 
public class Entry{
    public string _date;
    public  string _entry;
    public string _answer;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_entry}");
        Console.WriteLine($"Response: {_answer}");
        Console.WriteLine();
}
}
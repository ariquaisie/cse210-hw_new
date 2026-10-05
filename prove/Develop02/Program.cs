using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = myMenu.ProcessMenu();

        Answers answers1 = new Answers();
        int choose = 0;

        do {
            Console.WriteLine("What would you like to do (Enter a number)? \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            string next = Console.ReadLine();
            choose = int.Parse(next);

            if (choose == 1)
            {
                List<string> _entry = new List<string>(){
                    "What went well today?",
                    "What are you grateful for today?",
                    "What would you like to do better?",
                    "What is one thing you learned today?",
                    "What challenge did you face today, and how did you handle it?",
                    "What made you happy today?",
                    "What made you feel stressed or upset today?",
                    "What would you do differently if you could relive today?",
                    "What are your top priorities for tomorrow?",
                    "What would you do to improve on your goal tomorrow?",
                    "What habit would you like to develop?",
                    "What habit would you like to break?",
                    "What is one thing you are proud of about yourself?",
                    "What is one mistake you made today, and what did it teach you?",
                    "What kind of person do you want to become?",
                    "What is something you have been avoiding, and why?",
                    "What are three things you want to accomplish this week?",
                    "What is something that inspired you today?",
                    "How did you help someone today?",
                    "How did someone help you today?",
                    "What is one thing you can do to take better care of yourself?",
                    "What are you looking forward to?",
                    "What fear is holding you back right now?",
                    "What is one small step you can take toward your goals tomorrow?",
                    "What qualities do you admire in yourself?",
                    "What qualities would you like to improve?",
                    "What are your biggest dreams for the future?",
                    "What is something you need to forgive yourself for?",
                    "What is one positive thought you want to remember?",
                    "How can you become a better version of yourself tomorrow?"
                };
                Random random = new Random();
                string Entries = _entry[random.Next(_entry.Count)];
                Console.WriteLine(Entries);
                string answer = Console.ReadLine();
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._entry = Entries;
                entry._answer = answer;

                answers1._entries.Add(entry);
            } else if (choose == 2){
                answers1.DisplayAll();
            } else if (choose == 3){
                Console.WriteLine("Enter the file you want to load: ");                
                string file = Console.ReadLine();
                answers1.load(file);
            } else if (choose == 4){
                Console.Write("Enter a filename: ");
                string file = Console.ReadLine();
                answers1.save(file);
            } else if (choose == 5){
                Console.WriteLine("Goodbye"); //also shows creativity
            } else {
                Console.WriteLine("Invalid number! Enter the correct number. Enter 1, 2, 3, 4, or 5."); //this is my creativity line.              
            }
            
        } while (choose != 5);
    }
}
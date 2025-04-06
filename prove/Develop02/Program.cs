using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = "";
        Journal journal = new Journal("");

        Menu mainMenu = new Menu("Journal Writer (Enter to select, Esc to exit)", ["New Journal", "Load Journal"]);
        Menu journalMenu = new Menu("Journal Writer (Enter to select, Esc to exit)", ["New Entry", "Display Journal", "Save Journal",]);

        void ShowPrompt()
        {
            Console.Clear();
            prompt = promptGenerator.GetPrompt();
            Console.WriteLine(prompt);
        }

        void ShowJournal()
        {
            Console.Clear();
            Console.Write(journal.Compile());
            Console.Read();
        }

        void SelectFile()
        {
            Console.Clear();
            Console.Write("Enter a file name: ");
            string fileName = $"{Console.ReadLine()}.txt";
            journal = new Journal(fileName);
        }

        void WriteInJournal()
        {
            string response = Console.ReadLine();
            if(response != "")
            {
                journal.AddEntry(prompt, response);
            }
        }

        bool runProgram = true;
        while(runProgram)
        {
            switch(mainMenu.Run())
            {
                case 0:
                    SelectFile();
                    journal.Save();
                    break;
                case 1:
                    SelectFile();
                    journal.Load();
                    break;
                case -1:
                    runProgram = false;
                    break;
            }

            bool runJournalMenu = true;
            while(runJournalMenu && runProgram)
            {
                switch(journalMenu.Run())
                {
                    case 0:
                        ShowPrompt();
                        WriteInJournal();
                        break;
                    case 1:
                        ShowJournal();
                        break;
                    case 2:
                        journal.Save();
                        break;
                    case -1:
                        runJournalMenu = false;
                        break;
                }
            }  
        }
    }
}
using System;
using System.IO;
using System.Collections.Generic;

// Gustavo Fragas Cunha
// - Number validator
// - Using "String Buider" because it improves performance when concatenating strings

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the journal program!");
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Console.WriteLine();

            string choice = Console.ReadLine();
            int choiceInt;
            bool isInt = int.TryParse(choice, out choiceInt);

            Validator val = new Validator();
            val.numberValidator(choiceInt);

            if (choice == "1") //write
            {
                string prompt = promptGen.getRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3") //save
            {
                Console.WriteLine("What is the filename? its 'nephi.txt'");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "4") //load
            {
                Console.WriteLine("What is the filename? its 'nephi.txt");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "5") //quit
            {
                running = false;
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment firstAssignment = new Assignment();
        Console.WriteLine("Sem Herança e sem atributos");
        Console.WriteLine(firstAssignment.GetSummary());
        Console.WriteLine();

        Assignment secondAssignment = new Assignment("Gustavo", "History");
        Console.WriteLine("Sem Herança e com atributos");
        Console.WriteLine(secondAssignment.GetSummary());
        Console.WriteLine();


        MathAssignment firstMath = new MathAssignment();
        Console.WriteLine("com Herança (math filho) e sem atributos");
        Console.WriteLine(firstMath.GetSummary());
        Console.WriteLine(firstMath.GetHomeworkList());
        Console.WriteLine();

        MathAssignment secondMath = new MathAssignment("Gustavo", "History", "7", "8.1");
        Console.WriteLine("com Herança (math filho) e com atributos");
        Console.WriteLine(secondMath.GetSummary());
        Console.WriteLine(secondMath.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment firstWriting = new WritingAssignment();
        Console.WriteLine("com Herança (writing filho) e sem atributos");
        Console.WriteLine(firstWriting.GetSummary());
        Console.WriteLine(firstWriting.GetWritingInformation());
        Console.WriteLine();

        WritingAssignment secondWriting = new WritingAssignment("Gustavo", "History", "The incredibles");
        Console.WriteLine("com Herança (writing filho) e com atributos");
        Console.WriteLine(secondWriting.GetSummary());
        Console.WriteLine(secondWriting.GetWritingInformation());
        Console.WriteLine();



    }
}

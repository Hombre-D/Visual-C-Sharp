using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string sentence;

        Console.WriteLine("Welcome to Sentence Sorter!");
        Console.Write("Enter a sentence: ");
        sentence = Console.ReadLine();
        string [] splitSentence = sentence.ToLower().Split();

        var sortedSentence =
            from word in splitSentence
            orderby word
            select word;

        foreach (var word in sortedSentence.Distinct())
        {
            Console.WriteLine(word);
        }



    }
}


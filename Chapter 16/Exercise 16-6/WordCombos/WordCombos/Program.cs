using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a five-letter string: ");
        string input = Console.ReadLine();
        List<string> output = Combos(input);

        foreach (var word in output)
        {
            Console.WriteLine(word);
        }

    }

    public static List<string> Combos(string input)
    {
        char[] letters = input.ToCharArray();
        List<string> words = new List<string>();

        for(int i = 0; i < letters.Length; ++i)
        {
            string word = letters[i].ToString();
            
            for(int j = 0; j < letters.Length; ++j)
            {
                if(i != j)
                {
                    word += letters[j].ToString();
                    
                    for (int k = 0; k < letters.Length; ++k)
                    {
                        if(i != k && j != k)
                        {
                            word += letters[k].ToString();
                            words.Add(word);
                            word = letters[i].ToString() + letters[j].ToString();
                        }
                        
                    }
                    
                    
                }
                
                word = letters[i].ToString();
            }

        }
        return words;

    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Scripture scripture = new Scripture(reference, text);

        while(true)
        {
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine("");
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");

            string command = Console.ReadLine();
            if(command == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
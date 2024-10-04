/*  Exceeds Requirements.
    I added a Library class to store a set of scriptures and allow one to be selected at random.
    I also added the functionality to show the entire scripture and then hide it again, so that 
    the user can remember it if they forget it during the memorization process.    
    */
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();

        bool isTemporarilyHidden = false;
        while(true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetReferenceText()} {(isTemporarilyHidden
                ? scripture.GetNotHiddenText()
                : scripture.GetDisplayText())}");
            Console.WriteLine("");
            Console.WriteLine("Please enter to continue, type 'quit' to finish or 'show' to show the scripture temporarily:");

            isTemporarilyHidden = false;
            string command = Console.ReadLine();

            if(command == "show")
            {
                isTemporarilyHidden = true;
            }

            if(command == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
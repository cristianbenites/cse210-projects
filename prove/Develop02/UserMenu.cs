public class UserMenu
{
    public Option GetUserOption()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Array options = Enum.GetValues(typeof(Option));
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i+1}: {options.GetValue(i)}");
        }

        Console.Write("What would you like to do? ");
        string strChoice = Console.ReadLine();
        int choice =  int.Parse(strChoice);

        return (Option) options.GetValue(choice - 1);
    }

}
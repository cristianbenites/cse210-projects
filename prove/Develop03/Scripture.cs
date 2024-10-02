public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];

    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            _words.Add(new Word(words[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {

        while (!IsCompletelyHidden() && numberToHide > 0)
        {
            IEnumerable<Word> notHidden = _words.Where(w => !w.IsHidden());
            int number = _random.Next(0, notHidden.Count() - 1);
            Word selected = notHidden.ElementAt(number);

            selected.Hide();
            numberToHide--;
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        _words.ForEach(word => {
            text += word.GetDisplayText() + " ";
        });

        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }
}
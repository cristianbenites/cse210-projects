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

    public string GetReferenceText()
    {
        return _reference.GetDisplayText();
    }

    public void HideRandomWords(int numberToHide)
    {

        while (!IsCompletelyHidden() && numberToHide > 0)
        {
            IEnumerable<Word> notHidden = _words.Where(w => !w.IsHidden());
            int number = _random.Next(notHidden.Count());
            Word selected = notHidden.ElementAt(number);

            selected.Hide();
            numberToHide--;
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }

    public string GetNotHiddenText()
    {
        return MapTextAndConcat(word => word.GetVisibleText());
    }

    public string GetDisplayText()
    {
        return MapTextAndConcat(word => word.GetDisplayText());
    }

    private string MapTextAndConcat(Converter<Word, string> converter)
    {
        string text = "";

        _words.ForEach(word => {
            text += converter.Invoke(word) + " ";
        });

        return text.Trim();
    }


}
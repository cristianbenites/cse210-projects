public class Library
{
    private List<Scripture> _scriptures;

    public Library()
    {
        _scriptures = new List<Scripture>();

        Reference reference1 = new Reference("1 Nephi", 3, 7);
        string text1 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Reference reference2 = new Reference("John", 3, 5);
        string text2 = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";

        Reference reference3 = new Reference("2 Nephi", 32, 2, 3);
        string text3 = "Do ye not remember that I said unto you that after ye had received the Holy Ghost ye could speak with the tongue of angels? And now, how could ye speak with the tongue of angels save it were by the Holy Ghost? Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";

        Reference reference4 = new Reference("Helaman", 5, 12);
        string text4 = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";

        Reference reference5 = new Reference("Proverbs", 3, 5, 6);
        string text5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        _scriptures.Add(new Scripture(reference1, text1));
        _scriptures.Add(new Scripture(reference2, text2));
        _scriptures.Add(new Scripture(reference3, text3));
        _scriptures.Add(new Scripture(reference4, text4));
        _scriptures.Add(new Scripture(reference5, text5));
    }

    public Scripture GetRandomScripture()
    {
        int index = new Random().Next(_scriptures.Count);
        return _scriptures.ElementAt(index);
    }

}
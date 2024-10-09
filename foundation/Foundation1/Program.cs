using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to plant wheat in your backyard", "John Doe", 784);
        video1.AddComment(new Comment("Jane", "Wow! That's amazing."));
        video1.AddComment(new Comment("Mr. Farmer", "I'll do that in mine, great job. Thank you!"));
        video1.AddComment(new Comment("Luke Skywalker", "It's a grat option for planting, I did that too in Tatooine"));
        video1.AddComment(new Comment("Charles Hater", "Such a bad video! I don't know why you didn't plant potatoes instead."));

        Video video2 = new Video("Vlog - Tourist Attractions in Wonderland", "Alice", 635);
        video2.AddComment(new Comment("White Rabbit", "That's sweet, Alice!"));
        video2.AddComment(new Comment("Darth Vader", "Where is that planet? I will destroy it!"));
        video2.AddComment(new Comment("Jane", "I'm going to Wonderland next summer, I'm so excited!"));

        Video video3 = new Video("President Russell M. Nelson—A Prophet of God", "General Conference of The Church of Jesus Christ", 90);
        video3.AddComment(new Comment("John Doe", "President Nelson gives lovely messages. We must follow his council."));
        video3.AddComment(new Comment("Mary Jane", "I can't wait for General Conference!"));
        video3.AddComment(new Comment("Bishop Ernest", "I'm so grateful that we have a living prophet these days!"));
        
        Video video4 = new Video("Alleluia | The Tabernacle Choir", "The Tabernacle Choir at Temple Square", 349);
        video4.AddComment(new Comment("Tom", "I hear this and I'm at peace. In a broken world this gives me hope."));
        video4.AddComment(new Comment("Wesley", "Beautiful! My tears are falling"));
        video4.AddComment(new Comment("Anne Luh", "Heard this because of that Behold Your Little Ones video"));
        video4.AddComment(new Comment("Martha", "This is one of my favorite songs ever"));

        List<Video> videos = [video1, video2, video3, video4];

        videos.ForEach(video => {
            Console.WriteLine($"Name: {video.GetName()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration (in seconds): {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        });
    }
}
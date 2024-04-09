using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video video1 = new("Making Sourdough", "John Smith", 325);
        Video video2 = new("Beating super mario in under 5 minutes", "Badabun", 299);
        Video video3 = new("Giving tesla to homeless nuns", "Mr. Beast", 800);

        video1.AddComment(new Comment("Jace Hall", "Wow, this is my first time making sourdough and it turned out great!"));
        video1.AddComment(new Comment("Creton Dumkampf", "Uhhh, I made this and left it out in the sun and the bread tasted moldy."));
        video1.AddComment(new Comment("Average Kid", "First!"));
        videos.Add(video1);

        video2.AddComment(new Comment("Karl Jobst", "This is totally fake."));
        video2.AddComment(new Comment("Thiago Albuquerque", "This is the coolest video ever!"));
        video2.AddComment(new Comment("SmallAnt", "NES mario is so hard."));
        videos.Add(video2);

        video3.AddComment(new Comment("Wilson Fisk", "You did a good thing for this city."));
        video3.AddComment(new Comment("Ludwig", "Teslas? Was the bugatti dealership closed? Freaking cheapskate..."));
        video3.AddComment(new Comment("Summoing Salt", "This is the best content on the platform."));
        video3.AddComment(new Comment("Abroad in Japan", "I wish I had a tesla so bad."));
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine($"There are {video.GetNumberOfComments()} comments on this video.");
            int i = 1;
            foreach(Comment comment in video.Comments)
            {
                Console.WriteLine($"Comment {i}. {comment.Commentor} says \"{comment.Text}\"");
                i++;
            }
            Console.WriteLine();
        }

    }
}
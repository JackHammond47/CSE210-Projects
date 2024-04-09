class Comment
{
    public string Commentor { get; set;}
    public string Text { get; set;}
    public Comment(string commentor, string text)
    {
        Commentor = commentor;
        Text = text;
    } 
}
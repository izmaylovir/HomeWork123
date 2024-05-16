class Post
{
    public string Author { get; set; }
    public int Likes { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main()
    {
        Post post1 = new Post
        {
            Author = "Артур",
            Likes = 100,
            Text = "Первый пост"
        };

        Post post2 = new Post
        {
            Author = "Елизавета",
            Likes = 50,
            Text = "Второй пост"
        };

        if (post1.Likes > post2.Likes)
        {
            Console.WriteLine($"Больше лайков: {post1.Author}");
        }
        else
        {
            Console.WriteLine($"Больше лайков: {post2.Author}");
        }

        if (post1.Likes < post2.Likes)
        {
            Console.WriteLine($"Наименьшее кол-во лайков: {post1.Text}");
        }
        else
        {
            Console.WriteLine($"Наименьшее кол-во лайков: {post2.Text}");
        }
    }
}
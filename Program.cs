using System;

namespace bookk
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public Book(string title, string author, string content)
        {
            this.title.title = title;
            this.author.author = author;
            this.content.content = content;
        }
        public void showTitle()
        {
            title.Show();
        }
        public void showAuthor()
        {
            author.Show();
        }
        public void showContent()
        {
            content.Show();
        }
    }
    class Title
    {
        public string title { get; set; }
        public void Show()
        {
            Console.WriteLine($"Title: {title}");
        }
    }
    class Author
    {
        public string author { get; set; }
        public void Show()
        {
            Console.WriteLine($"Author: {author}");
        }
    }
    class Content 
    {
        public string content { get; set; }
        public void Show()
        {
            Console.WriteLine($"Content: {content}");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] author = {"Mark Tven", "Jorj Owell", "Anna Todd", "Roberto Keosaky"};
            string[] title = {"Tom Soyerning", "1984", "After", "Rich dad poor dad"};
            string[] content = {"Fiction", "Fantasy", "Romance", "Business & Finance"};
            for (int  i=0; i<author.Length; i++)
            {
                Book book = new Book(title[i], author[i], content[i]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Book №:{i+1}:");
                Console.ForegroundColor = ConsoleColor.Red;
                book.showTitle();
                Console.ForegroundColor = ConsoleColor.Yellow;
                book.showAuthor();
                Console.ForegroundColor = ConsoleColor.Green;
                book.showContent();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

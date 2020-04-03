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
            
        }
    }
}

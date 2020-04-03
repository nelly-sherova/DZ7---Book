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
        private string title { get; set; }
    }
    class Author
    {
        private string author { get; set; }
    }
    class Content 
    {
        private string content { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

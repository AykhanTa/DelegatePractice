namespace DelegatePractice.Entities
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Book(string name,string author)
        {
            Name = name;
            AuthorName = author;
        }
    }
}

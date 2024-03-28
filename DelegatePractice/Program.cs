using DelegatePractice.Entities;

namespace DelegatePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //Person person = new Person("Ayxan","Tagizade","Baku",1500);
            //Person person2 = new Person("Kamran","Bakhsaliyev","Baku",2500);
            //Person person3= new Person("Akif","Tagiyev","Baku",500);
            //Person person4= new Person("Tahmasib","Tagiyev","Baku",900);

            //List<Person> list = new List<Person>();
            //list.Add(person);
            //list.Add(person2);
            //list.Add(person3);
            //list.Add(person4);
            //Predicate<Person> predicate = p => p.Salary > 1000;
            //Info(predicate,list);
            //static void Info(Predicate<Person> method,List<Person> persons)
            //{
            //    var result=persons.FindAll(method);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Task2
            Book book = new("Yeddi Gozal", "Nizami");
            Book book2 = new("Belcika avcarkasi", "Elxan Elatli");
            Book book3 = new("Isgandarname", "Nizami");
            Book book4 = new("Serq Ekspresinde Qetl", "Aqata Kristi");

            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            Predicate<Book> predicate = p => p.AuthorName == "Nizami";
            Console.WriteLine(Count(predicate,books));
            static int Count(Predicate<Book> predicate, List<Book> books)
            {
                var result=books.FindAll(predicate);
                return result.Count;
            }
            #endregion
        }
    }
}

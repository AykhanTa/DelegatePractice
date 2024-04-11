using DelegatePractice.Entities;

namespace DelegatePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //Person person = new Person("Ayxan", "Tagizade", "Baku", 1500);
            //Person person2 = new Person("Kamran", "Bakhsaliyev", "Baku", 2500);
            //Person person3 = new Person("Akif", "Tagiyev", "Baku", 500);
            //Person person4 = new Person("Tahmasib", "Tagiyev", "Baku", 900);

            //List<Person> list = new List<Person>() {person,person2,person3,person4 };
            //Predicate<Person> predicate = p => p.Salary > 1000;
            //Info(predicate, list);
            //static void Info(Predicate<Person> method, List<Person> persons)
            //{
            //    var result = persons.FindAll(method);
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Task2
            //Book book = new("Yeddi Gozal", "Nizami");
            //Book book2 = new("Belcika avcarkasi", "Elxan Elatli");
            //Book book3 = new("Isgandarname", "nizami");
            //Book book4 = new("Serq Ekspresinde Qetl", "Aqata Kristi");

            //List<Book> books = new List<Book>() { book, book2, book3, book4 };
            //Console.WriteLine(Count(p => p.AuthorName.Equals("Nizami",StringComparison.OrdinalIgnoreCase), books));
            //static int Count(Predicate<Book> predicate, List<Book> books)
            //{
            //    return books.FindAll(predicate).Count;
            //}
            #endregion

            #region Task3
            Employee employee = new Employee("Ayxan", 1500, 21);
            Employee employee2 = new Employee("Kamran", 3500, 45);
            Employee employee3 = new Employee("Akif", 500, 19);
            Employee employee4 = new Employee("Tahmasib", 3000, 26);

            List<Employee> employees = new List<Employee>() {employee,employee2,employee3,employee4};
            var newList = employees.FindAll(e => e.Age >= 20 && e.Age <= 40);
            var sumSalary=newList.Sum(e => e.Salary);
            var minSalary=newList.Min(e => e.Salary);
            var maxSalary=newList.Max(e => e.Salary);
            var avgSalary=newList.Average(e => e.Salary);
            Console.WriteLine(sumSalary);
            Console.WriteLine(minSalary);
            Console.WriteLine(maxSalary);
            Console.WriteLine(avgSalary);

            #endregion

        }
    }
}

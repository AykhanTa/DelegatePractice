namespace DelegatePractice.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public Person(string name,string surname,string address,int salary)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Salary = salary;            
        }
        public override string ToString()
        {
            return $"Name:{Name} Surname:{Surname} Address:{Address}";
        }
    }
}

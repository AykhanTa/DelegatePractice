namespace DelegatePractice.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public Employee(string name, int salary, int age)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }
    }
}

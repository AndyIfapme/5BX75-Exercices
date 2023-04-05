namespace Theory_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher
            {
                Firstname = "Andy",
                Lastname = "Bianco",
                Birth = new DateTime(1990, 01, 01),
                Salary = 5000
            };

            var student1 = new Student
            {
                Firstname = "Christophe",
                Lastname = "Lacroix",
                Birth = new DateTime(1980,01,01),
                ClassYear = "5BX75"
            };

            ReadData(teacher);
            Console.WriteLine(teacher.GetAge());
            Console.WriteLine("______________________________");
            ReadData(student1);
            Console.WriteLine(student1.GetAge());
        }

        private static void ReadData (Person person)
        {
            //Console.WriteLine(person.Firstname);
            //Console.WriteLine(person.Lastname);
            Console.WriteLine(person.FullName());
            Console.WriteLine(person.Birth);

            if (person is Student student)
            {
                Console.WriteLine(student.ClassYear);
            }
            else if (person is Teacher teacher)
            {
                Console.WriteLine(teacher.Salary);
            }

        }
    }
}
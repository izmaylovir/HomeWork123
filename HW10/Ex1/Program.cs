namespace EmployeeManagement
{
    public enum Position
    {
        Manager,
        Developer,
        Designer,
        Analyst,
        Intern
    }

    public class Employee
    {
        private string fullName;
        private int id;
        private Position position;
        private decimal salary;
        private DateTime birthDate;
        private DateTime hireDate;

        public Employee()
        {
        }

        public Employee(string fullName, int id, Position position, decimal salary, DateTime birthDate, DateTime hireDate)
        {
            FullName = fullName;
            Id = id;
            Position = position;
            Salary = salary;
            BirthDate = birthDate;
            HireDate = hireDate;
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ФИО не может быть пустым.");
                }
                fullName = value;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Заработная плата не может быть отрицательной.");
                }
                salary = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                if (value < birthDate)
                {
                    throw new ArgumentException("Дата приема на работу не может быть раньше даты рождения.");
                }
                hireDate = value;
            }
        }

        public string GetInfo()
        {
            return $"ФИО: {FullName}, ID: {Id}, Должность: {Position}, Заработная плата: {Salary}, " +
                   $"Дата рождения: {BirthDate.ToShortDateString()}, Дата приема на работу: {HireDate.ToShortDateString()}";
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Иван Иванович Петров", 1, Position.Manager, 60000m, new DateTime(1990, 5, 20), new DateTime(2020, 1, 15));
            Employee employee2 = new Employee("Анна Сергеевна Смирнова", 2, Position.Developer, 50000m, new DateTime(1992, 8, 11), new DateTime(2021, 3, 10));
            Employee employee3 = new Employee("Сергей Александрович Кузнецов", 3, Position.Designer, -10000m, new DateTime(1995, 12, 5), new DateTime(2022, 7, 1));
            Employee employee4 = new Employee("Ольга Викторовна Федорова", 4, Position.Analyst, 65000m, new DateTime(1988, 3, 30), new DateTime(2019, 11, 25));
            Employee employee5 = new Employee("Дмитрий Павлович Соловьев", 5, Position.Intern, 30000m, new DateTime(2002, 1, 15), new DateTime(2023, 6, 18));
            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
                Console.WriteLine($"Возраст: {employee.GetAge()} лет");
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}

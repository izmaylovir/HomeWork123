class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
}

class EmployeeService
{
    public List<string> GetAllEmployeeNames(Dictionary<int, Employee> employees)
    {
        return employees.Values.Select(e => e.Name).ToList();
    }

    public Employee GetEmployeeWithMaxSalary(Dictionary<int, Employee> employees)
    {
        return employees.Values.OrderByDescending(e => e.Salary).First();
    }

    public Employee GetEmployeeWithMinSalary(Dictionary<int, Employee> employees)
    {
        return employees.Values.OrderBy(e => e.Salary).First();
    }

    public Dictionary<int, Employee> SortEmployeesByName(Dictionary<int, Employee> employees)
    {
        return employees.OrderBy(e => e.Value.Name).ToDictionary(e => e.Key, e => e.Value);
    }

    public void PrintAllEmployeesInfo(Dictionary<int, Employee> employees)
    {
        foreach (var employee in employees.Values)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>
        {
            { 1, new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 50000 } },
            { 2, new Employee { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 60000 } },
            { 3, new Employee { Id = 3, Name = "Bob Johnson", Position = "Analyst", Salary = 45000 } }
        };

        EmployeeService employeeService = new EmployeeService();

        Console.WriteLine("All Employee Names:");
        var allEmployeeNames = employeeService.GetAllEmployeeNames(employees);
        foreach (var name in allEmployeeNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nEmployee with Maximum Salary:");
        var maxSalaryEmployee = employeeService.GetEmployeeWithMaxSalary(employees);
        Console.WriteLine($"ID: {maxSalaryEmployee.Id}, Name: {maxSalaryEmployee.Name}, Position: {maxSalaryEmployee.Position}, Salary: {maxSalaryEmployee.Salary}");

        Console.WriteLine("\nEmployee with Minimum Salary:");
        var minSalaryEmployee = employeeService.GetEmployeeWithMinSalary(employees);
        Console.WriteLine($"ID: {minSalaryEmployee.Id}, Name: {minSalaryEmployee.Name}, Position: {minSalaryEmployee.Position}, Salary: {minSalaryEmployee.Salary}");

        Console.WriteLine("\nEmployees Sorted by Name:");
        var sortedEmployees = employeeService.SortEmployeesByName(employees);
        foreach (var employee in sortedEmployees.Values)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }

        Console.WriteLine("\nAll Employees Info:");
        employeeService.PrintAllEmployeesInfo(employees);
    }
}

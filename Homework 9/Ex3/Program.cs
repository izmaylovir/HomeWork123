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
1
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }
    public int Age { get; private set; }

    public Employee(string name, decimal salary, int age)
    {
        Name = name;
        Salary = salary;
        Age = age;
    }
}

public class EmployeeService
{
    public List<Employee> GetEmployeesWithMaxSalary(List<Employee> employees)
    {
        if (employees == null || employees.Count == 0) return new List<Employee>();

        decimal maxSalary = employees.Max(e => e.Salary);
        return employees.Where(e => e.Salary == maxSalary).ToList();
    }

    public List<Employee> GetEmployeesWithMinSalary(List<Employee> employees)
    {
        if (employees == null || employees.Count == 0) return new List<Employee>();

        decimal minSalary = employees.Min(e => e.Salary);
        return employees.Where(e => e.Salary == minSalary).ToList();
    }

    public List<Employee> GetEmployeesWithMaxAge(List<Employee> employees)
    {
        if (employees == null || employees.Count == 0) return new List<Employee>();

        int maxAge = employees.Max(e => e.Age);
        return employees.Where(e => e.Age == maxAge).ToList();
    }

    public List<Employee> GetEmployeesWithMinAge(List<Employee> employees)
    {
        if (employees == null || employees.Count == 0) return new List<Employee>();

        int minAge = employees.Min(e => e.Age);
        return employees.Where(e => e.Age == minAge).ToList();
    }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee("Alice", 50000, 25),
            new Employee("Bob", 60000, 30),
            new Employee("Charlie", 50000, 30),
            new Employee("David", 40000, 22),
            new Employee("Eve", 60000, 28)
        };

        EmployeeService employeeService = new EmployeeService();

        var maxSalaryEmployees = employeeService.GetEmployeesWithMaxSalary(employees);
        Console.WriteLine("Employees with maximum salary:");
        foreach (var emp in maxSalaryEmployees)
        {
            Console.WriteLine(emp.Name);
        }

        var minSalaryEmployees = employeeService.GetEmployeesWithMinSalary(employees);
        Console.WriteLine("\nEmployees with minimum salary:");
        foreach (var emp in minSalaryEmployees)
        {
            Console.WriteLine(emp.Name);
        }

        var maxAgeEmployees = employeeService.GetEmployeesWithMaxAge(employees);
        Console.WriteLine("\nEmployees with maximum age:");
        foreach (var emp in maxAgeEmployees)
        {
            Console.WriteLine(emp.Name);
        }

        var minAgeEmployees = employeeService.GetEmployeesWithMinAge(employees);
        Console.WriteLine("\nEmployees with minimum age:");
        foreach (var emp in minAgeEmployees)
        {
            Console.WriteLine(emp.Name);
        }
    }
}
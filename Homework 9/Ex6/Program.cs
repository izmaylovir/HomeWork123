class Company
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int NumberOfEmployees { get; set; }
}

class CompanyService
{
    private List<Company> companies = new List<Company>();

    public void AddCompany(Company company)
    {
        companies.Add(company);
        Console.WriteLine($"Company '{company.Name}' added to the list.");
    }

    public void RemoveCompanyById(int companyId)
    {
        Company companyToRemove = companies.Find(c => c.Id == companyId);
        if (companyToRemove != null)
        {
            companies.Remove(companyToRemove);
            Console.WriteLine($"Company with id {companyId} removed from the list.");
        }
        else
        {
            Console.WriteLine($"Company with id {companyId} not found in the list.");
        }
    }

    public int FindCompanyIdByName(string companyName)
    {
        Company company = companies.Find(c => c.Name == companyName);
        if (company != null)
        {
            return company.Id;
        }
        return -1;
    }

    public void SortByNumberOfEmployees()
    {
        companies.Sort((c1, c2) => c1.NumberOfEmployees.CompareTo(c2.NumberOfEmployees));
    }

    public void PrintAllCompanies()
    {
        foreach (var company in companies)
        {
            Console.WriteLine($"Name: {company.Name}, ID: {company.Id}, Employees: {company.NumberOfEmployees}");
        }
    }

    public IEnumerator<Company> GetEnumerator()
    {
        foreach (var company in companies)
        {
            yield return company;
        }
    }
}

class Program
{
    static void Main()
    {
        CompanyService companyService = new CompanyService();

        Company company1 = new Company { Name = "Company A", Id = 1, NumberOfEmployees = 100 };
        Company company2 = new Company { Name = "Company B", Id = 2, NumberOfEmployees = 50 };

        companyService.AddCompany(company1);
        companyService.AddCompany(company2);

        Console.WriteLine("All Companies:");
        companyService.PrintAllCompanies();

        int companyId = companyService.FindCompanyIdByName("Company B");
        Console.WriteLine($"ID of Company B: {companyId}");

        companyService.SortByNumberOfEmployees();

        Console.WriteLine("Companies sorted by number of employees:");
        companyService.PrintAllCompanies();

        companyService.RemoveCompanyById(1);

        Console.WriteLine("After removing Company A:");
        companyService.PrintAllCompanies();
    }
}
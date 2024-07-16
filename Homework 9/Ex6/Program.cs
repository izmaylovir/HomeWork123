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

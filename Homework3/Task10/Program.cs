class Company
{
    public string Name;
    public string Description;
    public int StaffCount;
}

class Program
{
    static void Main()
    {
        Company company1 = new Company();
        company1.Name = "Want2Learn";
        company1.Description = "Education company";
        company1.StaffCount = 50;

        Company company2 = new Company();
        company2.Name = "XYZ Corp";
        company2.Description = "Tech company";
        company2.StaffCount = 100;

        Company company3 = new Company();
        company3.Name = "Want2Learn";
        company3.Description = "Education company";
        company3.StaffCount = 75;

        Company company4 = new Company();
        company4.Name = "ABC Inc";
        company4.Description = "Consulting company";
        company4.StaffCount = 60;

        int totalStaffCount = 0;
        int want2LearnCount = 0;

        if (company1.Name == "Want2Learn")
        {
            totalStaffCount += company1.StaffCount;
            want2LearnCount++;
        }
        if (company2.Name == "Want2Learn")
        {
            totalStaffCount += company2.StaffCount;
            want2LearnCount++;
        }
        if (company3.Name == "Want2Learn")
        {
            totalStaffCount += company3.StaffCount;
            want2LearnCount++;
        }
        if (company4.Name == "Want2Learn")
        {
            totalStaffCount += company4.StaffCount;
            want2LearnCount++;
        }

        double averageStaffCount = (double)totalStaffCount / want2LearnCount;

        Console.WriteLine($"Среднее количество сотрудников в компаниях с названием 'Want2Learn': {averageStaffCount}");
    }
}
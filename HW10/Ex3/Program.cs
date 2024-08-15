public enum EducationType
{
    Budget,
    Commercial,
    Target
}

public class Student
{
    private string fullName;
    private decimal scholarship;
    private int groupNumber;
    private EducationType educationType;
    private int enrollmentYear;
    private int? expulsionYear; 

    public Student()
    {
        fullName = string.Empty;
        scholarship = 0;
        groupNumber = 0;
        educationType = EducationType.Budget;
        enrollmentYear = DateTime.Now.Year; 
        expulsionYear = null; 
    }

    public Student(string fullName, decimal scholarship, int groupNumber, EducationType educationType, int enrollmentYear, int? expulsionYear)
    {
        FullName = fullName;
        Scholarship = scholarship;
        GroupNumber = groupNumber;
        EducationType = educationType;
        EnrollmentYear = enrollmentYear;
        ExpulsionYear = expulsionYear;
    }

    public string FullName
    {
        get => fullName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ФИО не может быть пустым.");
            fullName = value;
        }
    }

    public decimal Scholarship
    {
        get => scholarship;
        set => scholarship = value;
    }

    public int GroupNumber
    {
        get => groupNumber;
        set
        {
            if (value < 0)
                throw new ArgumentException("Номер группы не может быть отрицательным.");
            groupNumber = value;
        }
    }

    public EducationType EducationType
    {
        get => educationType;
        set => educationType = value;
    }

    public int EnrollmentYear
    {
        get => enrollmentYear;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Год приказа о зачислении должен быть положительным числом.");
            enrollmentYear = value;
        }
    }

    public int? ExpulsionYear
    {
        get => expulsionYear;
        set
        {
            if (value.HasValue && value < enrollmentYear)
                throw new ArgumentException("Год приказа об отчислении не может быть меньше года приказа о зачислении.");
            expulsionYear = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student();
            Console.WriteLine("Студент 1:");
            DisplayStudentInfo(student1);
            Student student2 = new Student("Иванов Иван Иванович", 15000m, 101, EducationType.Budget, 2021, null);
            Console.WriteLine("\nСтудент 2:");
            DisplayStudentInfo(student2);
            student2.FullName = "Петров Петр Петрович";
            student2.Scholarship = 20000m;
            student2.GroupNumber = 102;
            student2.ExpulsionYear = 2023; 

            Console.WriteLine("\nОбновленная информация о студенте 2:");
            DisplayStudentInfo(student2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void DisplayStudentInfo(Student student)
    {
        Console.WriteLine($"ФИО: {student.FullName}");
        Console.WriteLine($"Стипендия: {student.Scholarship} руб.");
        Console.WriteLine($"Номер группы: {student.GroupNumber}");
        Console.WriteLine($"Тип обучения: {student.EducationType}");
        Console.WriteLine($"Год зачисления: {student.EnrollmentYear}");
        Console.WriteLine($"Год отчисления: {(student.ExpulsionYear.HasValue ? student.ExpulsionYear.Value.ToString() : "Не указано")}");
    }
}
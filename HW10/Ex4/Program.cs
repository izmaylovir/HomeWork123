public enum EducationType
{
    FullTime,
    PartTime,
    DistanceLearning
}

public class Student
{
    public string Name { get; set; }
    public double Stipendia { get; set; }
    public EducationType EducationType { get; set; }
    public int YearOfAdmission { get; set; }
    public int? YearOfExpulsion { get; set; } 
}

public class StudentService
{
    public List<Student> GetStudentsWithStipendia(List<Student> students)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.Stipendia > 0)
            {
                result.Add(student);
            }
        }
        return result;
    }
    public List<Student> GetStudentsByEducationType(List<Student> students, EducationType educationType)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.EducationType == educationType)
            {
                result.Add(student);
            }
        }
        return result;
    }
    public List<Student> GetStudentsByYearOfAdmission(List<Student> students, int year)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.YearOfAdmission == year)
            {
                result.Add(student);
            }
        }
        return result;
    }
    public List<Student> GetStudentsByYearOfAdmissionRange(List<Student> students, int startYear, int endYear)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.YearOfAdmission >= startYear && student.YearOfAdmission <= endYear)
            {
                result.Add(student);
            }
        }
        return result;
    }
    public List<Student> GetStudentsByYearOfExpulsion(List<Student> students, int year)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.YearOfExpulsion.HasValue && student.YearOfExpulsion.Value == year)
            {
                result.Add(student);
            }
        }
        return result;
    }
    public List<Student> GetStudentsByYearOfExpulsionRange(List<Student> students, int startYear, int endYear)
    {
        List<Student> result = new List<Student>();
        foreach (var student in students)
        {
            if (student.YearOfExpulsion.HasValue &&
                student.YearOfExpulsion.Value >= startYear &&
                student.YearOfExpulsion.Value <= endYear)
            {
                result.Add(student);
            }
        }
        return result;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
 
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Stipendia = 1500, EducationType = EducationType.FullTime, YearOfAdmission = 2020, YearOfExpulsion = null },
            new Student { Name = "Bob", Stipendia = 0, EducationType = EducationType.PartTime, YearOfAdmission = 2019, YearOfExpulsion = null },
            new Student { Name = "Charlie", Stipendia = 1200, EducationType = EducationType.DistanceLearning, YearOfAdmission = 2021, YearOfExpulsion = 2023 },
            new Student { Name = "David", Stipendia = 800, EducationType = EducationType.FullTime, YearOfAdmission = 2022, YearOfExpulsion = null },
            new Student { Name = "Eve", Stipendia = 0, EducationType = EducationType.PartTime, YearOfAdmission = 2020, YearOfExpulsion = null }
        };

        StudentService studentService = new StudentService();
        List<Student> studentsWithStipendia = studentService.GetStudentsWithStipendia(students);
        Console.WriteLine("Students with stipendia:");
        foreach (var student in studentsWithStipendia)
        {
            Console.WriteLine(student.Name);
        }
        List<Student> fullTimeStudents = studentService.GetStudentsByEducationType(students, EducationType.FullTime);
        Console.WriteLine("\nFull-time students:");
        foreach (var student in fullTimeStudents)
        {
            Console.WriteLine(student.Name);
        }
        List<Student> studentsAdmittedIn2020 = studentService.GetStudentsByYearOfAdmission(students, 2020);
        Console.WriteLine("\nStudents admitted in 2020:");
        foreach (var student in studentsAdmittedIn2020)
        {
            Console.WriteLine(student.Name);
        }
        List<Student> studentsAdmittedBetween2019And2021 = studentService.GetStudentsByYearOfAdmissionRange(students, 2019, 2021);
        Console.WriteLine("\nStudents admitted between 2019 and 2021:");
        foreach (var student in studentsAdmittedBetween2019And2021)
        {
            Console.WriteLine(student.Name);
        }
        List<Student> expelledStudentsIn2023 = studentService.GetStudentsByYearOfExpulsion(students, 2023);
        Console.WriteLine("\nStudents expelled in 2023:");
        foreach (var student in expelledStudentsIn2023)
        {
            Console.WriteLine(student.Name);
        }
        List<Student> expelledStudentsBetween2022And2023 = studentService.GetStudentsByYearOfExpulsionRange(students, 2022, 2023);
        Console.WriteLine("\nStudents expelled between 2022 and 2023:");
        foreach (var student in expelledStudentsBetween2022And2023)
        {
            Console.WriteLine(student.Name);
        }
    }
}
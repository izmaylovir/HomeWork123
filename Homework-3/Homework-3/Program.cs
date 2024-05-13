//Задание 1 
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}

class Program 
{
    static void Main()
    {
        Person person1 = new Person
        {
            Name = "Артур",
            Age = 18,
            Weight = 69
        };

        Person person2 = new Person
        {
            Name = "Елизавета",
            Age = 19,
            Weight = 42
        };

        Person MinWeight = person1.Weight < person2.Weight ? person1 : person2;
        Person MinAge = person1.Age < person2.Age ? person1 : person2;
        Console.WriteLine($"Человек с наименьшим весом: {MinWeight.Name}");
        Console.WriteLine($"Человек с наименьшим возрастом: {MinAge.Name}");
    }
}

//Задание 2 
struct Time
{
    public int Hour;
    public int Minute;
    public int Second;
}

class Program1
{
    static void Main()
    {
        Time currentTime;
        currentTime.Hour = 12;
        currentTime.Minute = 30;
        currentTime.Second = 45;

        bool isTimeValid = CheckTime(currentTime);
        Console.WriteLine(isTimeValid);
    }

    static bool CheckTime(Time time)
    {
        if (time.Hour >= 0 && time.Hour < 24 && time.Minute >= 0 && time.Minute < 60 && time.Second >= 0 && time.Second < 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
//Задание 3 
enum MessageStatus
{
    Sent,
    Delivered,
    Read
}

class Program2
{
    static void Main()
    {
        MessageStatus status = MessageStatus.Delivered;

        switch (status)
        {
            case MessageStatus.Sent:
                Console.WriteLine("Сообщение отправлено");
                break;
            case MessageStatus.Delivered:
                Console.WriteLine("Сообщение доставлено");
                break;
            case MessageStatus.Read:
                Console.WriteLine("Сообщение прочитано");
                break;
            default:
                Console.WriteLine("Неизвестный статус сообщения");
                break;
        }
    }
}
// Задание 4 

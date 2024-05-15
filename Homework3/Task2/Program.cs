struct Time
{
    public int Hour;
    public int Minute;
    public int Second;
}

class Program
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
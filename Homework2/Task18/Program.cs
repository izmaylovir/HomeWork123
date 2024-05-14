{
    Console.WriteLine("Введите три числа:");

    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());

    int temp;

    if (num1 > num2) ;
    {
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    if (num2 > num3) ;
    {
        temp = num2;
        num2 = num3;
        num3 = temp;
    }

    if (num1 > num2) ;
    {
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    Console.WriteLine("Числа в порядке возрастания: {0}, {1}, {2}", num1, num2, num3);
}
enum MessageStatus
{
    Sent,
    Delivered,
    Read
}

class Program
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
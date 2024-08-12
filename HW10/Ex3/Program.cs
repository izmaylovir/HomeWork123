public enum ApartmentType
{
    Studio,
    OneRoom,
    TwoRooms,
    ThreeRooms,
    FourRooms,
    Other
}

public class FlatWithAccessorMethods
{
    private int id;
    private string apartmentNumber;
    private double area;
    private string ownerFullName;
    private ApartmentType apartmentType;

    public FlatWithAccessorMethods(int id, string apartmentNumber, double area, string ownerFullName, ApartmentType apartmentType)
    {
        this.id = id;
        this.apartmentNumber = apartmentNumber;
        this.area = area;
        this.ownerFullName = ownerFullName;
        this.apartmentType = apartmentType;
    }
    public int GetId() => id;
    public void SetId(int value) => id = value;

    public string GetApartmentNumber() => apartmentNumber;
    public void SetApartmentNumber(string value) => apartmentNumber = value;

    public double GetArea() => area;
    public void SetArea(double value) => area = value;

    public string GetOwnerFullName() => ownerFullName;
    public void SetOwnerFullName(string value) => ownerFullName = value;

    public ApartmentType GetApartmentType() => apartmentType;
    public void SetApartmentType(ApartmentType value) => apartmentType = value;
}

public class FlatWithAutoProperties
{
    public int Id { get; set; }
    public string ApartmentNumber { get; set; }
    public double Area { get; set; }
    public string OwnerFullName { get; set; }
    public ApartmentType ApartmentType { get; set; }

    public FlatWithAutoProperties(int id, string apartmentNumber, double area, string ownerFullName, ApartmentType apartmentType)
    {
        Id = id;
        ApartmentNumber = apartmentNumber;
        Area = area;
        OwnerFullName = ownerFullName;
        ApartmentType = apartmentType;
    }
}

public class FlatWithProperties
{
    private int id;
    private string apartmentNumber;
    private double area;
    private string ownerFullName;
    private ApartmentType apartmentType;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string ApartmentNumber
    {
        get { return apartmentNumber; }
        set { apartmentNumber = value; }
    }

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    public string OwnerFullName
    {
        get { return ownerFullName; }
        set { ownerFullName = value; }
    }

    public ApartmentType ApartmentType
    {
        get { return apartmentType; }
        set { apartmentType = value; }
    }

    public FlatWithProperties(int id, string apartmentNumber, double area, string ownerFullName, ApartmentType apartmentType)
    {
        Id = id;
        ApartmentNumber = apartmentNumber;
        Area = area;
        OwnerFullName = ownerFullName;
        ApartmentType = apartmentType;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var flat1 = new FlatWithAccessorMethods(1, "101", 45.5, "Иванов Иван", ApartmentType.OneRoom);
        Console.WriteLine($"Квартира: {flat1.GetApartmentNumber()}, Владелец: {flat1.GetOwnerFullName()}");
        var flat2
= new FlatWithAutoProperties(2, "202", 60.0, "Петров Петр", ApartmentType.TwoRooms);
        Console.WriteLine($"Квартира: {flat2.ApartmentNumber}, Владелец: {flat2.OwnerFullName}");

   
        var flat3 = new FlatWithProperties(3, "303", 75.0, "Сидоров Сидор", ApartmentType.ThreeRooms);
        Console.WriteLine($"Квартира: {flat3.ApartmentNumber}, Владелец: {flat3.OwnerFullName}");
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static Person[] RemovePersons(Person[] arr, int startIndex, int endIndex)
    {
        Person[] newArr = arr.Where((person, idx) => idx < startIndex || idx > endIndex).ToArray();
        return newArr;
    }
}
public class GymMember
{
    public string Name { get; set; }
    public int Visits { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Visits: {Visits}");
    }
}

public class Gym
{
    private List<GymMember> members = new List<GymMember>();

    public void AddMember(GymMember member)
    {
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' added to the gym.");
    }

    public void RemoveMember(string name)
    {
        GymMember memberToRemove = members.Find(m => m.Name == name);
        if (memberToRemove != null)
        {
            members.Remove(memberToRemove);
            Console.WriteLine($"Member '{name}' removed from the gym.");
        }
        else
        {
            Console.WriteLine($"Member '{name}' not found in the gym.");
        }
    }

    public void UpdateVisits(string name, int newVisits)
    {
        GymMember memberToUpdate = members.Find(m => m.Name == name);
        if (memberToUpdate != null)
        {
            memberToUpdate.Visits = newVisits;
            Console.WriteLine($"Visits for member '{name}' updated to {newVisits}.");
        }
        else
        {
            Console.WriteLine($"Member '{name}' not found in the gym.");
        }
    }
}

class Program
{
    static void Main()
    {
        Gym gym = new Gym();

        GymMember member1 = new GymMember { Name = "Alice", Visits = 10 };
        GymMember member2 = new GymMember { Name = "Bob", Visits = 5 };

        gym.AddMember(member1);
        gym.AddMember(member2);

        gym.UpdateVisits("Alice", 12);
        gym.RemoveMember("Bob");
    }
}

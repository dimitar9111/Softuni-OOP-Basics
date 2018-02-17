using System.Collections.Generic;
using System.Linq;

public class Family
{
    public Family()
    {
        this.Members = new List<Person>();
    }

    public List<Person> Members { get; }

    public void AddMember(Person member)
    {
        this.Members.Add(member);
    }

    public Person GetOldestMember()
    {
        var oldestMember = this.Members
            .OrderByDescending(m => m.Age)
            .FirstOrDefault();
        return oldestMember;
    }
}

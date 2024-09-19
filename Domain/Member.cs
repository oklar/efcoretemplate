namespace MemberPlatform.Domain;

public class Member
{
    public Guid Id { get; init; }
    public string Name { get; init; }

    public Member(string name, Guid? id = null)
    {
        Name = name;
        Id = id ?? Guid.NewGuid();
    }

    private Member() { }
}

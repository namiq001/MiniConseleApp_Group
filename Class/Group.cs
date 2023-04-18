namespace Test.Class;

public class Group
{
    private static int _id;
    public int Id { get; set; }
    public string GroupName { get; set; }
    public Group(string groupName)
    {
        _id++;
        Id = _id;
        GroupName = groupName;
    }
}

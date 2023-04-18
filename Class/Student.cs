namespace Test.Class;

public class Student
{
    private static int _id;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int GroupId { get; set; }
    public Student()
    {
        _id++;
        Id = _id;
    }
}

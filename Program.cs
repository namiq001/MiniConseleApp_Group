

using Test.Class;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome our Course");
            Console.WriteLine("1. Group Menu");
            Console.WriteLine("2. Student Menu");
            Console.WriteLine("0. Exit");
            List<Group> groups = new List<Group>();


            int cmd = Convert.ToInt32(Console.ReadLine());
            if (cmd == 0)
            {
                return;
            }
            if (cmd == 1)
            {
               while (true)
                {
                    Console.WriteLine("1. Create Group: ");
                    Console.WriteLine("2. Delete Group: ");
                    Console.WriteLine("3. Update Group: ");
                    Console.WriteLine("4. ShowAllGroup: ");
                    Console.WriteLine("0. Exit: ");
                    Console.WriteLine("Command daxil et:");
                    int command = Convert.ToInt32(Console.ReadLine());
                    if (command == 1)
                    {
                        while (true)
                        {
                            
                            Console.Write("Group Name: ");
                            string name = Console.ReadLine();
                            Context.groups.Add(new Group(name));
                            break;
                        }
                    }

                    if (command == 2)
                    {
                        Console.Write("Id daxil edin ve silinsin: ");
                        int intId = Convert.ToInt32(Console.ReadLine());
                        Group? findId = groups.Find(s => s.Id == intId);
                        if (findId != null)
                        {
                            throw new Exception();
                        }
                        Context.groups.Remove(findId);
                    }
                    if (command == 3)
                    {
                        List<int> newIds = new List<int>();

                        Console.Write("Id daxil edin ve adin update edin: ");
                        int intId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Adi daxil edin: ");
                        string newName = Console.ReadLine();
                        Group? findId = Context.groups.Find(s => s.Id == intId);
                        
                        if (findId == null)
                        {
                            throw new Exception();
                        }

                        findId.GroupName = newName;

                        foreach (var item in Context.groups)
                        {
                            Console.WriteLine("Group Name: " + item.GroupName);
                        }
                    }
                    if (command == 4)
                    {
                        foreach (var item in Context.groups)
                        {
                            Console.WriteLine("Group Name: " + item.GroupName);
                        }
                    }

                }
            }
        }
    }
}
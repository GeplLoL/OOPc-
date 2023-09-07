using System.Drawing;
using System.Threading.Channels;
public class Group
{
    public List<string> liiked { get; } = new List<string>();
    private readonly int _maxAmount;
    public Group(int maxAmount)
    {
        _maxAmount = maxAmount;
    }
    public bool AddMember(string _firstName, string _lastName, int _age)
    {
        string fullName= _firstName + " " + _lastName +" "+ _age;
        if (liiked.Contains(fullName)) return false;
        if (liiked.Count >= _maxAmount) return false;
        liiked.Add(fullName);
        return true;
    }
    public int GetMembersCount()
    {
        return liiked.Count;
    }
    public bool HasMember(string member)
    {
        return liiked.Contains(member);
    }
    public class chel
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _age;
        public chel(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }
        public int age { get => _age; }
        public string firstName { get => _firstName; }
        public string lastName { get => _lastName; }

        public void vivod()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }
    }
    public class Program
    {
        public static void Main()
        {
            GroupManager.ManageGroup();
        }
    }
}
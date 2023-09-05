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
    public bool AddMember(string liik)
    {
        if (liiked.Contains(liik)) return false;
        if (liiked.Count >= _maxAmount) return false; ;
        liiked.Add(liik);
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
        public chel(string firstName, string lastName,int age)
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
        Random rndage = new Random();
        int t = 1 * rndage.Next(0, 100);
        chel m1 = new chel("Hello", "John", 23);


        Console.WriteLine("Kui palju inimesed: ");
        int mutu = Convert.ToInt32(Console.ReadLine());
        Group group = new Group(mutu);
        string name = "";
        for (int i = 0; i < mutu; i++)
        {
            char theKey = Console.ReadKey().KeyChar;
            if (theKey == 'y' || theKey == 'Y')
            {
                i = mutu;
                break;
            }
            else
                {
                string Rname = Console.ReadLine();
                name = Rname;
                Console.WriteLine(group.AddMember(name));
                if (group.AddMember(name)==false)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nimi lisanud :"+name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (group.AddMember(name) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nimi ei õige:"+ name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(string.Join(", ", group.liiked));
        Console.WriteLine(group.GetMembersCount());  // 3
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Kui palju inimesed: ");
        int mutu1 = Convert.ToInt32(Console.ReadLine());
        Group bookClub = new Group(mutu1);
        for (int i = 0; i < mutu1; i++)
        {
            Console.WriteLine("Nimi: ");
            string name1 = Console.ReadLine();
            bookClub.AddMember(name1);
        }
        Console.WriteLine(string.Join(", ", bookClub.liiked));  // Albert, Samantha, Robert, Roberta
        Console.WriteLine(bookClub.HasMember("Albert"));  // True
        Console.WriteLine(bookClub.HasMember("John"));  // False
    }
}

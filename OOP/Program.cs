using OOP;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Message
{
    private readonly string _content;
    private readonly string _author;
    private readonly DateTime _time;
    private int _likes;
    public Message(string content, string author, DateTime time)
    {
        this._content = content;
        this._author = author;
        this._time = time;
    }
    public int Likes { get => _likes; }
    public DateTime Time { get => _time; }
    public string Author { get => _author; }
    public string Content { get => _content; }
    public void AddLike()
    {
        _likes++;
    }
    public double GetPopularity()
    {
        double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
        if (elapsed == 0)
        {
            return _likes;
        }
        return _likes / elapsed;
    }
    public void vivod()
    {
        Console.WriteLine(Author);
        Console.WriteLine(Content);
        Console.WriteLine(Time);
        Console.WriteLine(GetPopularity());
    }
    public string popular(double first, double second)
    {
        string res = "";
        if (first> second)
        {
            res = "First bolshe second";
        }
        else if (first < second)
        {
            res = "Second bolshe first";
        }
        return res;
    }
    public string GetPopylarityInfoN(List <Message> messages)
    {
        double popularity = 0;
        for (int i = 0; i < messages.Count; i++)
        {
            if (messages[i].GetPopularity() > popularity)
            {
                popularity = messages[i].GetPopularity();
            }
        }
        string res = "";
        return res;

    }
}
public class Program
{
    public static void Main()
    {

        List<Message> messeges = new List<Message>();
        Random rndauthor = new Random();
        Random rndcontent = new Random();
        string stroka = "Glass: ";
        switch (rndcontent.Next(2))
        {
            case 0:
                stroka += " cold";
                break;
            case 1:
                stroka += " hot";
                break;
        }
        string strokaAuthor = "Autor";
        switch (rndauthor.Next(2))
        {
            case 0:
                strokaAuthor += " Georg";
                break;
            case 1:
                strokaAuthor += " Evgeni";
                break;
        }
        int t = -1 * rndauthor.Next(0, 100);
        Console.Write("Author: ");
        string auter = Console.ReadLine();
        Console.Write("Content: ");
        string conti = Console.ReadLine();
        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.AddLike();
        m1.vivod();
        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.AddLike();
        m2.vivod();
        Message m3 = new Message(strokaAuthor.ToString(), stroka.ToString(), DateTime.Now.AddMinutes(t));
        m3.AddLike();
        m3.vivod();
        Message m4 = new Message(conti.ToString(), auter.ToString(), DateTime.Now.AddMinutes(t));
        m4.AddLike();
        m4.vivod();
        messeges.Add(m1);
        messeges.Add(m2);
        messeges.Add(m3);
        messeges.Add(m4);
        for (int i = 0; i < 1000; i++)
        {
            m2.AddLike();
        }
        Console.WriteLine(m1.popular(m1.GetPopularity(),m2.GetPopularity()));
        List<Message> List = new List<Message>();
        List.Add(m1);
        List.Add(m2);
        Console.WriteLine(m1.GetPopylarityInfoN(List));
    }
}

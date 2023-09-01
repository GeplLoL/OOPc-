using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

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
        Random rnd = new Random();
        Random rndtime = new Random();
        Random rndauthor = new Random();
        Random rndcontent = new Random();
        string stroka = "стакан";
        switch (rndcontent.Next(2))
        {
            case 0:
                stroka += " холодный";
                break;
            case 1:
                stroka += " теплый";
                break;
        }
        string strokaAuthor = "автор";
        switch (rndauthor.Next(2))
        {
            case 0:
                strokaAuthor += " Георг";
                break;
            case 1:
                strokaAuthor += " Евгений";
                break;
        }
        string strokatime = "Время";
        switch (rndauthor.Next(2))
        {
            case 0:
                strokatime += DateTime.Now.AddDays(-3);
                break;
            case 1:
                strokatime += DateTime.Now.AddDays(-10);
                break;
        }


        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.AddLike();
        m1.vivod();
        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.AddLike();
        m2.vivod();
        for (int i = 0; i < 1000; i++)
        {
            m2.AddLike();
        }
        Console.WriteLine(m2.GetPopularity());
        Console.WriteLine(m1.popular(m1.GetPopularity(),m2.GetPopularity()));
        List<Message> List = new List<Message>();
        List.Add(m1);
        List.Add(m2);
        Console.WriteLine(m1.GetPopylarityInfoN(List));
    }
}
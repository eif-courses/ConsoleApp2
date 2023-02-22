// See https://aka.ms/new-console-template for more information

using ConsoleApp2;
using System.Xml.Serialization;

Action<decimal> testinam = Dainuoju;

Func<string> bandom = GetName;

Vykdau(GetName);

 


Console.WriteLine("Hello, World!");


Spausdink spausdink = Dainuoju;

Spausdink kukuoju = (decimal param) => Console.WriteLine($"Kukuoju{param}");

Spausdink vaikstau = Vaikstau;
vaikstau(2222);
kukuoju(55);
spausdink(2);



var batman = FactoryDIP.CreatePlayerObject("Batman");


static void Vykdau(Func<string> testinam)
{
    Console.WriteLine($"{testinam()}");
}
static string GetName()
{
    return "Marius";
}
static void Dainuoju(decimal s)
{
    Console.WriteLine($"dainuoju: {s}");
}
void Vaikstau(decimal s)
{
    Console.WriteLine("vaikstau");
}


public delegate void Spausdink(decimal skaicius);

public class Player : IPlayer
{
    public string Name { get; set; }
    public decimal Expierence { get; set; }
}

public class Database : IDatabase
{
    public void SaveToDatabase(IPlayer player)
    {
        Console.WriteLine($"Player saved to db: {player.Name}");
    }
}

public class Firebase : IDatabase
{
    public void SaveToDatabase(IPlayer player)
    {
        Console.WriteLine($"Player saved to db: {player.Name}");
    }
}


public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: Activity registered: {message}");
    }
}
public class SerilogLog : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: Activity registered: {message}");
    }
}

public class Quest : IQuest
{

    ILogger logger1;
    IDatabase database1;

    public Quest(ILogger log, IDatabase db)
    {
        this.logger1 = log;
        this.database1 = db;
    }

    public string Name { get; set; }
    public decimal Reward { get; private set; }
    public IPlayer Owner { get; set; }
    public DateOnly ObtainedDate { get; private set; }

    public bool IsCompleted { get; private set; }

    public void StartQuest(DateOnly dateOnly)
    {
        ObtainedDate = dateOnly;
        logger1.Log($"Quest obtained: {dateOnly}");
    }

    public void TurnInQuest(DateOnly dateOnly)
    {
        IsCompleted = true;
        ObtainedDate = dateOnly;
        Reward += 1000;
        logger1.Log($"Hello {Name} quest completed!");
        database1.SaveToDatabase(Owner);
    }




}

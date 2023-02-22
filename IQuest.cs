// See https://aka.ms/new-console-template for more information

public interface IQuest
{
    bool IsCompleted { get; }
    string Name { get; set; }
    DateOnly ObtainedDate { get; }
    IPlayer Owner { get; set; }
    decimal Reward { get; }

    void StartQuest(DateOnly dateOnly);
    void TurnInQuest(DateOnly dateOnly);
}
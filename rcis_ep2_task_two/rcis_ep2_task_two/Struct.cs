namespace rcis_ep2_task_two;

public class Struct : IDisposable
{
    public string name { get; }
    public string surname { get; }
    public Struct() { name = "Иван"; surname = "Иванов"; }

    public Struct(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    public void Dispose()
    {
        Console.WriteLine($"Success, the code has become cleaner. ");
    }
}
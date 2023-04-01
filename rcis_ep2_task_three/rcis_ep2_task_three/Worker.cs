namespace rcis_ep2_task_three;

public class Worker
{
    public string name { get; } = "";
    public string surname { get; } = "";
    public int rate { get; }
    public int days { get; }

    public Worker(string name, string surname, int days, int rate)
    {
        this.name = name;
        this.surname = surname;
        this.days = days;
        this.rate = rate;
    }

    public void GetSalary()
    {
        Console.WriteLine($"Зарплата работника: {days + rate} рублей");
    }
}
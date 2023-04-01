namespace rcis_ep2_task_three;

public class NewWorker
{
    private string name { get; } = "";
    private string surname { get; } = "";
    private int rate { get; }
    private int days { get; }

    public string Name
    {
        get { return name;  }
    }
    
    public string Surname
    {
        get { return surname;  }
    }
    
    public int Rate
    {
        get { return rate;  }
    }
    
    public int Days
    {
        get { return days;  }
    }

    
    public NewWorker(string name, string surname, int days, int rate)
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
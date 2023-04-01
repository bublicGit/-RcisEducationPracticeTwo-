namespace rcis_ep2_task_two;

public class Counter
{
    public int counter { get; set; } = 0;

    public Counter(int number)
    {
        counter = number;
    }

    public void Increase()
    {
        ++counter;
    }
    
    public void Decrease()
    {
        --counter;
    }

    public void Print()
    {
        Console.WriteLine(counter);
    }
}
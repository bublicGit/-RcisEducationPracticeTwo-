namespace rcis_ep2_task_two;

public class Train
{
    public string nameDestination { get; } = "";
    public int trainNumber { get; }
    public DateTime timeDeparture { get; }
    public Train(string nameDestination, int number, int hour, int minute)
    {
        this.nameDestination = nameDestination;
        trainNumber = number;
        timeDeparture = new DateTime(1,1,1, hour, minute,1);
    }
}
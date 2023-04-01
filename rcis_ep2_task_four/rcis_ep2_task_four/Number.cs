namespace Program;


public class Number
{
    public List<char> numb { get; } = new List<char>();

    public Number (string numb)
    {
        this.numb.AddRange(numb.ToUpper());
    }
}
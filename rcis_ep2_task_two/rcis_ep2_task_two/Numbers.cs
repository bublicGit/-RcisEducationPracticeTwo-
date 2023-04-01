namespace rcis_ep2_task_two;

public class Numbers
{
    public int numberOne { get; set; }
    public int numberTwo { get; set; }

    public Numbers(int numberOne, int numberTwo)
    {
        this.numberOne = numberOne;
        this.numberTwo = numberTwo;
    }

    public void Print()
    {
        Console.WriteLine($"Первое число: {numberOne} \n" +
                          $"Второе число: {numberTwo}");
    }

    public void Edit(int one, int two)
    {
        this.numberOne = one;
        this.numberTwo = two;
    }

    public int Amount()
    {
        return numberOne + numberTwo;
    }

    public int Larger()
    {
        return numberOne > numberTwo ? numberOne : numberTwo;
    }
}
namespace rcis_ep2_task_three;

public class Calculation
{
    public string? calculationLine { get; set; } = "";

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine(calculationLine);
    }

    public void GetLastSymbol()
    {
        Console.WriteLine(calculationLine[calculationLine.Length - 1]);
    }

    public void DeleteLastSymbol()
    {
        string newCalculationLine = "";
        for (int i = 0; i < calculationLine.Length - 1; ++i) newCalculationLine += calculationLine[i];
        calculationLine = newCalculationLine;
    }
}
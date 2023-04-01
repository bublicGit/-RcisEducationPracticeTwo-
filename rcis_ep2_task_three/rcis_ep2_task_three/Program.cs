using System;
using rcis_ep2_task_three;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите номер задания: ");
            switch (Console.ReadLine()!)
            {
                case "1": TaskOne(); break;
                case "2": TaskTwo(); break;
                case "3": TaskThree(); break;

                default: Console.WriteLine("Такого задания нет. "); break;
            }
        }

        static void TaskOne()
        {
            Worker worker = new Worker("Роберт", "Дауни", 14, 4);
            worker.GetSalary();
        }

        static void TaskTwo()
        {
            NewWorker worker = new NewWorker("Джастин", "Бобер", 365, 10);
            Console.WriteLine($"ФИО: {worker.Name} {worker.Surname} \n");
            worker.GetSalary();
        }

        static void TaskThree()
        {
            Calculation line = new Calculation();
            
            line.SetCalculationLine("123456");
            line.SetLastSymbolCalculationLine('X');
            line.GetCalculationLine();
            line.GetLastSymbol();
            line.DeleteLastSymbol();
            line.GetCalculationLine();
        }
    }
}

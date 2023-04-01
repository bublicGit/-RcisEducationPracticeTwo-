using System;
using rcis_ep2_task_two;

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
                case "4": TaskFour(); break;
                case "5": TaskFive(); break;
                
                default: Console.WriteLine("Такого задания нет. "); break;
            }
        }

        static void TaskOne()
        {
            Student student = new Student( "Роберт", 475, 2000, 07, 29);
            student.setPointShool(4,4,5,4,5);

            int gradePointAverage = 0;
            for (int i = 0; i < 5; ++i)
            {
                gradePointAverage += student.grade[i];
            }
            gradePointAverage /= 5;

            Console.WriteLine($"Студента зовут {student.surname}, он из {student.group} группы." +
                              $"\nРодился {student.dateOfBirth.Day} {student.dateOfBirth.Month} {student.dateOfBirth.Year} года" +
                              $"\nИмеет средний балл: {gradePointAverage}");
        }

        static void TaskTwo()
        {
            Train train = new Train("Томск", 409, 13, 05);
            Console.WriteLine($"Поезд {train.nameDestination}-{train.trainNumber} отправляется в {train.timeDeparture:t}");
        }

        static void TaskThree()
        {
            Numbers number = new Numbers(10, 100);
            
            number.Print();
            Console.WriteLine("\nИзмененные значения.");
            number.Edit(100, 10);
            number.Print();
            Console.WriteLine($"Сумма чисел равна: {number.Amount()} \n" +
                              $"Наибольшее значение: {number.Larger()}");
        }
        
        static void TaskFour()
        {
            Counter counter = new Counter(1);
            counter.Print();

            for (int i = 0; i < 6; ++i)
            {
                counter.Decrease();
            }
            counter.Print();
            
            for (int i = 0; i < 15; ++i)
            {
                counter.Increase();
            }
            counter.Print();
        }
        
        static void TaskFive()
        {
            Struct? timmy = null;
            Struct? victor = null;
            Struct? ivan = null;
            
            try
            {
                timmy = new Struct("Тимми", "Булочкин");
                victor = new Struct("Виктор", "Путин");
                ivan = new Struct();
                
                Console.WriteLine($"Было три пацана: {timmy.name}, {ivan.name} и {victor.name} {victor.surname}.");
            }
            finally
            {
                timmy?.Dispose();
                victor?.Dispose();
                ivan?.Dispose();
            }
        }
    }
}

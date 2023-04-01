namespace rcis_ep2_task_two;

public class Student
{
    public string surname { get; } = "";
    public DateTime dateOfBirth { get; }
    public int group { get; }
    public List<int> grade { get; set; }

    public Student(string surname, int group, int year = 0, int month = 0, int day = 0)
    {
        this.surname = surname;
        this.group = group;
        dateOfBirth = (year != 0 && month != 0 && day != 0 ? new DateTime(year,month,day)
            : DateTime.Now);
    }
    
    public void setPointShool(int firstGrade,int secondGrade,int thirdGrade,int fourthGrade,int fifthGrade)
    {
        grade = new List<int>(5) { firstGrade, secondGrade, thirdGrade, fourthGrade, fifthGrade };
    }
}
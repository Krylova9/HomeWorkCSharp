namespace Homework3;
public class Doctor
{
    public Doctor(string name, int age, int experience, string profile) 
    {
        Name = name;
        Age = age;
        Experience = experience;
        Profile = profile;

    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }
    public string Profile { get; set; }

    public void Display()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Опыт: {Experience}, Профиль: {Profile}.");
    }

    public void CanCure(Patient patient){
        if (Experience <= 4){
            Console.WriteLine("не хватит опыта");
        }
        if (Profile != patient.Complaint){
            Console.WriteLine("не подходит по специальности");
        }
        Console.WriteLine("да сможет");
    }
}

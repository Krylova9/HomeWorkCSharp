namespace Homework3;

public class Patient {
        public Patient(string name, int age, string adress, string complaint)
        {
            Name = name;
            Age = age;
            Adress = adress;
            Complaint  = complaint ;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Complaint { get; set; }

        public void Display()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Адрес: {Adress}, Жалоба: {Complaint}");
        }
    }
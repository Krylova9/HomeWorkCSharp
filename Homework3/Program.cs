namespace Homework3;

public class Program
{
    public static void Main()
    {
        var patient1 = new Patient("Олег", 24, "Ленина", "Глаза");
            patient1.Display();

            var patient2 = new Patient("Лена", 24, "Алеутская", "Нос");
            patient2.Display();

            var doctor1 = new Doctor("Глеб", 60, 24, "Глаза");
            doctor1.Display();

            var doctor2 = new Doctor("Иван", 45, 12, "Нос");
            doctor2.Display();

            var doctor3 = new Doctor("Маргарита", 30, 5, "Глаза");
            doctor3.Display();
            CanDoctorCurePatient(doctor3,patient1);
    }  
    public static void CanDoctorCurePatient(Doctor doctor, Patient patient){
        Console.WriteLine($"сможет ли {doctor.Name} вылечить {patient.Name}");
        doctor.CanCure(patient);
    }
}


using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson","55", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand", " ");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "56","098542566", "5555-555-555", DateTime.Now, "Queen Street","Armando", "Neurologist");
            Console.WriteLine(appointmentResult2);
        }
    }
}

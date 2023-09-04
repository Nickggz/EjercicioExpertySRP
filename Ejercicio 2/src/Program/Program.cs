using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Ralf Manson","55", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand", "Neurologo");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("", "56","098542566", "5555-555-555", DateTime.Now, "Queen Street","Armando", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
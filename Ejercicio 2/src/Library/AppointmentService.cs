using System;
using System.Text;

namespace Library;

    public class AppointmentService
    {
        public static string CreateAppointment(string name, string age, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, string docSpecialist)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            
            if (ValidationService.ValidateAppointmentData(name, age, id, phoneNumber, appoinmentPlace, doctorName, docSpecialist))
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            else
            {
                string errorMessage = ErrorService.GenerateErrorMessage(name, age, id, phoneNumber, appoinmentPlace, doctorName, docSpecialist);
                stringBuilder.AppendLine(errorMessage);
            }

            return stringBuilder.ToString();
        }

    }

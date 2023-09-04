using System;
using System.Text;

namespace Library;

public class ValidationService
{
    public static bool ValidateAppointmentData(string name, string age, string id, string phoneNumber, string appoinmentPlace, string doctorName, string docSpecialist)
    {
        if (string.IsNullOrEmpty(name)||
        string.IsNullOrEmpty(age)||
        string.IsNullOrEmpty(id)||
        string.IsNullOrEmpty(phoneNumber)||
        string.IsNullOrEmpty(appoinmentPlace)||
        string.IsNullOrEmpty(doctorName)||
        string.IsNullOrEmpty(docSpecialist))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
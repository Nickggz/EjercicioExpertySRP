using System;
using System.Text;

namespace Library;

    public class ErrorService
    {
        public static string GenerateErrorMessage(string name, string age, string id, string phoneNumber, string appoinmentPlace, string doctorName, string docSpecialist)
        {
            StringBuilder errorBuilder = new StringBuilder("Unable to schedule appointment, the following errors occurred:\n");

            if (string.IsNullOrEmpty(name))
            {
                 errorBuilder.Append("- 'Name' is required\n");
            }

            if (string.IsNullOrEmpty(age))
            {
                 errorBuilder.Append("- 'Age' is required\n");
            }
            if (string.IsNullOrEmpty(id))
            {
                errorBuilder.Append("-  'id' is required\n");
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                errorBuilder.Append("-  'Phone Number' is required\n");
            }
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                errorBuilder.Append("-  'appoinmentPlace' is required\n");
            }
            if (string.IsNullOrEmpty(doctorName))
            {
                errorBuilder.Append("-  'Doctor Name' is required\n");
            }
            if (string.IsNullOrEmpty(docSpecialist))
            {
                errorBuilder.Append("-  'Doctor Specialist' is required\n");
            }
            return errorBuilder.ToString();
        }
    }


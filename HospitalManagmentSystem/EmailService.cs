using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem
{
    public static class EmailService
    {
        public static void SendEmail(string patientName, string message)
        {
            Console.WriteLine($"E-poçt gonderildi - {patientName}: {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem
{
  public static class SMSService
    {
        public static void SendSMS(string patientName, string message)
        {
            Console.WriteLine($"SMS gonderildi - {patientName}: {message}");
        }
    }
}

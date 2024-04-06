using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem
{
     public static class TelegramService
    {
        public static void SendTelegramMessage(string patientName, string message)
        {
            Console.WriteLine($"Telegram gonderildi - {patientName}: {message}");
        }
    }
}

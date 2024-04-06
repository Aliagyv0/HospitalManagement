using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem
{
    public class HospitalControl
    {
        private List<Patient> patients = new List<Patient>();

      
        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void CheckBloodTests()
        {
            foreach (var patient in patients)
            {
                if (patient.Results.Leykosit >= 70 || patient.Results.Eritrosit >= 70 || patient.Results.Kreatinin >= 70)
                {
                    NotifyDoctor(patient);
                }
            }
        }

        private void NotifyDoctor(Patient patient)
        {
           
            string message = $"Xeste : {patient.Name} ücün qan tehlili neticeleri: " +
                             $"Leykosit: {patient.Results.Leykosit}, " +
                             $"Eritrosit: {patient.Results.Eritrosit}, " +
                             $"Kreatinin: {patient.Results.Kreatinin}. " +
                             $"Xeberdarlıq: Yuksek neticeler.";

           
            EmailService.SendEmail(patient.Name, message);
            SMSService.SendSMS(patient.Name, message);
            TelegramService.SendTelegramMessage(patient.Name, message);
        }
    }

}


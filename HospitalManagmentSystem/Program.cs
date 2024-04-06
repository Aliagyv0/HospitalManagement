namespace HospitalManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient
            {
                Name = "Ali",
                Results = new BloodResults
                {
                    Leykosit = GenerateRandomValue(),
                    Eritrosit = GenerateRandomValue(),
                    Kreatinin = GenerateRandomValue()
                }
            };

            Patient patient2 = new Patient
            {
                Name = "Nigar",
                Results = new BloodResults
                {
                    Leykosit = GenerateRandomValue(),
                    Eritrosit = GenerateRandomValue(),
                    Kreatinin = GenerateRandomValue()
                }
            };

            HospitalControl control = new HospitalControl();
            control.AddPatient(patient1);
            control.AddPatient(patient2);

        
            control.CheckBloodTests();
        }

        
        static Random random = new Random();
        static int GenerateRandomValue()
        {
            return random.Next(1, 101); 
        }
   }
 }


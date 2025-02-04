using System;
namespace HospitalManagement
{
	class Patient
	{
		public static string HospitalName {get; set;}
		public static int totalPatients = 0;
		public readonly int PatientId;
		public string Name {get; set;}
		public int Age {get; set;}
		private string Ailment {get; set;}
		
		public Patient(int patientid , string name, int age , string ailment)
		{
			this.PatientId = patientid;
			this.Name = name;
			this.Age = age;
			this.Ailment = ailment;
			totalPatients++;
		}
		public static void GetTotalPatients()
		{
			Console.WriteLine("The total number of patients are: "+totalPatients);
		}
		public static void DisplayHospitalName()
		{
			Console.WriteLine("Hospital Name: "+HospitalName);
		}
		public void SetAilment(string ailment)
		{
			this.Ailment = ailment;
		}
		public string GetAilment()
		{
			return this.Ailment;
		}
		public void DisplayDetails()
		{
			if(this is Patient)
			{
				Console.WriteLine("Patient Name: "+Name);
				Console.WriteLine("Patient ID: "+PatientId);
				Console.WriteLine("Patient Age: "+Age);
				Console.WriteLine("Ailment: "+Ailment);
			}
			else
			{
				Console.WriteLine("Invalid Input");
			}
		}
	}
	class Program
	{
		static void Main()
		{
			Patient.HospitalName = "Clinic";
			Patient.DisplayHospitalName();
			Patient patient1 = new Patient( 004,"Abhinn", 22 , "Hepatitis");
			Patient patient2 = new Patient( 005,"Vedant", 22, "Corona");
			patient1.DisplayDetails();
			Patient.DisplayHospitalName();
			patient2.DisplayDetails();
			Patient.GetTotalPatients();
		}
	}
}
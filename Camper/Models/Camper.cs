using System;

namespace Camper.Models
{ 
	public class Camper
	{
		public Camper()
		{
		}

		public int Id { get; set; }

		public string CamperName { get; set; }

		public string EmergencyContact { get; set; }

		public string MedicalConditions { get; set; }
    }
}
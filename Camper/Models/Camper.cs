using System;
using System.Collections.Generic;

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

        public virtual ICollection<CamperLog> Logs { get; set; }
    }
}
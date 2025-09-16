using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camper.Models
{
    public class CamperLog
    {
        public int Id { get; set; }              // Primary key

        public int CamperId { get; set; }        // Foreign key
        public virtual Camper Camper { get; set; }  // Navigation property

        public DateTime LogDate { get; set; }    // Stores both Date & Time
        public string Incident { get; set; }     // Description of the incident
    }

}

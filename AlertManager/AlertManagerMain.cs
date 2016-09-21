using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlertManager
{
    public class AlertManagerMain
    {

    }

    /// <summary>
    /// Provides information and alerts about equipment.
    /// </summary>
    public class EquipmentAlert
    {
        interface IEquipmentAlert
        {
            string AlertEquipmentMessage { get; set; }
            string SendEquipmentAlert(string alertMessage);

            /// <summary>
            /// Conditions of the alert, such as, "Equipment is old.", "Equipment needs repair", and anything 
            /// pertaining to the condition of the equipment.
            /// </summary>
            /// <param name="alertConditions"></param>
            /// <returns></returns>
            string AlertConditions(List<string> alertConditions);

        }
    }

    /// <summary>
    /// Provides information and alerts about GPS.
    /// </summary>
    public class GPSAlert
    {

    }

    /// <summary>
    /// Provides information and alerts about Camping.
    /// </summary>
    public class CampingAlert
    {

    }

    /// <summary>
    /// Provides information and alerts about the Campsite.
    /// </summary>
    public class CampsiteAlert
    {

    }

    /// <summary>
    /// Provies information and alerts about the Camper's Log.
    /// </summary>
    public class CamperLogAlert
    {

    }

    /// <summary>
    /// Provides information and alerts about the camper's Check Gear functionality.
    /// </summary>
    public class CheckGearAlert
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentLibrary
{
    public class EquipmentModel
    {
        public List<EquipmentItem> EquipmentList { get; set; }

    }

    public class EquipmentItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }

    }
}

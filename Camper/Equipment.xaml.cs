using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EquipmentLibrary;

namespace Camper
{
    /// <summary>
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Page
    {
        public Equipment()
        {
            InitializeComponent();
        }

        public List<EquipmentLibrary.EquipmentModel> GetEquipment()
        {
            EquipmentLibrary.EquipmentModel equipmentModel = new EquipmentLibrary.EquipmentModel();

            equipmentModel.EquipmentList = new List<EquipmentItem>();

            EquipmentLibrary.EquipmentTypeEnum type = new EquipmentTypeEnum();

            // This is a test item to use, before creating a database to hold items.
            EquipmentItem item = new EquipmentItem {
                Id = 1,
                Name = "TestItem",
                Weight = 5,
                Type = "Test"
            };

            
            equipmentModel.EquipmentList.Add(item);
            

            return null;
        }
    }
}

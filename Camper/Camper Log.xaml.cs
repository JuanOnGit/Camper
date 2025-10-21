using Camper.Context;
using Camper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Camper
{
    // ...

    public partial class Camper_Log : Page
    {
        private CamperDbContext dbContext = new CamperDbContext();
        private ObservableCollection<CamperLog> camperLogs;
        public Camper_Log()
        {
            InitializeComponent();
            camperLogs = new ObservableCollection<CamperLog>(dbContext.CamperLogs.ToList());
            dataGrid.ItemsSource = camperLogs;
        }

        // Replace all instances of 'LogsDataGrid' with 'dataGrid' to match the defined field

        private void SaveLogs_Click(object sender, RoutedEventArgs e)
        {
            foreach (var row in dataGrid.Items)
            {
                if (row is CamperLog log)
                {
                    // Check if the log already exists in the database
                    var existingLog = dbContext.CamperLogs.FirstOrDefault(l => l.Id == log.Id);
                    if (existingLog != null)
                    {
                        // Update existing log
                        existingLog.LogDate = log.LogDate;
                        existingLog.Incident = log.Incident;
                        existingLog.CamperId = log.CamperId;
                    }
                    else
                    {
                        // Add new log
                        dbContext.CamperLogs.Add(log);
                    }
                }
            }

            dbContext.SaveChanges();
        }

        private void camperLog_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            e.NewItem = new CamperLog
            {
                LogDate = DateTime.Now
                // Optionally set other defaults
            };
        }
    }
}

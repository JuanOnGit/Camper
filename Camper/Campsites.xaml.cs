using System;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using APIService;

namespace Camper
{
    public partial class Campsites : Page
    {
        private static readonly HttpClient Client = new HttpClient();
        private readonly ICampsiteService service;

        public Campsites() : this(null)
        {
        }

        public Campsites(ICampsiteService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private async void Campsites_Loaded(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "Loading campsites...";
            try
            {
                var campsiteService = service ?? CreateService();
                var campsites = await campsiteService.GetCampsitesAsync(CancellationToken.None);
                CampsitesList.ItemsSource = campsites;
                StatusText.Text = campsites.Count == 0 ? "No campsites found." : string.Empty;
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException ||
                                       ex is SerializationException || ex is XmlException ||
                                       ex is InvalidOperationException)
            {
                CampsitesList.ItemsSource = null;
                StatusText.Text = "Unable to load campsites: " + ex.Message;
            }
        }

        private static ICampsiteService CreateService()
        {
            var apiKey = Environment.GetEnvironmentVariable("RIDB_API_KEY");
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new InvalidOperationException(
                    "Set RIDB_API_KEY before starting the application.");

            return new CampsiteService(Client, apiKey);
        }
    }
}

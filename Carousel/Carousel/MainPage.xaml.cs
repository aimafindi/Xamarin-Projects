using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{

    
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const string url = "https://www.montemagno.com/monkeys.json";

        private readonly HttpClient httpClient = new HttpClient();

        public ObservableCollection<Monkey> Monkeys { get; set; } = new ObservableCollection<Monkey>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var jsonstring = await httpClient.GetStringAsync(url);
            var monkeys = JsonConvert.DeserializeObject<Monkey[]>(jsonstring);
            Monkeys.Clear();
            foreach (var item in monkeys)
            {
                Monkeys.Add(item);
            }

        }
    }
}

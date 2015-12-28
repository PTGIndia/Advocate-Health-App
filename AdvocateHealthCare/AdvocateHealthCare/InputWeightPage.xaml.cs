using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AdvocateHealthCare
{

    //test
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InputWeightPage : Page
    {
        public int dateweek;

        public class WeightHelper
        {
            public string Weight { get; set; }
            public string CreatedDate { get; set; }
            public DateTime LMPDATE { get; set; }
            public int calculatedweek { get; set; }
            public DateTime dt { get; set; }
        }

        public InputWeightPage()
        {
            this.InitializeComponent();
            this.Loaded += InputWeightPag_Load;
            txtNotificationCount.Text = HomePage.unreadNotificationCount.ToString();

        }


        async void InputWeightPag_Load(object sender, RoutedEventArgs e)
        {
            try
            {
                List<WeightHelper> objWeightHelper = new List<WeightHelper>();
                //string ServiceCall = App.BASE_URL + "/api/WeightEntries/GetWeightEntries?UserId=2";
                string ServiceCall = App.BASE_URL + "/api/WeightEntries/GetWeightEntries?UserId=" + App.userId;
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(new Uri(ServiceCall));
                var jsonString = await response.Content.ReadAsStringAsync();
                JArray jobject = JArray.Parse(jsonString);



                foreach (var item in jobject)
                {
                    WeightHelper objweight = new WeightHelper();
                    objweight.CreatedDate = (string)item["CreatedDate"];
                    var stringArray = ((string)item["CreatedDate"]).Split(' ');
                    objweight.dt = Convert.ToDateTime(stringArray[1]);
                    //  objweight.CreatedDate= objweight.dt.Split;


                    objweight.Weight = (string)item["Weight"];

                    objweight.LMPDATE = (DateTime)item["LMPDATE"];
                    int dateX = (int)((objweight.dt - objweight.LMPDATE).TotalDays) / 7;//cal.GetWeekOfYear(dt, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                    objweight.calculatedweek = dateX != 0 ? dateX : 1;
                    objWeightHelper.Add(objweight);
                    dateweek = objweight.calculatedweek;
                }
                gridWeight.ItemsSource = objWeightHelper;
            }
            catch (Exception)
            {
                MessageDialog msgDialog = new MessageDialog("The required resources are not downloaded.Please check your internet connectivity. If the problem persists, please contact advocate healthcare customer care associate.", "Message");
                msgDialog.ShowAsync();
            }


        }


        private void Weightinputbutton(object sender, RoutedEventArgs e)
        {
            try
            {
                MODEL.WeightEntries weightEntries = new MODEL.WeightEntries();
                //   weightEntries.CreatedDate = Convert.ToDateTime(_WeightInputDate.Date.ToString());
                weightEntries.ProfileID = App.userId;
                weightEntries.Weight = Convert.ToDecimal(Weight.Text);
                weightEntries.LoggedInUser = "null";

                var serializedPatchDoc = JsonConvert.SerializeObject(weightEntries);
                var method = new HttpMethod("POST");
                var request = new HttpRequestMessage(method,
                     App.BASE_URL + "/api/WeightEntries/SaveWeightTrackerType")

                {
                    Content = new StringContent(serializedPatchDoc,
                    System.Text.Encoding.Unicode, "application/json")
                };
                HttpClient client = new HttpClient();
                var result = client.SendAsync(request).Result;
                client.Dispose();

                if (result.IsSuccessStatusCode == false)
                {
                    MessageDialog msgDialog = new MessageDialog("Unsucessfull", "Failure");
                    msgDialog.ShowAsync();
                }


            }

            catch (Exception ex)
            {
                MessageDialog msgDialog = new MessageDialog("The required resources are not downloaded.Please check your internet connectivity. If the problem persists, please contact advocate healthcare customer care associate.", "Message");
                msgDialog.ShowAsync();
            }
            Weight.Text = "";
            _WeightInputDate.Date = System.DateTime.Now;
            this.InputWeightPag_Load(null, null);

        }

        #region Helper class
        public class inputclass
        {

        }

        #endregion

        private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            this.Frame.Navigate(typeof(SearchPage), args.QueryText);
        }


        private void Notificationgridtapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Notifications));
        }
    }
    namespace MODEL
    {
        public class WeightEntries
        {
            public decimal? Weight { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string LoggedInUser { get; set; }
            public int WeightTrackerID { get; set; }
            public int? ProfileID { get; set; }
            public DateTime? LMPDATE { get; set; }
        }
    }

}


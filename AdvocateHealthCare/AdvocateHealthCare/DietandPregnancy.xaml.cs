using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DietandPregnancy : Page
    {
        // public static string jtapped;
        public static string qtapped;
        public DietandPregnancy()
        {
            this.InitializeComponent();
            getback.Visibility = Visibility.Collapsed;
            txtNotificationCount.Text = HomePage.unreadNotificationCount.ToString();
        }
        public class saveJouorQues
        {
            public int JournalorQuestionid { get; set; }
            public string NotesforJorQ { get; set; }
        }
        private void CloseImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (grdAddNotes.Visibility == Visibility.Visible)
            {
                grdAddNotes.Visibility = Visibility.Collapsed;
                GridDiet.ColumnDefinitions.RemoveAt(1);
                getback.Visibility = Visibility.Visible;
            }
        }
        private void GetbackButton_Click(object sender, TappedRoutedEventArgs e)
        {
            ColumnDefinition column = new ColumnDefinition();
            column.Width = new GridLength(0.25, GridUnitType.Star);
            GridDiet.ColumnDefinitions.Add(column);
            Grid.SetColumn(grdAddNotes, 1);

            grdAddNotes.Visibility = Visibility.Visible;
            getback.Visibility = Visibility.Collapsed;
        }

        private void Journaltext_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text.Background = new SolidColorBrush(Color.FromArgb(255, 229, 103, 58));
            text2.Background = new SolidColorBrush(Color.FromArgb(224, 224, 224, 224));
            txtjournal.Foreground = new SolidColorBrush(Colors.White);
            txtquestions.Foreground = new SolidColorBrush(Colors.Black);
            // jtapped = "1";
        }

        private void Questionstext_Tapped(object sender, TappedRoutedEventArgs e)
        {
            text2.Background = new SolidColorBrush(Color.FromArgb(255, 229, 103, 58));
            text.Background = new SolidColorBrush(Color.FromArgb(224, 224, 224, 224));
            txtjournal.Foreground = new SolidColorBrush(Colors.Black);
            txtquestions.Foreground = new SolidColorBrush(Colors.White);
            qtapped = "2";

        }
        public class ProfileJournal
        {
            public string ProfileJournalID { get; set; }
            public int ProfileID { get; set; }
            public string JournalTitle { get; set; }
            public string JournalInfo { get; set; }
            public string JournalAsset { get; set; }
            public byte JournalTypeID { get; set; }
            public DateTime CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public string LoggedInUser { get; set; }

        }

        private void saveJorQnotes(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileJournal profilejournal = new ProfileJournal();
                profilejournal.CreatedDate = System.DateTime.Today;
                profilejournal.ProfileJournalID = null;

                profilejournal.ProfileID = 2;
                profilejournal.JournalTitle = JorQtext.Text;
                profilejournal.JournalInfo = JorQtext.Text;
                profilejournal.JournalAsset = null;
                if (qtapped == "2")
                {
                    profilejournal.JournalTypeID = 2;
                }
                else
                {
                    profilejournal.JournalTypeID = 1;
                }




                profilejournal.LoggedInUser = "ram";





                var serializedPatchDoc = JsonConvert.SerializeObject(profilejournal);
                var method = new HttpMethod("POST");
                var request = new HttpRequestMessage(method,
                App.BASE_URL + "/api/ProfileJournal/SaveProfileJournal")


                {
                    Content = new StringContent(serializedPatchDoc,
                    System.Text.Encoding.Unicode, "application/json")
                };


                HttpClient client = new HttpClient();
                var result = client.SendAsync(request).Result;
                client.Dispose();

                if (result.IsSuccessStatusCode == true)
                {


                    MessageDialog msgDialog = new MessageDialog("Sucessfully Saved", "Success");
                    msgDialog.ShowAsync();
                }
                else {
                    MessageDialog msgDialog = new MessageDialog("Unsucessfull", "Failure");
                    msgDialog.ShowAsync();
                }

                //this.Frame.Navigate(typeof(DietandPregnancy));
            }

            catch (Exception ex)
            {
                string meg = ex.StackTrace;
                MessageDialog msgDialog = new MessageDialog(ex.Message, "Message");
                msgDialog.ShowAsync();
            }


        }


        private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            this.Frame.Navigate(typeof(SearchPage), args.QueryText);
        }

        private async void dietAndPregnancyShare_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();
                emailMessage.Subject = "Diet And Pregnancy";
                emailMessage.Body = "http://www.advocatehealth.com/cmc/nutritionservices";
                var email = "Enter mail address";//recipient.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>();
                if (email != null)
                {
                    var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email);
                    emailMessage.To.Add(emailRecipient);
                }
                await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Notificationgridtapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Notifications));
        }
    }
}



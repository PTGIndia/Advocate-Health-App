using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
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
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;
using System.Text;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AdvocateHealthCare
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfilePage : Page
    {
        int SelectedHosPitalId;

        public ProfilePage()
        {
            this.InitializeComponent();
            this.Loaded += ProfilePage_Loaded;
        }
        public class ProfileSetup
        {
            public string HospitalName { get; set; }
            public int HospitalID { get; set; }
        }

        async void ProfilePage_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                List<ProfileSetup> objlistProfileSetup = new List<ProfileSetup>();
                string ServiceCall = App.BASE_URL + "/api/HospitalInfo/GetHosipitalDetails";
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(new Uri(ServiceCall));
                var jsonString = await response.Content.ReadAsStringAsync();
                JArray objJArray = JArray.Parse(jsonString);
                var len = objJArray.Count;
                ComboBoxitemsTest.ItemsSource = null;
                ProfileSetup objProfileSetup = new ProfileSetup();

                objProfileSetup.HospitalID = 000;
                objProfileSetup.HospitalName = "Choose your primary care hospital...";
                objlistProfileSetup.Add(objProfileSetup);
                for (int x = 0; x < objJArray.Count; x++)
                {
                    objProfileSetup = new ProfileSetup();
                    objProfileSetup.HospitalID = (int)objJArray[x]["HospitalID"];
                    objProfileSetup.HospitalName = (string)objJArray[x]["HospitalName"];
                    objlistProfileSetup.Add(objProfileSetup);
                }
                ComboBoxitemsTest.ItemsSource = objlistProfileSetup;
                ComboBoxitemsTest.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                string meg = ex.StackTrace;
                MessageDialog msgDialog = new MessageDialog("'" + ex + "'", "Message");
                msgDialog.ShowAsync();

            }
        }
        public string ImageToServerString { get; set; }
        public class ProfileInfo
        {
            public int ProfileID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime? LMPdate { get; set; }
            public string Picture { get; set; }
            public int HospitalID { get; set; }
            public DateTime CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public string LoggedInUser { get; set; }
            public byte[] PostUserImage { get; set; }
        }
        public class comboxselected
        {
            public int carehospital { get; set; }
        }
        private void ComboBoxitemsTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SelectedHosPitalId = (int)ComboBoxitemsTest.SelectedValue;
        }



        private void bottonsetup_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                ProfileInfo objProfileInfo = new ProfileInfo();
                objProfileInfo.FirstName = txtfirstname.Text;
                objProfileInfo.LastName = txtlastname.Text;
                objProfileInfo.Email = txtemail.Text;

                objProfileInfo.Password = txtpassword.Password;

                //  objProfileInfo.cpassword = txtpassword.Password;

                objProfileInfo.LMPdate = Convert.ToDateTime(txtdatemissed.Date.ToString());
                objProfileInfo.HospitalID = SelectedHosPitalId;
                objProfileInfo.LoggedInUser = "null";
                objProfileInfo.Picture = ImageToServerString;


                var serializedPatchDoc = JsonConvert.SerializeObject(objProfileInfo);
                var method = new HttpMethod("POST");
                var request = new HttpRequestMessage(method,
                 App.BASE_URL + "/api/ProfileInfo/SaveProfileInfo")
                //"http://localhost:53676/api/ProfileInfo/SaveProfileInfo")

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
                    Window.Current.Content = new LoginPage();
                    App.userName = txtfirstname.Text;
                    //msgDialog.ShowAsync();
                }
                else {
                    MessageDialog msgDialog = new MessageDialog("Unsucessfull", "Failure");
                    msgDialog.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                string meg = ex.StackTrace;
                MessageDialog msgDialog = new MessageDialog("'" + ex + "'", "Message");
                msgDialog.ShowAsync();

            }
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            txtpassword.Password = "";

            txtcpassword.Password = "";
            ComboBoxitemsTest.SelectedValue = 000;


        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private async void CapturePhoto_Tapped(object sender, TappedRoutedEventArgs e)
        {

            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo != null)
            {
                byte[] ImageToServer = await BufferFromImage(photo);


                StringBuilder hex = new StringBuilder(ImageToServer.Length * 2);
                foreach (byte b in ImageToServer)
                    hex.AppendFormat("{0:x2}", b);

                ImageToServerString = hex.ToString();
                IRandomAccessStream stream = await photo.OpenAsync(FileAccessMode.Read);
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                SoftwareBitmap softwareBitmap = await decoder.GetSoftwareBitmapAsync();
                SoftwareBitmap softwareBitmapBGR8 = SoftwareBitmap.Convert(softwareBitmap,
                BitmapPixelFormat.Bgra8,
                BitmapAlphaMode.Premultiplied);
                SoftwareBitmapSource bitmapSource = new SoftwareBitmapSource();
                await bitmapSource.SetBitmapAsync(softwareBitmapBGR8);
                imageControl.Source = bitmapSource;
            }

        }

        public async Task<byte[]> BufferFromImage(StorageFile imageSource)
        {
            byte[] fileBytes = null;
            if (imageSource != null)
            {
                using (IRandomAccessStreamWithContentType streamsource = await imageSource.OpenReadAsync())
                {
                    fileBytes = new byte[streamsource.Size];
                    using (DataReader reader = new DataReader(streamsource))
                    {
                        await reader.LoadAsync((uint)streamsource.Size);
                        reader.ReadBytes(fileBytes);
                    }
                }
            }
            return fileBytes;
        }

    }
}



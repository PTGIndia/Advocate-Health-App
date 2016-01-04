using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class PlayVideo : Page
    {
        int VideoId;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                //string DoctorVideo = e.Parameter.ToString();
                PlayYoutubeVideo(e.Parameter.ToString());
            }
            else
            {
                PlayVideoFromVideoPage();
            }
        }
        public PlayVideo()
        {
            this.InitializeComponent();

            //}
            //PlayYoutubeVideo(VideoId);
        }
        public void PlayVideoFromVideoPage()
        {

            VideoId = (App.Current as App).NavigateText;
            switch (VideoId)
            {
                case 1:
                    PlayYoutubeVideo("d9uAa9lECcA");
                    break;
                case 2:
                    PlayYoutubeVideo("CDJ7IebMo2A");
                    break;
                case 3:
                    PlayYoutubeVideo("Xb8aVX6nA88");
                    break;
                case 4:
                    PlayYoutubeVideo("U6118JszdCU");
                    break;
                case 5:
                    PlayYoutubeVideo("Xb8aVX6nA88");
                    break;
                case 6:
                    PlayYoutubeVideo("sjqfDru825I");
                    break;
                case 7:
                    PlayYoutubeVideo("usrh-1bnXgE");
                    break;
            }

            //if (VideoId == 1)
            //{
            //    PlayYoutubeVideo("d9uAa9lECcA");
            //}
            //else if (VideoId == 2)
            //{
            //    PlayYoutubeVideo("CDJ7IebMo2A");
            //}
            //else if (VideoId == 3)
            //{
            //    PlayYoutubeVideo("Xb8aVX6nA88");
            //}
            //else if (VideoId == 4)
            //{
            //    PlayYoutubeVideo("U6118JszdCU");
            //}
            //else if (VideoId == 5)
            //{
            //    PlayYoutubeVideo("Xb8aVX6nA88");
            //}
            //else if (VideoId == 6)
            //{
            //    PlayYoutubeVideo("sjqfDru825I");
            //}
            //else if (VideoId == 7)
            //{
            //    PlayYoutubeVideo("PG81CP5U9iw");
            //}
            //else
            //{
            //    PlayYoutubeVideo("usrh-1bnXgE");
            //}
        }

        public async void PlayYoutubeVideo(string _videoId)
        {
            var url = await YouTube.GetVideoUriAsync(_videoId, YouTubeQuality.Quality1080P);
            var YoutubePlayer = new MediaElement();
            mediaYoutube.Source = url.Uri;
            mediaYoutube.Play();
            mediaYoutube.Volume = 40;
        }

        public void PlayVideoFromPreviuosPage(Uri VideoUri)
        {
            mediaYoutube.Source = VideoUri;
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaYoutube.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaYoutube.Stop();
        }

        private void btnPLay_Click(object sender, RoutedEventArgs e)
        {
            mediaYoutube.Play();
        }

        private void BackNav_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }
    }
}

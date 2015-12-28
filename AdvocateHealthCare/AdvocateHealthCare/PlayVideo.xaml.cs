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
        public PlayVideo()
        {
            this.InitializeComponent();

            //Uri previousPageUri = (App.Current as App).NavigateText;

            //if (previousPageUri != null)
            //{
            //    PlayVideoFromPreviuosPage(previousPageUri);
            //}
            //else
            //{
            //    PlayYoutubeVideo();
            //}
            PlayYoutubeVideo();
        }
        public async void PlayYoutubeVideo()
        {
            string videoID = "aANj9_oeyUM";
            var url = await YouTube.GetVideoUriAsync(videoID, YouTubeQuality.Quality1080P);
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

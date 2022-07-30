using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HdVApp2022
{
    
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void btnYoutube_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/channel/UC2DqkLA5frVTxLAHhTkfb3Q", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerlinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/michaelle-valenzuela-a43445152", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/micha17188280?t=uuZxxYXEOCQVWGIIYfi3JA&s=08", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerInstagrams_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/valenzuela1.1michael/?utm_source=qr", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/Michaelle1.1valenzuela", BrowserLaunchMode.SystemPreferred);
        }
    }
}
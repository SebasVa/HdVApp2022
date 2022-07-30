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
    
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void btnYoutube_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/channel/UCxyGauNNRl5KosOnvpTXM_A", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerlinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/antony-s%C3%A1nchez-117800227/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/antox_tr", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerInstagrams_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/gavacasv/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/anto.san.315213", BrowserLaunchMode.SystemPreferred);
        }
    }
}
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
    
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void btnYoutube_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/channel/UCPC4KcmT8Etw9TWANW79SVQ", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerlinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/sebasti%C3%A1n-valencia-b802b0193/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/Sebasti37700459", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerInstagrams_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/svalencia310/?hl=es-la", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/sebastian.s.valencia.1", BrowserLaunchMode.SystemPreferred);
        }

    }
}
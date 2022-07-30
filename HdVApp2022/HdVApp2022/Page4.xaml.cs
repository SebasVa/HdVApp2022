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
    
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void btnYoutube_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.youtube.com/channel/UCv38czoRfsHH6eqymX-NlXA", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerlinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/mateo-c-50578b136/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerTwitter_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/MateoDC1959", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerInstagrams_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/mate.cev_7/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/mateo.cevallos.18488/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
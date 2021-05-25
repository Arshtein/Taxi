using System;

using Xamarin.Forms;

namespace Taxi
{
    public partial class PathPage : ContentPage
    {
        private bool s1, s2, h1, h2 = false;
        public PathPage()
        {
            InitializeComponent();
        }
        private void bSC(object sender, EventArgs e)
        {
            if (bS.Text.Length > 0)
            {
                s1 = true;
            }
            else
            {
                s1 = false;
            }
            if (s1 == true && s2 == true && h1 == true && h2 == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private void bHC(object sender, EventArgs e)
        {
            if (bH.Text.Length > 0)
            {
                h1 = true;
            }
            else
            {
                h1 = false;
            }
            if (s1 == true && s2 == true && h1 == true && h2 == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private void eSC(object sender, EventArgs e)
        {
            if (eS.Text.Length > 0)
            {
                s2 = true;
            }
            else
            {
                s2 = false;
            }
            if (s1 == true && s2 == true && h1 == true && h2 == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private void eHC(object sender, EventArgs e)
        {
            if(eH.Text.Length > 0)
            {
                h2 = true;
            }
            else
            {
                h2 = false;
            }
            if (s1 == true && s2 == true && h1 == true && h2 == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private async void backClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private async void OKClick(object sender, EventArgs e)
        {
            string pInfo = String.Format("Из: ул.{0} д.{1}\nВ: ул.{2} д.{3}",bS.Text,bH.Text,eS.Text,eH.Text);
            MessagingCenter.Send<PathPage, string>(this, "pInfo", pInfo);
            await Navigation.PopModalAsync();

        }

    }
}
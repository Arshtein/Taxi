using System;
using Xamarin.Forms;

namespace Taxi
{
    public partial class MainPage : ContentPage
    {
        bool pCh = false, nCh = false, lnCh = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void pC(object sender, EventArgs e)
        {
            if (phone.Text.Length > 0)
            {
                pCh = true;
            }
            else
            {
                pCh = false;
            }
            if(pCh == true && nCh == true && lnCh == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private void nC(object sender, EventArgs e)
        {
            if (name.Text.Length > 0)
            {
                nCh = true;
            }
            else
            {
                nCh = false;
            }
            if (pCh == true && nCh == true && lnCh == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private void lnC(object sender, EventArgs e)
        {
            if(lastName.Text.Length > 0)
            {
                lnCh = true;
            }
            else
            {
                lnCh = false;
            }
            if (pCh == true && nCh == true && lnCh == true)
            {
                OK.IsEnabled = true;
            }
            else
            {
                OK.IsEnabled = false;
            }
        }
        private async void okClick(object sender, EventArgs e)
        {
            string uInfo = String.Format("{0}\n{1} {2}",phone.Text,name.Text,lastName.Text);
            await Navigation.PushAsync(new CallPage(uInfo));
        }
    }
}

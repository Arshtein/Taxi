using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Taxi
{
    public partial class CallPage : ContentPage
    {
        public CallPage(string uI)
        {
            InitializeComponent();
            uInfo.Text = uI;
            MessagingCenter.Subscribe<PathPage, string>(this,"pInfo",(sender,arg) => sub(arg));
        }

        private void sub (string pI)
        {
            if (pI.Length > 0)
            {
                pInfo.Text = pI;
                call.IsEnabled = true;
            }
        }
        private async void setPathClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PathPage());
        }
        private async void callClick(object sender, EventArgs e)
        {
            //await DisplayAlert("Успех","Машина в пути","ОК");
            await this.DisplayToastAsync("Машина в пути");
        }

    }
}
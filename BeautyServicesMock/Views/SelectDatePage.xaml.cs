using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class SelectDatePage : ContentPage
    {
        public SelectDatePage()
        {
            InitializeComponent();
        }


        void Handle_DateClicked(object sender, XamForms.Controls.DateTimeEventArgs e)
        {
            stkHour.IsVisible = true;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new SelectProviderPage());
        }
    }
}

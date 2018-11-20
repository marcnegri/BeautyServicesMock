using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class SpecificServiceDetailsPage : ContentPage
    {
        public SpecificServiceDetailsPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new SelectDatePage());
        }
    }
}

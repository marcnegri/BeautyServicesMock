using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class SumUpOrderPage : ContentPage
    {
        public SumUpOrderPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new PaymentPage());
        }
    }
}

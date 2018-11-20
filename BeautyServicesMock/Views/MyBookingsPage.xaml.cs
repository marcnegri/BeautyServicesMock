using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class MyBookingsPage : ContentPage
    {
        public MyBookingsPage()
        {
            InitializeComponent();

            List<string> lstItems = new List<string>() { "test", "test2", "test3" };
            lstBookings.ItemsSource = lstItems;
        }
    }
}

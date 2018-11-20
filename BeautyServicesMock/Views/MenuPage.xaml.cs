using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();

            NavigationPage p = new NavigationPage(new ServicesPage())
            {
                BarBackgroundColor = Color.Fuchsia
            };
            Detail = p;
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {

            NavigationPage p = new NavigationPage(new MyBookingsPage())
            {
                BarBackgroundColor = Color.Fuchsia
            };
            Detail = p;
            lblMenuHome.TextColor = Color.Gray;
            lblMenuMyBookings.TextColor = Color.Fuchsia;
        }

        void Home_Tapped(object sender, System.EventArgs e)
        {

            NavigationPage p = new NavigationPage(new ServicesPage())
            {
                BarBackgroundColor = Color.Fuchsia
            };
            Detail = p;
            lblMenuMyBookings.TextColor = Color.Gray;
            lblMenuHome.TextColor = Color.Fuchsia;
        }
    }
}

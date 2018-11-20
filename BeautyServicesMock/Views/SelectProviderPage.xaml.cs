using System;
using System.Collections.Generic;
using BeautyServicesMock.CustomElements;
using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class SelectProviderPage : ContentPage
    {
        public SelectProviderPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ProviderViewCell>(this, "provider", async (page) =>
            {
                await this.Navigation.PushAsync(new SumUpOrderPage());
            });

            List<Provider> lst = new List<Provider>(){
            new Provider() { Avatar = "imgProfile.jpg" },
            new Provider() { Avatar = "imgProfile2.JPG" },
            };

            lstProviders.ItemsSource = lst;
        }
    }

    public class Provider
    {
        private string avatar;
        private string firstName;

        public string Avatar { get => avatar; set => avatar = value; }
        public string FirstName { get => firstName; set => firstName = value; }
    }
}

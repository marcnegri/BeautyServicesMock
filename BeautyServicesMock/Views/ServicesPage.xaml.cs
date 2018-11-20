using System;
using System.Collections.Generic;
using BeautyServicesMock.CustomElements;
using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class ServicesPage : ContentPage
    {
        public ServicesPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<ServicesViewCell>(this, "service", async (page) =>
            {
                await this.Navigation.PushAsync(new ServicesDetailsPage());
            });

            // Mock 
            List<Service> lstView = new List<Service>();
            lstView.Add(new Service() { ImgSource = "backgroundCoiffure.jpg", Label = "Coiffure" });
            lstView.Add(new Service() { ImgSource = "backgroundMassage.jpg", Label = "Massage" });
            lstView.Add(new Service() { ImgSource = "backgroundNail.jpg", Label = "Ongles" });
            lstView.Add(new Service() { ImgSource = "backgroundMakeup.jpg", Label = "Maquillage" });

            lstservices.FlowItemsSource = lstView;
        }
    }

    public class Service
    {
        private string imgSource;
        private string label;

        public string ImgSource { get => imgSource; set => imgSource = value; }
        public string Label { get => label; set => label = value; }
    }
}

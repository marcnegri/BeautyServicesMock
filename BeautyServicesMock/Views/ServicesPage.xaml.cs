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
                await this.Navigation.PushAsync(new SpecificServiceDetailsPage());
            });

            // Mock 
            List<Service> lstView = new List<Service>();
            lstView.Add(new Service() { ImgSource = "backgroundBrushing.jpg", Label = "Brushing" });
            lstView.Add(new Service() { ImgSource = "backgroundHairCut.jpg", Label = "Coupe" });
            lstView.Add(new Service() { ImgSource = "backgroundColor.jpg", Label = "Couleur" });
            lstView.Add(new Service() { ImgSource = "backgroundHairStyle.jpg", Label = "Coupe courte" });

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

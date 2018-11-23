using System;
using System.Collections.Generic;
using BeautyServicesMock.CustomElements;
using Xamarin.Forms;

namespace BeautyServicesMock.Views
{
    public partial class ServicesDetailsPage : ContentPage
    {
        public ServicesDetailsPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ServicesDetailsViewCell>(this, "ImgWeesh", async (page) =>
            {
                await this.Navigation.PushAsync(new ServicesPage());
            });

            List<ServiceDetail> lstView = new List<ServiceDetail>();
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundCoiffure.jpg", Label = "Coiffure" });
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundMakeup.jpg", Label = "Maquillage" });
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundMassage.jpg", Label = "Massage" });
            /*
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundColor.jpg" });
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundBrushing.jpg" });
            lstView.Add(new ServiceDetail() { ImgSource = "backgroundColor.jpg" });*/
            lstPrestaDetails.ItemsSource = lstView;
        }
    }

    public class ServiceDetail
    {
        private string imgSource;
        private string label;

        public string ImgSource { get => imgSource; set => imgSource = value; }
        public string Label { get => label; set => label = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace BeautyServicesMock.CustomElements
{
    public partial class ServicesDetailsViewCell : ViewCell
    {
        public ServicesDetailsViewCell()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            try
            {
                MessagingCenter.Send<ServicesDetailsViewCell>(this, "ImgWeesh");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}

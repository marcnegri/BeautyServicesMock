using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace BeautyServicesMock.CustomElements
{
    public partial class ProviderViewCell : ViewCell
    {
        public ProviderViewCell()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                MessagingCenter.Send<ProviderViewCell>(this, "provider");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}

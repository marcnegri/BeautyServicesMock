using System;
using System.Collections.Generic;
using System.Diagnostics;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace BeautyServicesMock.CustomElements
{
    public partial class ServicesViewCell : FlowViewCell
    {
        public ServicesViewCell()
        {
            InitializeComponent();
        }
        public ServicesViewCell(string _imgSource)
        {

            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {

            try
            {
                MessagingCenter.Send<ServicesViewCell>(this, "service");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}

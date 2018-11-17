using System;
using Xamarin.Forms;

namespace XamarinWrapperr
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.OpenDatePicker();
        }
    }
}

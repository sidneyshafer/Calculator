using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator.forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void BtnOff_Clicked(object sender, EventArgs e)
        {
            LblResult.BindingContext = string.Empty;
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            var newViewModelInstance = new MainPageViewModel();
            BindingContext = newViewModelInstance;

        }

        private void BtnOn_Clicked(object sender, EventArgs e)
        {
            var newViewModelInstance = new MainPageViewModel();
            BindingContext = newViewModelInstance;

            LblResult.BindingContext = newViewModelInstance;
        }
    }
}

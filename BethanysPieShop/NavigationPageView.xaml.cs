using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            // Push the page to the top of the backstack
            await this.Navigation.PushAsync(new Helpers.HomePageView());
        }

        private async void PieOverviewButton_Clicked(object sender, EventArgs e)
        {
            // Push the page to the top of the backstack
            await this.Navigation.PushAsync(new Helpers.PieOverviewView());
        }

        private async void BasketButton_Clicked(object sender, EventArgs e)
        {
            // Push the page to the top of the backstack
            await this.Navigation.PushAsync(new Helpers.BasketView());
        }

        private async void ContactUsButton_Clicked(object sender, EventArgs e)
        {
            // Push the page to the top of the backstack
            await this.Navigation.PushAsync(new Helpers.ContactUsView());
        }
    }
}
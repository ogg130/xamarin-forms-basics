using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ContentPageView();
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new NavigationPage(new TabbedPageView());
            //MainPage = new MasterDetailPageView();
            //MainPage = new CarouselPageView();
            //MainPage = new ModalPageView();
            //MainPage = new StackLayoutPage();
            //MainPage = new LoginWithStackLayout();
            //MainPage = new GridLayoutPage();
            //MainPage = new NestedGridLayoutPage();
            //MainPage = new LoginWithGridLayout();
            //MainPage = new RelativeLayoutPage();
            //MainPage = new LoginWithRelativeLayout();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new ScrollViewPage();
            MainPage = new FlexLayoutPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
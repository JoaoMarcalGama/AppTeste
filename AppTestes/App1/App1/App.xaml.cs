using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new XamarinForms.ExtendedListView.ExtendedListView();
            //MainPage = new XamarinForms.Expander.ListaExpander();
            //MainPage = new AppBase.Main();
            MainPage = new NavigationPage(new AppBase.Main());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void OpenCalculadora(object sender, EventArgs e)
        {
            //var newpage = new XamarinForms.Calculadora.Calculadora();

            //NavigationPage.PushAsync(newpage);
            Navigation.PushAsync(new XamarinForms.Calculadora.Calculadora());
        }

        private void OpenExpander(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XamarinForms.ExtendedListView.ExtendedListView());
        }
    }
}
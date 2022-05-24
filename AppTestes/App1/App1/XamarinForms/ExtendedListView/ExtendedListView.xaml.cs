using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.XamarinForms.ExtendedListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExtendedListView : ContentPage
    {
        public class IntentionModel 
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public string Data { get; set; }
            public string Hora { get; set; }
            public string Cor { get; set; }

        }

        private ObservableCollection<IntentionModel> _Intentions { get; set; }

        public ObservableCollection<IntentionModel> Intentions 
        {
            get { return _Intentions; }
            set 
            { 
                _Intentions = value; 

                OnPropertyChanged();
            }
        }

        public ExtendedListView()
        {
            InitializeComponent();
            BindingContext = this;
            Intentions = new ObservableCollection<IntentionModel>()
            {
                new IntentionModel() { Id = 1, Titulo = "Reunião MOBILE", Data = "24/05/2022", Hora = "10:00", Cor = "#F5F5F5", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus eu massa vel velit elementum tempor in eu massa."},
                new IntentionModel() { Id = 2, Titulo = "Entrega Mockup VAMOS", Data = "05/08/2022", Hora = "09:00", Cor = "#BOBEC5", Descricao = "Nulla ligula elit, aliquet sed convallis vel, ultrices eu enim. Nulla sagittis neque a tellus imperdiet, eget euismod magna molestie. "},
                new IntentionModel() { Id = 3, Titulo = "Confraternização GAMA", Data = "26/06/2022", Hora = "21:30",Cor = "#FFCF89",  Descricao = "Cras vel justo eget metus ultricies imperdiet blandit eget nunc. Nunc congue nulla a est accumsan venenatis. Mauris eget nisi sit amet arcu posuere pharetra a sed tortor. " },
            };
        }
    }
}
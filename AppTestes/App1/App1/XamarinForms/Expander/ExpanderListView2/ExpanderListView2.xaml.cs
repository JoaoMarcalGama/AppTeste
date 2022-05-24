using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.XamarinForms.Expander.ExpanderListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpanderListView : ContentPage
    {
        public class Evento
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public string Data { get; set; }
            public string Hora { get; set; }
            public string Cor { get; set; }

        }

        private ObservableCollection<Evento> _Eventos { get; set; }

        public ObservableCollection<Evento> Eventos
        {
            get { return _Eventos; }
            set
            {
                _Eventos = value;

                OnPropertyChanged();
            }
        }

        public ExpanderListView()
        {
            InitializeComponent();
            BindingContext = this;
            Eventos = new ObservableCollection<Evento>()
            {
                new IntentionModel() { Id = 1, Titulo = "Reunião MOBILE", Data = "24/05/2022", Hora = "10:00", Cor = "#F5F5F5", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus eu massa vel velit elementum tempor in eu massa."},
                new IntentionModel() { Id = 2, Titulo = "Entrega Mockup VAMOS", Data = "05/08/2022", Hora = "09:00", Cor = "#BOBEC5", Descricao = "Nulla ligula elit, aliquet sed convallis vel, ultrices eu enim. Nulla sagittis neque a tellus imperdiet, eget euismod magna molestie. "},
                new IntentionModel() { Id = 3, Titulo = "Confraternização GAMA", Data = "26/06/2022", Hora = "21:30",Cor = "#FFCF89",  Descricao = "Cras vel justo eget metus ultricies imperdiet blandit eget nunc. Nunc congue nulla a est accumsan venenatis. Mauris eget nisi sit amet arcu posuere pharetra a sed tortor. " },
            };
        }
    }
}
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
    public partial class Expander_ListView : ContentPage
    {
        public Expander_ListView()
        {
            InitializeComponent();
            Lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFIAT(),
                GetListaCarrosFORD(),
                GetListaCarrosRenault()
            };
        }
        private Marca GetListaCarrosFIAT()
        {
            var FIAT = new Marca()
            {
                new Carro {
                    Nome = "Mobi",
                    Motorizacao = "1.0",
                    Descricao = "Aventura não vai faltar, força até nos detalhes",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Uno",
                    Motorizacao = "1.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Argo",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Cronos",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Toro",
                    Motorizacao = "1.8, 2.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Ar-condicionado, Direção hidráulica"
                },
                new Carro {
                    Nome = "Grand Siena",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Strada",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Doblò",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },


            };

            FIAT.Nome = "FIAT";

            return FIAT;
        }

        private Marca GetListaCarrosFORD()
        {
            var FORD = new Marca()
            {
                new Carro {
                    Nome = "Ka",
                    Motorizacao = "1.0",
                    Descricao = "Aventura não vai faltar, força até nos detalhes",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Ka Sedan",
                    Motorizacao = "1.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Fusion",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Ecosport",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Novo Edge",
                    Motorizacao = "1.8, 2.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Ar-condicionado, Direção hidráulica"
                },
                new Carro {
                    Nome = "Ranger",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Mustang",
                    Motorizacao = "1.0  - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },

            };

            FORD.Nome = "FORD";

            return FORD;
        }

        private Marca GetListaCarrosRenault()
        {
            var Renault = new Marca()
            {
                new Carro {
                    Nome = "Kwid",
                    Motorizacao = "1.0",
                    Descricao = "Aventura não vai faltar, força até nos detalhes",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Sandero",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "Aventura não vai faltar, força até nos detalhes",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Logan",
                    Motorizacao = "1.6",
                    Descricao = "Aventura não vai faltar, força até nos detalhes",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
            };
            Renault.Nome = "Renault";

            return Renault;
        }
    }
    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItemsDeSerie { get; set; }
    }

    public class Marca : List<Carro>
    {
        public string Nome { get; set; }
    }
}
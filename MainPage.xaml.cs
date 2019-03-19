using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaCidadeApp.Model;
using Xamarin.Forms;


namespace ListaCidadeApp
{
    public partial class MainPage : ContentPage
    {
        List<string> lista_cidade = new List<string>();




        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Cidade cidade = new Cidade();

            cidade.nome = (ncidade.Text) ;
            cidade.uf = (nuf.Text);

            string conteudo = (cidade.nome + " " + cidade.uf);

            lista_cidade.Add(conteudo);

            ncidade.Text = string.Empty;
            nuf.Text = string.Empty;

        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListaPage(lista_cidade));
        }
    }
}

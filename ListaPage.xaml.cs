using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaCidadeApp
{
    public partial class ListaPage : ContentPage
    {


        public ListaPage(List<string> lista_cidade)
        {
            InitializeComponent();
            minhaLista.ItemsSource = lista_cidade;
        }
    }
}

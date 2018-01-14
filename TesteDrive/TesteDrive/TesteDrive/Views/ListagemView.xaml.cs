using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Models;
using Xamarin.Forms;

namespace TesteDrive.Views
{
    
    public partial class ListagemView : ContentPage
    {
        
        public ListagemView()
        {
            InitializeComponent();
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo) e.Item;

            //DisplayAlert("Teste Drive", string.Format("Você tocou no modelo '{0}', que custa {1} "
            //    , veiculo.Nome, veiculo.PrecoFormatado), "Ok");

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}

using App13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageFavorito : ContentPage
	{
		public PageFavorito ()
		{
			InitializeComponent ();
            listaCasa.ItemsSource = new List<ModelTeste>
            {
                new ModelTeste {id=1 , Nome="Casa com 440m²", Status="Venda", Valor="R$ 430.000,00", Bairro="Vila Romana", Cidade="Ponta Grossa", Disponivel="Casa com laje, contendo 03 quartos, sala de estar e jantar, ampla cozinha, banheiro social e escritório.Edícula nos fundos com churrasqueira, lavanderia e quarto de despejo.02 vagas de garagemCanilTerreno 10x44 - 440m²." ,imobiliaria="QRiMov", ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/nfWP9M3.jpg" },
            };
        }

        private async void ListaCasa_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new PageExibicao());
        }
    }
}
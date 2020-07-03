using App13.Models;
using App13.Services;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace App13.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagePrincipal
	{
		public PagePrincipal ()
		{
			InitializeComponent ();
            //AtualizaLista();
            NavigationPage.SetHasNavigationBar(this, false);

            listaCasa.ItemsSource = new List<ModelTeste>
            {
                new ModelTeste {id=1 , Nome="Casa com 440m²", Status="Venda", Valor="R$ 430.000,00", Bairro="Vila Romana", Cidade="Ponta Grossa", Disponivel="Casa com laje, contendo 03 quartos, sala de estar e jantar, ampla cozinha, banheiro social e escritório.Edícula nos fundos com churrasqueira, lavanderia e quarto de despejo.02 vagas de garagemCanilTerreno 10x44 - 440m²." ,imobiliaria="QRiMov", ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/nfWP9M3.jpg" },
                new ModelTeste {id=2 , Nome="Sobrado com 180m²", Status="Venda", Valor="R$ 800.000,00", Bairro="Jardim Cachoeira", Cidade="Juiz de Fora", Disponivel="180m², 3 quartos, 1 banheiro(1 suíte), carros: 2 vagas(Cobertas)" ,imobiliaria="QRiMov", ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/OtOM95I.jpg" },
                new ModelTeste {id=3 ,Nome="Casa com 150m²", Status="venda", Valor="R$ 750.000,00", Bairro="Campo Alto", Cidade="Petrolândia", Disponivel="150m², 4 quartos, 2 banheiros (2 suítes),carros;4vagas" ,imobiliaria="QRiMov" ,ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/U6sO71h.jpg" },
                new ModelTeste {id=4 ,Nome="Casa com 6 dormitórios 350m²", Status="Aluguel", Valor="R$ 7.000,00", Bairro="Jardim Raphael", Cidade="Bertioga", Disponivel="Água Quente, Área de Serviço, Área de Serviço com Banheiro, Churrasqueira, Cozinha Americana, Espaço Gourmet, Garagem, Jardim, Piscina" ,imobiliaria="QRiMov" ,ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/XnEfgeH.png" },
                new ModelTeste {id=3 ,Nome="Casa com 4 Quartos, 175 m²", Status="Aluguel", Valor="R$ 3.200,00", Bairro="Centro", Cidade="Cascavel", Disponivel="175m², 4 quartos, 3 banheiros, 1 suíte, carros; 3 vagas" ,imobiliaria="QRiMov" ,ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/xbDAyck.jpg" },
                new ModelTeste {id=4 ,Nome="Casa com 80m²", Status="Aluguel", Valor="R$ 1.300,00", Bairro="Jardim dos Manacás", Cidade="São Paulo", Disponivel="2 quartos (1 suite), lavabo, cozinha, garagem para 2 carros" ,imobiliaria="QRiMov" ,ImagemUrl="qrimov.png", casaUrl="https://i.imgur.com/byOU8aY.jpg" }
            };

            //TesteDb.Text = App.Caminho;
        }

        /*public void AtualizaLista()
        {
            ServiceDBFeed dbFeed = new ServiceDBFeed(App.Caminho);
            WSFAAT.WebService1SoapClient ws = new WSFAAT.WebService1SoapClient();
            dbFeed = ws.GetDataSet("SELECT * FROM GLO_TB_CLIENTES", "AULA");

            listaCasa.ItemsSource = dbFeed.Listar();

        }*/

        private void AbrirScanner_Clicked(object sender, EventArgs e)
        {
            Scanner();
        }

        public async void Scanner()
        {

            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {
                // Parar de escanear
                ScannerPage.IsScanning = false;

                // Alert com o código escaneado
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Código escaneado", result.Text, "OK");
                });
            };


            await Navigation.PushAsync(ScannerPage);

        }


         async void AbrirFiltro_Clicked(object sender, EventArgs e)
         {
             var page = new PopupPage();

             await PopupNavigation.Instance.PushAsync(page);
         }

        private async void BtHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private async void BtFavorito_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFavorito { Title = "Meus Favoritos!" });
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Nome.IsVisible = false;
            Pesquisa.IsVisible = true;
            Pesquisa.Focus();
        }

        private void Pesquisa_Completed(object sender, EventArgs e)
        {
            Pesquisa.Text = "";
            Pesquisa.IsVisible = false;
            Nome.IsVisible = true;
        }

        private void Favoritando_Clicked(object sender, EventArgs e)
        {
        }

        private async void ListaCasa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                /*var dados = new ModelTeste
                {
                    Nome = ToString(),
                    Status = listaCasa.FindByName<Label>("status").Text.ToString(),
                    Valor = listaCasa.FindByName<Label>("valor").Text.ToString(),
                    Bairro = listaCasa.FindByName<Label>("bairro").Text.ToString(),
                    Cidade = listaCasa.FindByName<Label>("cidade").Text.ToString(),
                    Disponivel = listaCasa.FindByName<Label>("disponivel").Text.ToString()
                };

                var exib = new PageExibicao();
                exib.BindingContext = dados;
                await Navigation.PushAsync(exib);*/

                var selection = e.SelectedItem as ModelFeed;
                await Navigation.PushAsync(new PageExibicao());

                ((ListView)sender).SelectedItem = null;
            }
        }

    }
}
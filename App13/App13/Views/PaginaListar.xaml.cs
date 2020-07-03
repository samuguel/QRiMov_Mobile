using App13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App13.Services;


namespace App13.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaListar : ContentPage
	{
		public PaginaListar()
		{
			InitializeComponent();
			//AtualizaLista();
		}

/*
		public void AtualizaLista()
		{
			ServiceDBNotas dbNotas = new ServiceDBNotas(App.Caminho);
			ListaNotas.ItemsSource = dbNotas.Listar();

		}

		private void ListaNotas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			ModelNotas nota = (ModelNotas)ListaNotas.SelectedItem;
			// chamada da pagina cadastrar
			MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
			p.Detail = new Cadastrar(nota);
		}

		private void ToolbarItem_Clicked(object sender, EventArgs e)
		{

		}
		async void OnClickCompartilhar(object sender, EventArgs ea)
		{


		}*/
	}
}

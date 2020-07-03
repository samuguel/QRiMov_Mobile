using App13.Models;
using App13.Services;
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
	public partial class Cadastrar : ContentPage
	{
		public Cadastrar ()
		{
			InitializeComponent ();
		}

		/*public Cadastrar(ModelNotas nota)
		{
			InitializeComponent();
			txtCodigo.IsVisible = true;

			txtCodigo.Text = nota.Id.ToString();

			btSalvar.Text = "Alterar";
			btExcluir.IsVisible = true;
			txtTitulo.Text = nota.Titulo;
			txtDados.Text = nota.Dados;
			swFavorito.IsToggled = nota.Favorito;

		}


		private void BtSalvar_Clicked(object sender, EventArgs e)
		{
			try
			{
				ModelNotas nota = new ModelNotas();
				nota.Titulo = txtTitulo.Text;
				nota.Dados = txtDados.Text;
				nota.Favorito = swFavorito.IsToggled;
				ServiceDBNotas dbNotas = new ServiceDBNotas(App.Caminho);
				if (btSalvar.Text == "Inserir")
				{
					dbNotas.Inserir(nota);
					DisplayAlert("Resultado da operação ", dbNotas.Mensagem, "OK");
				}
				else
				{ //Alterar
					nota.Id = Convert.ToInt32(txtCodigo.Text);
					dbNotas.Alterar(nota);
					DisplayAlert("Resultado da operação ", dbNotas.Mensagem, "OK");
					MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
					p.Detail = new PagePrincipal();
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Erro ", ex.Message, "OK");
			}

		}

		private void BtCancelar_Clicked(object sender, EventArgs e)
		{
			MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
			p.Detail = new PagePrincipal();
		}

		private async void BtExcluir_Clicked(object sender, EventArgs e)
		{
			ServiceDBNotas dbNotas = new ServiceDBNotas(App.Caminho);
			var resp = await DisplayAlert("Excluir", "Deseja realmente excluir?","Sim","Não");
			if (resp==true)
			{
				int id = Convert.ToInt32(txtCodigo.Text);
				dbNotas.Excluir(id);
                await DisplayAlert("Resultado da operação ", dbNotas.Mensagem, "OK");
				MasterDetailPage p = (MasterDetailPage)Application.Current.MainPage;
				p.Detail = new PagePrincipal();
			}
		}*/
	}
}
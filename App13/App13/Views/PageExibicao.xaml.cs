using App13.Models;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageExibicao 
	{

        MainViewModel _vm;
        
        public PageExibicao ()
		{
			InitializeComponent ();

            BindingContext = _vm = new MainViewModel();
            
            Nome.Text = "Casa com 4 Quartos";
            Status.Text = "Aluguel";
            Valor.Text = "R$ 3.200,00";
            Bairro.Text = "Centro";
            Cidade.Text = "Cascavel";
            Informacoes.Text = "175m², 4 quartos, 3 banheiros, 1 suíte, carros 3 vagas";
        }

        void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            Debug.WriteLine("Posição " + e.NewValue + " Selecionada.");
        }

        void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            Debug.WriteLine("Rolada para " + e.NewValue + " por cento.");
            Debug.WriteLine("Direção = " + e.Direction);
        }
    }
}
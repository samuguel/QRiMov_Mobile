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
    public partial class PopupPage 
    {
        public PopupPage()
        {
            InitializeComponent();
        }
        decimal valueMin;
        decimal valueMax;
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueMin = Convert.ToDecimal( args.NewValue);
            valueMin = valueMin * 10;
            textoValorMin.Text = String.Format("O valor selecionado {0} ", Decimal.Round(valueMin).ToString("C2"));
        }

        void OnSliderValueChanged2(object sender, ValueChangedEventArgs args)
        {
            valueMax = Convert.ToDecimal( args.NewValue);
            valueMax = valueMax * 10000;
            textoValorMax.Text = String.Format("O valor selecionado {0}", Decimal.Round(valueMax).ToString("C2"));
        } 
    }
}
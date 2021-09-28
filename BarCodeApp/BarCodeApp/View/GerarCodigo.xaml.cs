using BarCodeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarCodeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GerarCodigo : ContentPage
    {
        GerarCodigoViewModel viewModel;
        public GerarCodigo()
        {
            InitializeComponent();
    
            viewModel = new GerarCodigoViewModel(this);
            BindingContext = viewModel;
        }

        private void tbSalvar_Clicked(object sender, EventArgs e)
        {
            string concatenada = txtNome.Text + txtKey.Text;
            viewModel.codeValue = concatenada;
        }
    }
}
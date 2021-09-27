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
    public partial class LerCodigo : ContentPage
    {
        public LerCodigo()
        {
            InitializeComponent();
        }

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                scannv.IsScanning = false;
                await DisplayAlert("Verificação", "Status: liberado \nNome:Abel\nChave: ##\nKeyCode:"+result.Text, null, "Ok");
                scannv.IsScanning = true;
            });
        }
    }
}
using System;

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
                scannv.IsTorchOn = true;
                scannv.IsScanning = false;
                await DisplayAlert("Verificação", "Status: liberado \nNome:Abel\nChave: ##\nKeyCode:" + result.Text, null, "Ok");
                scannv.IsScanning = true;
                scannv.IsTorchOn = false;
            });
        }
        private void ContentPage_Appearing(object sender, EventArgs e) => scannv.IsVisible = true;
        private void ContentPage_Disappearing(object sender, EventArgs e) => scannv.IsVisible = false;
    }
}
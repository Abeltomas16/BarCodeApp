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
                scannv.IsScanning = false;
                await DisplayAlert("Verificação", "Status: liberado \nNome:Abel\nChave: ##\nKeyCode:" + result.Text, null, "Ok");
                scannv.IsScanning = true;
            });
        }
        private void ContentPage_Appearing(object sender, EventArgs e) => scannv.IsVisible = true;
        private void ContentPage_Disappearing(object sender, EventArgs e) => scannv.IsVisible = false;
        private void flash_Clicked(object sender, EventArgs e)=> scannv.IsTorchOn = !scannv.IsTorchOn;         
    }
}
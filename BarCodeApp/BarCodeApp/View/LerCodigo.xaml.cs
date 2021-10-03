using System;

using XF.Material.Forms.UI.Dialogs;
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
                await MaterialDialog.Instance.AlertAsync(
                    message: "Status: liberado \nNome:Abel\nChave: ##\nKeyCode:" + result.Text,
                    title: "Verificacao",
                    new XF.Material.Forms.UI.Dialogs.Configurations.MaterialAlertDialogConfiguration
                    {
                        BackgroundColor = Color.FromRgb(70, 213, 123)
                    });
                scannv.IsScanning = true;
            });
        }
        private void ContentPage_Appearing(object sender, EventArgs e) => scannv.IsVisible = true;
        private void ContentPage_Disappearing(object sender, EventArgs e) => scannv.IsVisible = false;
        private void flash_Clicked(object sender, EventArgs e) => scannv.IsTorchOn = !scannv.IsTorchOn;
    }
}
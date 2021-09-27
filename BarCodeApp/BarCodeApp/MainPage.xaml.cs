using BarCodeApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.Material.Forms.UI;

namespace BarCodeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btGerar_Clicked(object sender, EventArgs e)
        {
            Button bt = (sender as Button);
            if (bt.Text.ToUpper().Equals("LER"))
                await Navigation.PushAsync(new MaterialNavigationPage(new LerCodigo()));
        }
    }
}

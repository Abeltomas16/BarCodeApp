

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms;
using XF.Material.Forms.UI;

namespace BarCodeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Material.Init(this);
            MainPage = new MaterialNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

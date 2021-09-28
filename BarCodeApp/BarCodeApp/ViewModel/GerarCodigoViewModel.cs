using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BarCodeApp.ViewModel
{
    public class GerarCodigoViewModel:BaseViewModel
    {
        private string _codeValue { get; set; }
        public string codeValue
        {
            get { return _codeValue; }
            set
            {
                if (_codeValue != value)
                {
                    _codeValue = value;
                    OnPropertyChanged();
                }
            }
        }
        Page _page;
        public GerarCodigoViewModel(Page page)
        {
            this._page = page;
        }
    }
}

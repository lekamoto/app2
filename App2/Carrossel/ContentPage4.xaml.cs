using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Carrossel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPage4 : ContentPage
    {
        public ContentPage4()
        {
            InitializeComponent();
        }

        private void IrModal1 (Object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new Modal.ModalPage1());               
        }
    }
}
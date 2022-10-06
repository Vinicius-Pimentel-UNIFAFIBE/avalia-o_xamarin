using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Atividade1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();    
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
         //Navigation.PushModalAsync(new MainPage());
        }
    }
}
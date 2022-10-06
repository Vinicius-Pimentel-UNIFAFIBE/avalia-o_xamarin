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
    public partial class PgMenuItem : ContentPage
    {


        public PgMenuItem()
        {
            InitializeComponent();
            var usuarioLogado = UsuarioLogado.Instancia;
            labelLogin.Text = usuarioLogado.NomeSec; //atribuindo o valor da label ao valor da instancia
        }

        private void btnCadDisplay_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TelaCadastro());

        }

        private void btnCadSingleton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TelaCadastroExibir());
        }

        private void btnLinkedin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PaginaLinkedin());
        }

        private void btnLogout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login());
            var usuarioLogado = UsuarioLogado.Instancia;
            usuarioLogado.NomeSec = "";
        }
    }
}
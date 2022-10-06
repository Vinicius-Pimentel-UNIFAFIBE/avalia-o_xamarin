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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if (ValidarLogin(txtlogin.Text, txtSenha.Text))
            {
                var usuarioLogado = UsuarioLogado.Instancia;
                usuarioLogado.NomeSec = txtNome.Text; //atribuindo o valor da variavel NomeSec

                Navigation.PushModalAsync(new PgNewMenu());
            }
            else
                DisplayAlert("Você errou o login ou a senha.",
                            "Tente inserir os dados novamente ou fale com um administrador, caso acredite que seja um erro.",
                            "Ok");
        }

        bool ValidarLogin(string login, string senha)
        {
            return (login == "1" && senha == "1");
        }
    }
}
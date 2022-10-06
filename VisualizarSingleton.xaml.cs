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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            var obterDados = Singleton.Instancia;
            txtNomeSingle.Text = obterDados.Nome;
            txtIdade.Text = obterDados.Idade;
            txtSexo.Text = obterDados.Sexo;
            txtTelefone.Text = obterDados.Telefone;
            txtRua.Text = obterDados.Rua;
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PgNewMenu());
        }

    }
}
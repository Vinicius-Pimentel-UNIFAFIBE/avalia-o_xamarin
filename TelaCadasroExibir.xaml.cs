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
    public partial class TelaCadastroExibir : ContentPage
    {
        public TelaCadastroExibir()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
          
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            var obterDados = Singleton.Instancia;
            obterDados.Nome = "";
            obterDados.Idade = "";
            obterDados.Sexo = "";
            obterDados.Telefone = "";
            obterDados.Rua = "";

            txtNome.Text = "";
            txtIdade.Text = "";
            txtSexo.Text = "";
            txtTelefone.Text = "";
            txtRua.Text = "";


            DisplayAlert("Sucesso!", "Você limpou todos os dados salvos na classe Singleton.", "OK");
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            var obterDados = Singleton.Instancia;
            obterDados.Nome = txtNome.Text;
            obterDados.Idade = txtIdade.Text;
            obterDados.Sexo = txtSexo.Text;
            obterDados.Telefone = txtTelefone.Text;
            obterDados.Rua = txtRua.Text;

            DisplayAlert("Sucesso!", "Você cadastrou com sucesso os dados na classe Singleton.", "OK");
            
            
        }
    }
}
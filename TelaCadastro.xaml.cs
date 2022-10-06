using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atividade1
{
    public partial class TelaCadastro : ContentPage
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Nome: " + txtNome.Text +
                                     "\nIdade: " + txtIdade.Text +
                                     "\nSexo: " + txtSexo.Text +
                                     "\nTelefone: " + txtTelefone.Text +
                                     "\nRua: " + txtRua.Text +
                                     "\nBairro: " + txtBairro.Text +
                                     "\nNúmero da casa: " + txtNumero.Text +
                                     "\nSigno: " + txtSigno.Text,
                                     "Ok");
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtSexo.Text = "";
            txtTelefone.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtSigno.Text = "";

        }
    }
}

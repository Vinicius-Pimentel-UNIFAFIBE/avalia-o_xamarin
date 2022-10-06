using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public class UsuarioLogado
    {
        static UsuarioLogado _instancia;
        public static UsuarioLogado Instancia
        {
            get { return _instancia ?? 
                    (_instancia = new UsuarioLogado()); }
        }
        private UsuarioLogado() { }
        
       public string Login { get; set; }
        public string NomeSec { get; set; } //criando a instancia
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Singleton
    {
        static Singleton _instancia;
        public static Singleton Instancia
        {
            get
            {
                return _instancia ??
                  (_instancia = new Singleton());
            }
        }
        private Singleton() { }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
    }
}

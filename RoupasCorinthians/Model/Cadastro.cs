using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupasCorinthians.Model
{
    internal class Cadastro
    {
        private static int codigo;
        private static string nome;
        private static string cpf;
        private static string endereço;
        private static string tipoPerfil;
        private static string dataNascimento;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Endereço { get => endereço; set => endereço = value; }
        public static string TipoPerfil { get => tipoPerfil; set => tipoPerfil = value; }
        public static string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}

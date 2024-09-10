using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupasCorinthians.Model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nathaly.bosantos\source\repos\RoupasCorinthians\RoupasCorinthians\Dados\dadoscorin.mdf;Integrated Security=True";
        }
    }
}

using RoupasCorinthians.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoupasCorinthians.Controller
{
    internal class ControllerCadastro
    {
        public void Conect()
        {
            SqlConnection lg = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("Procedure", lg);
            cmd .CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Nome", Cadastro.Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cadastro.Cpf);
                cmd.Parameters.AddWithValue("@Endereco", Cadastro.Endereço);
                cmd.Parameters.AddWithValue("@TipoPerfil", Cadastro.TipoPerfil);
                cmd.Parameters.AddWithValue("@DataNascimento", Cadastro.DataNascimento);

                lg.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Agora você é da Fiel!!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

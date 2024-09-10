using RoupasCorinthians.Controller;
using RoupasCorinthians.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoupasCorinthians
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro.Nome = tbx_nome.Text;
            Cadastro.Cpf = tbx_cpf.Text;
            Cadastro.DataNascimento = tbx_data.Text;
            Cadastro.Endereço = tbx_endereco.Text;
            Cadastro.TipoPerfil = cbx_tipo.Text;

           ControllerCadastro controllerCadastro = new ControllerCadastro();
            controllerCadastro.Conect();
        }
    }
}

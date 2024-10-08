using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Cadastrar
{
    public partial class frmCadastrarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public frmCadastrarDisciplina()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string query = "insert into Disciplinas (Nome, Sigla, Ativo) Values (@nome, @sigla, @ativo)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

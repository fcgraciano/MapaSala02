using MapaSala.BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Classes
{
    public class Disciplinas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
       

        public void Inserir()
        {
            try
            {
                MySqlConnection Conexao = new Conexao().Abrir();
                string query = "Insert Into Disciplinas (Nome, Sigla) values (@nome, @sigla)";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@sigla", Sigla);
                cmd.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Inserir: " + e.Message);
            }
        }

        public void Excluir()
        {
            try
            {
                MySqlConnection Conexao = new Conexao().Abrir();
                string query = "Delete from Disciplinas where Id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);
                cmd.Parameters.AddWithValue("@ID", Id);
                cmd.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Excluir: " + e.Message);
            }
        }

        public void Alterar()
        {
            try
            {
                MySqlConnection Conexao = new Conexao().Abrir();
                string query = "Update Disciplinas set Nome = @nome, Sigla = @sigla where Id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);
                cmd.Parameters.AddWithValue("@ID", Id);
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@sigla", Sigla);
                cmd.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Alterar Registro: " + e.Message);
            }
        }

        public DataTable PreencherGrid()
        {
            MySqlConnection Conexao = new Conexao().Abrir();
            string query = "Select Id, Nome, Sigla from Disciplinas";
            MySqlCommand cmd = new MySqlCommand(query, Conexao);
            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, Conexao);
                DataTable datatable = new DataTable();
                adaptador.Fill(datatable);
                Conexao.Close();
                return datatable;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao Preencher o DataGrid: " + e.Message);
                return new DataTable();
            }

        }
    }
}

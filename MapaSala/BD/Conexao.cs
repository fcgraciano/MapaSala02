using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.BD
{
    public class Conexao
    {
       
        private string LinhaConexao = $"Server=localhost;Database=AULA_DS;Uid=root;password=";

        public MySqlConnection Abrir()
        {
            MySqlConnection conn = new MySqlConnection(LinhaConexao);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                conn = null;
                MessageBox.Show("Erro na conexão: " + ex.Message);

            }

            return conn;
        }
    }
}

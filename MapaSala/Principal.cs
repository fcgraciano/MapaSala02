using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.BD;
using MapaSala.Formularios;

namespace MapaSala
{
    public partial class Principal : Form
    {
        public static string LinhaConexao = "Server=localhost;Database=AULA_DS;Uid=root;password=";
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessores s = new frmProfessores();
            s.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplina d = new frmDisciplina();
            d.ShowDialog();
        }

        private void cursoXDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursoDisciplina c = new FrmCursoDisciplina();
            c.ShowDialog();
        }

        private void criarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.CreateDatabase();
                MessageBox.Show("Banco de dados criado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu algum erro, você ligou o xampp ?");
            }
            
        }

        private void excluirOBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.DropDatabase();
                MessageBox.Show("Banco de dados excluido com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu algum erro, você ligou o xampp ?");
            }
        }
    }
}

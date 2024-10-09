using MapaSala.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Cadastrar
{
    public partial class frmCadastroDisciplina : Form
    {
        Disciplinas disciplina = new Disciplinas();

        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                disciplina.Nome = txtNome.Text;
                disciplina.Sigla = txtSigla.Text;
                disciplina.Inserir();
                MessageBox.Show("Cadastro realizado com sucesso","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

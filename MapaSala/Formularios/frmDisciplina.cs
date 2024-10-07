using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        DataTable dados;
        int LinhaSelecionada;

        DisciplinaDAO dao = new DisciplinaDAO();

        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Sigla = txtSigla.Text;

            dados.Rows.Add( d.Linha() );

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); 
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNomeDisciplina.Text = "";
            txtSigla.Text = "";
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeDisciplina.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString() ;
            txtSigla.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtGridDisciplina.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = numId.Value;
            minhamae.Cells[1].Value = txtNomeDisciplina.Text;
            minhamae.Cells[2].Value = txtSigla.Text;
            
            
        }

        private void dtGridDisciplina_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtGridDisciplina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int id = Convert.ToInt32(
                    dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);
                

                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                // Inscreve-se no evento
                //editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Fechou o Form e atualiza o grid");
            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }

      
    }
}

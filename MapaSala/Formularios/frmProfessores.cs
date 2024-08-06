using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmProfessores : Form
    {
        DataTable dados;
        ProfessorDAO dao = new ProfessorDAO();
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProfessores();

            dtGridProfessores.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade p = new ProfessoresEntidade();
            p.Id = Convert.ToInt32(numId.Value);
            p.Apelido = txtApelido.Text;
            p.Nome = txtNomeCompleto.Text;

            ProfessorDAO dao = new ProfessorDAO();
            dao.Inserir(p);

            dtGridProfessores.DataSource = dao.ObterProfessores();

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            txtNomeCompleto.Text = "";
            numId.Value = 0;
        }
    }
}

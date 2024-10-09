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
using MapaSala.Classes;
using MapaSala.DAO;
using MapaSala.Formularios.Cadastrar;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        Disciplinas disciplinas = new Disciplinas();
        public frmDisciplina()
        {
            InitializeComponent();
            dtGridDisciplina.DataSource = disciplinas.PreencherGrid();
        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string nome = dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idade = Convert.ToInt32(dtGridDisciplina.Rows[e.RowIndex].Cells[1].Value);

                frmEditarDisciplina editar = new frmEditarDisciplina();
              
                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog();
            }
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridDisciplina.DataSource = disciplinas.PreencherGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroDisciplina frmDisciplina = new frmCadastroDisciplina();
            frmDisciplina.FormClosed += Fechou_Editar_FormClosed;
            frmDisciplina.ShowDialog();
        }
    }
}

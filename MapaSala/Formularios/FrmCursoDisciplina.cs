using System;
using System.Data;
using System.Windows.Forms;
using MapaSala.DAO;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        CursoDAO cursoDAO = new CursoDAO();
        CursoDisciplinaDAO dao = new CursoDisciplinaDAO();
        private void AtualizaGrid(DataTable dados)
        {
            dtCursoDisciplina.DataSource = dados;
        }

        public FrmCursoDisciplina()
        {
            InitializeComponent();

            cbDisciplinas.DataSource = disciplinaDAO.PreencherComboBox();
            cbDisciplinas.DisplayMember = "Nome";
            cbDisciplinas.ValueMember = "Id";

            cbxCursos.DataSource = cursoDAO.PreencherComboBox();
            cbxCursos.DisplayMember = "Nome";
            cbxCursos.ValueMember = "Id";

            AtualizaGrid(dao.ObterCursoDisciplina());
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {

            CursoDisciplinaDAO cursoDisciplinaDao = new CursoDisciplinaDAO();

            CursoDisciplinaEntidade entidade = new CursoDisciplinaEntidade();

            entidade.CursoId = Convert.ToInt32(cbxCursos.SelectedValue);
            entidade.DisciplinaId = Convert.ToInt32(cbDisciplinas.SelectedValue);
            entidade.Periodo = cbPeriodos.SelectedItem.ToString();

            cursoDisciplinaDao.Inserir(entidade);

            AtualizaGrid(dao.ObterCursoDisciplina());

        }
    }
}

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

namespace MapaSala.Formularios
{
    public partial class FrmCursoDisciplina : Form
    {
        DisciplinaDAO disciplinaDAO = new DisciplinaDAO();
        
        public FrmCursoDisciplina()
        {
            InitializeComponent();
            lsDisciplinas.Items.AddRange( disciplinaDAO.Listbox() );
        }
    }
}

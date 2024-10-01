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
        

        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            //dados.Rows.Add(1, "Matematica", "MAT", true);
            //dados.Rows.Add(2, "Português", "PORT", true);
            //dados.Rows.Add(3, "Física", "FIS", false);

            dtGridDisciplina.DataSource = dados;
            
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
            frmEditarDisciplina editar = new frmEditarDisciplina();
            editar.ShowDialog();














            MessageBox.Show("doubleclique" +e.RowIndex+"  = "+e.ColumnIndex);
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                string nome = dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value.ToString();//Id

                Form2 form2 = new Form2(nome, idade);
                form2.ShowDialog(); // Abre o formulário como um diálogo modal
            }


            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                string nome = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idade = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                Form2 form2 = new Form2(nome, idade);

                // Inscreve-se no evento
                form2.FormClosedWithData += Form2_FormClosedWithData;

                form2.ShowDialog(); // Abre o formulário como um diálogo modal
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aciona o evento ao fechar o formulário
            FormClosedWithData?.Invoke(labelNome.Text, idade); // Passando os dados necessários
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form2_FormClosing; // Associando o evento
        }

        private void Form2_FormClosedWithData(string nome, int idade)
        {
            // Aqui você pode executar a ação desejada
            MessageBox.Show($"O formulário foi fechado. Nome: {nome}, Idade: {idade}");

            // Por exemplo, você poderia atualizar o DataGridView ou outra lógica
            // dataGridView1.Rows[0].Cells[0].Value = nome; // Exemplo de atualização
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

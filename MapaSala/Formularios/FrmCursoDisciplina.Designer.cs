
namespace MapaSala.Formularios
{
    partial class FrmCursoDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsDisciplinas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtCursoDisciplina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // lsDisciplinas
            // 
            this.lsDisciplinas.FormattingEnabled = true;
            this.lsDisciplinas.Items.AddRange(new object[] {
            "Fernando",
            "Galvani",
            "Eliete",
            "Carol",
            "Malu",
            "Lucilene",
            "Thais"});
            this.lsDisciplinas.Location = new System.Drawing.Point(12, 29);
            this.lsDisciplinas.Name = "lsDisciplinas";
            this.lsDisciplinas.Size = new System.Drawing.Size(120, 95);
            this.lsDisciplinas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplinas";
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "Desenvolvimento de sistemas Integral",
            "Administração Integral",
            "Desenvolvimento de sistemas Noite"});
            this.cbxCursos.Location = new System.Drawing.Point(229, 31);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cursos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(145, 29);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dtCursoDisciplina
            // 
            this.dtCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCursoDisciplina.Location = new System.Drawing.Point(12, 130);
            this.dtCursoDisciplina.Name = "dtCursoDisciplina";
            this.dtCursoDisciplina.Size = new System.Drawing.Size(453, 150);
            this.dtCursoDisciplina.TabIndex = 5;
            // 
            // FrmCursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 310);
            this.Controls.Add(this.dtCursoDisciplina);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsDisciplinas);
            this.Name = "FrmCursoDisciplina";
            this.Text = "FrmCursoDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsDisciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dtCursoDisciplina;
    }
}
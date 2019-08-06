using MVCProject.View.Adicionar;
using MVCProject.View.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustonQuery(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivro addLivro = new frmAdicionarLivro();
            addLivro.ShowDialog();

            if (!string.IsNullOrEmpty(addLivro.livroRow?.Registro.ToString()))

                this.livrosTableAdapter.Insert(
                    addLivro.livroRow.Registro,
                    addLivro.livroRow.Titulo,
                    addLivro.livroRow.Isbn,
                    addLivro.livroRow.Genero,
                    addLivro.livroRow.Editora,
                    addLivro.livroRow.Sinopse,
                    addLivro.livroRow.Observacao,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now);

            this.livrosTableAdapter.CustonQuery(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoLivro editLivro = new frmEdicaoLivro();
                        editLivro.livros = livroSelect;
                        editLivro.ShowDialog();

                        livrosTableAdapter.Update(editLivro.livros);

                    };
                    break;
            }

            this.livrosTableAdapter.CustonQuery(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }
}

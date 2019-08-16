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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor addAutor = new frmAdicionarAutor();
            addAutor.ShowDialog();

            if (!string.IsNullOrEmpty(addAutor.autoresRow?.Nome))

                this.autoresTableAdapter.Insert(
                    addAutor.autoresRow.Nome,
                    addAutor.autoresRow.Descricao);

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoAutor editAutor = new frmEdicaoAutor();
                        editAutor.autores = autorSelect;
                        editAutor.ShowDialog();

                        autoresTableAdapter.Update(editAutor.autores);

                    };
                    break;
            }

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}

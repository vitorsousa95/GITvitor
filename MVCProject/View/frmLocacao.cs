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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao addLocacao = new frmAdicionarLocacao();
            addLocacao.ShowDialog();

            if (!string.IsNullOrEmpty(addLocacao.locacaoRow?.Livro.ToString()))

                this.locacaoTableAdapter.Insert(
                    addLocacao.locacaoRow.Livro,
                    addLocacao.locacaoRow.Usuario,
                    addLocacao.locacaoRow.Tipo,
                    DateTime.Now.AddDays(7),
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now);

            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.locacao);
        }

       private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                MVCProject.SistemaBibliotecaDBDataSet.locacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoLocacao editLocacao = new frmEdicaoLocacao();
                        editLocacao.locacoes = locacaoSelect;
                        editLocacao.ShowDialog();

                        locacaoTableAdapter.Update(editLocacao.locacoes);

                    };
                    break;
            }

            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.locacao);
        }
    }
}

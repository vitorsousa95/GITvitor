using MVCProject.Model;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            if (Session.user == null)
                throw new Exception("Erro critico de sistema");
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios user = new frmUsuarios();
            user.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autor = new frmAutores();
            autor.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros genero = new frmGeneros();
            genero.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditora editora = new frmEditora();
            editora.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro livro = new frmLivro();
            livro.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao locacao = new frmLocacao();
            locacao.ShowDialog();
        }
    }
}

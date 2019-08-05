using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Edicao
{
    public partial class frmEdicaoLocacao : Form
    {
        public frmEdicaoLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.locacaoRow locacoes;

        private void FrmEdicaoLocacao_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = locacoes.Livro;
            comboBox2.SelectedValue = locacoes.Usuario;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacoes.Livro = (int)comboBox1.SelectedValue;
            locacoes.Usuario = (int)comboBox2.SelectedValue;

            this.Close();
        }
    }
}

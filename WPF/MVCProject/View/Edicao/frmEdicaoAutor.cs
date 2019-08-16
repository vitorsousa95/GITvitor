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
    public partial class frmEdicaoAutor : Form
    {
        public frmEdicaoAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow autores;

        private void FrmEdicaoAutor_Load(object sender, EventArgs e)
        {
            textBox1.Text = autores.Nome;
            textBox2.Text = autores.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            autores.Nome = textBox1.Text;
            autores.Descricao = textBox2.Text;

            this.Close();
        }
    }
}

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
    public partial class frmEditarEditora : Form
    {
        public frmEditarEditora()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow editora;

        private void FrmEditarEditora_Load(object sender, EventArgs e)
        {
            textBox1.Text = editora.Nome;
            textBox2.Text = editora.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            editora.Nome = textBox1.Text;
            editora.Descricao = textBox2.Text;

            this.Close();
        }
    }
}

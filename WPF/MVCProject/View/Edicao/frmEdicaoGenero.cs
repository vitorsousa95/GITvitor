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
    public partial class frmEdicaoGenero : Form
    {
        public frmEdicaoGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow generos;

        private void FrmEdicaoGenero_Load(object sender, EventArgs e)
        {
            textBox1.Text = generos.Tipo;
            textBox2.Text = generos.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generos.Tipo = textBox1.Text;
            generos.Descricao = textBox2.Text;

            this.Close();
        }
    }
}

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
    public partial class frmEdicaoLivro : Form
    {
        public frmEdicaoLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livros;

        private void FrmEdicaoLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            textBox1.Text           = livros.Registro.ToString();
            textBox2.Text           = livros.Titulo;
            textBox3.Text           = livros.Isbn;
            comboBox1.SelectedValue = livros.Genero;
            comboBox2.SelectedValue = livros.Editora;
            textBox4.Text           = livros.Sinopse;
            textBox5.Text           = livros.Observacoes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livros.Registro = int.Parse(textBox1.Text.ToString());
            livros.Titulo = textBox2.Text;
            livros.Isbn = textBox3.Text;
            livros.Genero = (int)comboBox1.SelectedValue;
            livros.Editora = (int)comboBox2.SelectedValue;
            livros.Sinopse = textBox4.Text;
            livros.Observacoes = textBox5.Text;

            this.Close();
        }
    }
}

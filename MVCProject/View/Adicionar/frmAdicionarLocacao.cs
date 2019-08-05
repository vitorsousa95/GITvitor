﻿using MVCProject.Model;
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
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacaoRow;

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = checkedListBox1.SelectedIndex
            };
            this.Close();
        }
    }
}

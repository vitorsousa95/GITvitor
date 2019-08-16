using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCadastroAluno.Classes;

namespace WinFormCadastroAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Aluno> alunos = new List<Aluno>();
        private object DataGridView1;

        private void BCadastrar_Click(object sender, EventArgs e)
        {
            CadastroAluno formCadastro = new CadastroAluno();
            formCadastro.ShowDialog();
            alunos.Add(formCadastro.novoAluno);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = alunos;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

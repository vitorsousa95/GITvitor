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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void BSalvar_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Idade = (int)nrIdade.Value;

            this.Close();
        }
    }
}

using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarAutor : Form
    {
        public frmAdicionarAutor()
        {
            InitializeComponent();
        }

        public Autor autoresRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            autoresRow = new Autor
            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text
            };
            this.Close();
        }
    }
}

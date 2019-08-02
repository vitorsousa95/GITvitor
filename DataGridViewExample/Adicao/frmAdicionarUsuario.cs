using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicao
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }
        public Ususarios usuariosRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow = new Ususarios
            {
                Usuario = textBox1.Text
            };

            this.Close();
        }
    }
}

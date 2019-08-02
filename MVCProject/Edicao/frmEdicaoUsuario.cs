using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Edicao
{
    public partial class frmEdicaoUsuario : Form
    {
        public frmEdicaoUsuario()
        {
            InitializeComponent();
        }

        MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow usuariosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow.Nome  = textBox1.Text;
            usuariosRow.Login = textBox2.Text;
            usuariosRow.Senha = textBox3.Text;
            usuariosRow.Email = textBox4.Text;

            this.Close();
        }


    }
}

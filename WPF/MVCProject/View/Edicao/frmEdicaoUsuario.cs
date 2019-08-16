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

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow Usuarios;

        private void FrmEdicaoUsuario_Load(object sender, EventArgs e)
        {
            textBox1.Text = Usuarios.Nome;
            textBox2.Text = Usuarios.Login;
            textBox3.Text = Usuarios.Senha;
            textBox4.Text = Usuarios.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Usuarios.Nome  = textBox1.Text;
            Usuarios.Login = textBox2.Text;
            Usuarios.Senha = textBox3.Text;
            Usuarios.Email = textBox4.Text;

            this.Close();
        }

        
    }
}

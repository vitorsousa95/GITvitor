using MVCProject.Adicionar;
using MVCProject.Edicao;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario addUser = new frmAdicionarUsuario();
            addUser.ShowDialog();

            if (!string.IsNullOrEmpty(addUser.usuarioRow?.Nome))

                this.usuariosTableAdapter.Insert(
                    addUser.usuarioRow.Nome,
                    addUser.usuarioRow.Login,
                    addUser.usuarioRow.Senha,
                    addUser.usuarioRow.Email,
                    true,
                    0,
                    0,
                    DateTime.Now,
                    DateTime.Now);

            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoUsuario editUser = new frmEdicaoUsuario
                        {
                            UsuariosRow = userSelect
                        };
                    }
                    break;
            }
        }
    }
}
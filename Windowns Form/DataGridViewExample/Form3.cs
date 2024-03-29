﻿using DataGridViewExample.Adicao;
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

namespace DataGridViewExample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerrysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(userSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios editUser = new frmEdicaoUsuarios();
                        editUser.UsuariosRow = userSelect;
                        editUser.ShowDialog();

                        this.usuariosTableAdapter.Update(editUser.UsuariosRow);
                    }
                    break;
            }
            
            this.usuariosTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario addUser = new frmAdicionarUsuario();
            addUser.ShowDialog();

            if (!string.IsNullOrEmpty(addUser.usuariosRow?.Usuario))
                this.usuariosTableAdapter.Insert(
                addUser.usuariosRow.Usuario,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);

            this.usuariosTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Usuarios);
        }
    }
}

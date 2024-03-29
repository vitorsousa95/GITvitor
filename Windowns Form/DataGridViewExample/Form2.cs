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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerrysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarcas = new frmEdicaoMarcas();
                        editMarcas.MarcasRow = marcasSelect;
                        editMarcas.ShowDialog();

                        this.marcasTableAdapter.Update(editMarcas.MarcasRow);

                    }break;

            }

            this.marcasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Marcas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarca addMarca = new frmAdicionarMarca();
            addMarca.ShowDialog();

            if (!string.IsNullOrEmpty(addMarca.marcaRow?.Nome))
                this.marcasTableAdapter.Insert(
                addMarca.marcaRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);
            this.marcasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Marcas);
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerrysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            frmAdicionarVendas addVendas = new frmAdicionarVendas();
            addVendas.ShowDialog();

            if (!string.IsNullOrEmpty(addVendas.vendasRow?.Carro.ToString()))
                this.vendasTableAdapter.Insert(
                addVendas.vendasRow.Carro,
                addVendas.vendasRow.Quantidade,
                addVendas.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);

            this.vendasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Vendas);
        }
    }
}

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
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.GetAllData(this.querrysInnerJoinDataSet1.DataTable1);
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lixoGlobal = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerrysInnerJoinDataSet1.DataTable1Row;

            switch(lixoGlobal.Tabela)
            {
                case "carros":
                    {
                        this.carrosTableAdapter1.UpdateQuery(lixoGlobal.Id);
                        MessageBox.Show("REATIVADO TURBOOOOOO");
                    }break;

                case "marcas":
                    {
                        this.marcasTableAdapter1.UpdateQuery(lixoGlobal.Id);
                        MessageBox.Show("REATIVADO TURBOOOOOO");
                    }
                    break;

                case "vendas":
                    {
                        this.vendasTableAdapter1.UpdateQuery(lixoGlobal.Id);
                        MessageBox.Show("REATIVADO TURBOOOOOO");
                    }
                    break;

                case "usuarios":
                    {
                        this.usuariosTableAdapter1.UpdateQuery(lixoGlobal.Id);
                        MessageBox.Show("REATIVADO TURBOOOOOO");
                    }
                    break;
            }

            this.dataTable1TableAdapter.GetAllData(this.querrysInnerJoinDataSet1.DataTable1);
        }
    }
}

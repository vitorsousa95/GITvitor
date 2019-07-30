using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoDeValores.Model;

namespace TabelaDeVisualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contract> listContracts = new List<Contract>();
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listContracts.Add(new Contract()
            {
                Id = listContracts.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            });

            var newList = new List<Contract>();

            foreach (Contract item in listContracts)
                newList.Add(new Contract()
                {
                    Id = item.Id,
                    Value = item.Value,
                    DatInc = item.DatInc
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex> -1)
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collumValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0:
                            {
                            MessageBox.Show("Não é possivel ajustar esta coluna");
                            } break;
                    case 1: {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                               , "Edição"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                listContracts.FirstOrDefault(x =>
                                x.Id == (int)(collumId.Value)).Value = (int)collumValue.Value;
                                }
                            } break;

                    case 2: {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                                   , "Edição"
                                   , MessageBoxButtons.YesNo
                                   , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collumValue.Value.ToString());
                                if (dataInformada <= DateTime.Now)
                                listContracts.FirstOrDefault(x =>
                                x.Id == (int)(collumId.Value)).DatInc = DateTime.Parse(collumValue.Value.ToString());
                                else
                                    MessageBox.Show("Não foi possivel alterar o registro de data.");
                            }
                        } break;
                }
            }
        }
    }
}

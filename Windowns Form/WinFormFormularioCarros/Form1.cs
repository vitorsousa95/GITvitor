using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormFormularioCarros.Class;

namespace WinFormFormularioCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Carro> carros = new List<Carro>();
        
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroCarro formCadastro = new CadastroCarro();
            formCadastro.ShowDialog();
            carros.Add(formCadastro.novoCarro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carros;

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
    }
}

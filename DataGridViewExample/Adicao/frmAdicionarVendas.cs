using DataGridViewExample.Model;
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
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        public Vendas vendasRow;

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querrysInnerJoinDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendasRow = new Vendas
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = int.Parse(textBox1.Text.ToString()),
                Valor = int.Parse(textBox2.Text.ToString())
            };

            this.Close();
        }
    }
}

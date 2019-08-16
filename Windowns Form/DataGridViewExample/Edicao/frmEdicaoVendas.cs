using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerrysInnerJoinDataSet1.VendasRow VendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            textBox1.Text = VendasRow.Quantidade.ToString();
            textBox2.Text = VendasRow.Valor.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendasRow.Quantidade = int.Parse(textBox1.Text);
            VendasRow.Valor = decimal.Parse(textBox2.Text);

            this.Close();
        }
    }
}

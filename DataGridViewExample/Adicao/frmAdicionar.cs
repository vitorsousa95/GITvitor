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
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

         public Carro carrosRow;

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro
            {
                Modelo = textBox1.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue
            };
    
            this.Close();
        }
    }
}

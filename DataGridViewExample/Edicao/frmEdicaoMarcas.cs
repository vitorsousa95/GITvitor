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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerrysInnerJoinDataSet1.MarcasRow MarcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querrysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuerry(this.querrysInnerJoinDataSet1.Usuarios);

            textBox1.Text           = MarcasRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome  = textBox1.Text;

            this.Close();
        }
    }
}

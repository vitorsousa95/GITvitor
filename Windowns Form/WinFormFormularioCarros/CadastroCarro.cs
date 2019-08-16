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
    public partial class CadastroCarro : Form
    {
        public CadastroCarro()
        {
            InitializeComponent();
        }

        public Carro novoCarro = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Nome = tbxNome.Text;
            novoCarro.Ano = int.Parse(tbxAno.Text.ToString());
            novoCarro.Placa = (tbxPlaca.Text)+"-"+int.Parse(tbxPlaca2.Text.ToString());

            this.Close();
        }
    }
}

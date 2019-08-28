using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinandoWebApiMVC.Models
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double QtdEstoque { get; set; }
        public bool Ativo { get; set; }

    }
}
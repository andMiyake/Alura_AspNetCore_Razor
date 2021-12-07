using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaRazor.Models
{
    public class Produto
    {
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public Produto(string nome, string descricao, decimal preco)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}
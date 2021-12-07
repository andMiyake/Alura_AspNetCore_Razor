using LojaRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaRazor.DAO
{
    public class ProdutosDAO
    {
        public IList<Produto> Ofertas()
        {
            return new List<Produto>() {
                new Produto("Monitor C123", "Monitor mais barato do mundo!!", 3m),
                new Produto("Monitor C987", "Melhor monitor do mundo fabricado por uma empresa desconhecida", 1000m),
                new Produto("HD 500TB", "HD de 500 TB, muito espaço para seus arquivos", 50000m)
            };
        }
    }
}
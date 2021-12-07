using LojaRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaRazor.DAO
{
    public class DepartamentosDAO
    {
        public IList<Departamento> Lista()
        {
            return new List<Departamento>()
            {
                NovoDepartamento("Informática", "Notebooks", "Monitores", "HDs"),
                NovoDepartamento("Eletrônicos", "TVs", "Rádios", "Video Cassete", "DVD Players"),
                NovoDepartamento("Entretenimento", "Filmes", "Músicas", "Brinquedos"),
                NovoDepartamento("Livros", "Aventura", "Ficção", "Universitários", "Romances", "Terror")
            };
        }

        private Departamento NovoDepartamento(string nome, params string[] categorias)
        {
            Departamento departamento = new Departamento();
            departamento.Nome = nome;
            foreach (string nomeCategoria in categorias)
            {
                Categoria categoria = new Categoria(nomeCategoria);
                departamento.Categorias.Add(categoria);
            }
            return departamento;
        }
    }
}